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
using System.Windows.Forms;

namespace WinFormsApp1._Client_
{
    public partial class EditAccountDetailsForm : Form
    {
        Database db = new Database();
        int clientId;
        string email, phoneNumber;

        public EditAccountDetailsForm(int userId)
        {
            InitializeComponent();
            clientId = userId;

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string query = $"SELECT " +
                    $"Email, PhoneNumber " +
                    $"FROM Clients " +
                    $"WHERE Id = {clientId}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable(); // Створимо новий DataTable для збереження результатів запиту

                adapter.Fill(table);

                email = (string)table.Rows[0]["Email"];
                phoneNumber = (string)table.Rows[0]["PhoneNumber"];

                db.CloseConnection(connection);

                textBox_email.Text = email;
                textBox_phoneNumber.Text = phoneNumber;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з текстових полів
            string newEmail = textBox_email.Text;
            string newPhoneNumber = textBox_phoneNumber.Text;

            // Перевірки коректності введених даних
            if (!newEmail.Contains("@"))
            {
                MessageBox.Show("Адрес електронної пошти введено некоректно.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(newPhoneNumber))
            {
                MessageBox.Show("Номер телефону відсутній або введений некоректно.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(newPhoneNumber, @"^\+\d{12}$")) // +380000000001
            {
                MessageBox.Show("Номер телефону не відповідає міжнародному формату.", "Номер телефону", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Виконуємо перевірку на унікальність даних
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string checkQuery = $"SELECT COUNT(*) FROM Clients " +
                    $"WHERE (Email = @Email OR PhoneNumber = @PhoneNumber) AND Id != @ClientId";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", newEmail);
                    checkCommand.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                    checkCommand.Parameters.AddWithValue("@ClientId", clientId);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Вказаний email або номер телефону вже зайнятий іншим користувачем.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.CloseConnection(connection);
                        return;
                    }
                }

                // Виконуємо оновлення даних клієнта в базі даних
                string updateQuery = $"UPDATE Clients SET " +
                    $"Email = @Email, " +
                    $"PhoneNumber = @PhoneNumber " +
                    $"WHERE Id = @ClientId";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Email", newEmail);
                    updateCommand.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                    updateCommand.Parameters.AddWithValue("@ClientId", clientId);

                    updateCommand.ExecuteNonQuery(); // Виконуємо SQL-запит
                }

                db.CloseConnection(connection);
            }

            MessageBox.Show("Дані клієнта успішно оновлені!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            this.Close();
        }
    }

}
