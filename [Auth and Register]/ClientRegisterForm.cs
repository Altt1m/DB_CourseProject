using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class ClientRegisterForm : Form
    {
        Database db = new Database();

        public ClientRegisterForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text.Length < 3)
            {
                MessageBox.Show("Логін має містити хоча б 3 символи.", "Логін", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_password.Text.Length < 6)
            {
                MessageBox.Show("Пароль має містити хоча б 6 символів.", "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_firstName.Text) || string.IsNullOrWhiteSpace(textBox_lastName.Text)
                || string.IsNullOrWhiteSpace(textBox_middleName.Text))
            {
                MessageBox.Show("Ім'я відсутнє або введено некоректно.", "ПІБ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!textBox_email.Text.Contains("@"))
            {
                MessageBox.Show("Адрес електронної пошти введено некоректно.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_phoneNumber.Text))
            {
                MessageBox.Show("Номер телефону відсутній або введений некоректно.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(textBox_phoneNumber.Text, @"^\+\d{12}$")) // +380000000001
            {
                MessageBox.Show("Номер телефону не відповідає міжнародному формату.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string clientLogin = textBox_login.Text;
            string clientPass = textBox_password.Text;
            string clientFirstName = textBox_firstName.Text;
            string clientLastName = textBox_lastName.Text;
            string clientMiddleName = textBox_middleName.Text;
            string clientEmail = textBox_email.Text;
            string clientPhoneNumber = textBox_phoneNumber.Text;

            SqlConnection connection = db.GetConnection();

            string insertQuery = $"INSERT INTO Accounts (Login, Password, IsAdmin) " +
                           $"VALUES ('{clientLogin}', '{clientPass}', 0) " +

                           $"INSERT INTO Clients (FirstName, MiddleName, LastName, Email, PhoneNumber, Address) " +
                           $"VALUES ('{clientFirstName}', '{clientMiddleName}', '{clientLastName}', " +
                           $"'{clientEmail}', '{clientPhoneNumber}', '')";

            SqlTransaction transaction = null;
            try
            {
                db.OpenConnection(connection);
                transaction = connection.BeginTransaction();

                SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction);

                insertCommand.ExecuteNonQuery();

                transaction.Commit();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string selectQuery = $"SELECT Id, Login, Password, IsAdmin FROM Accounts" +
                            $" WHERE Login='{clientLogin}' AND Password='{clientPass}' AND IsAdmin=0";

                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);

                adapter.SelectCommand = selectCommand;
                adapter.Fill(table);

                int userId = (int)table.Rows[0]["Id"];

                string clientQuery = $"SELECT Id FROM Clients WHERE Id = {userId}";
                SqlCommand clientCommand = new SqlCommand(clientQuery, connection);
                int clientId = (int)clientCommand.ExecuteScalar();
                
                db.CloseConnection(connection);

                ClientForm client = new ClientForm(clientId);
                this.Hide();
                client.ShowDialog();
                this.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                transaction?.Rollback();
                db.CloseConnection(connection);
                if (ex.Message.Contains("Login")) // Перевіряємо, чи повідомлення містить інформацію про конфлікт унікальності для PhoneNumber
                {
                    MessageBox.Show("Цей логін вже зайнятий.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("PhoneNumber")) // Перевіряємо, чи повідомлення містить інформацію про конфлікт унікальності для PhoneNumber
                {
                    MessageBox.Show("Цей номер телефону вже зайнятий.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Contains("Email")) // Перевіряємо, чи повідомлення містить інформацію про конфлікт унікальності для Email
                {
                    MessageBox.Show("Цей еmail вже зайнятий.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                transaction?.Rollback();
                db.CloseConnection(connection);
            }
        }
    }
}
