using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CreateConnectionRequestForm : Form
    {
        Database db = new Database();
        int clientId;
        ClientForm clientForm;

        public CreateConnectionRequestForm(int userId, ClientForm form)
        {
            InitializeComponent();
            clientId = userId;
            clientForm = form;
        }

        private void btn_createConnectionRequest_Click(object sender, EventArgs e)
        {
            if (textBox_Address.Text.Length < 5)
            {
                MessageBox.Show("Адреса має містити хоча б 5 символів.", "Адреса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((dateTimePicker_Begin.Value - DateTime.Now).TotalDays < 2)
            {
                MessageBox.Show("Оберіть дату щонайменше через три дні.", "Дата початку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string requestAddress = textBox_Address.Text;
            DateTime requestDateTime = dateTimePicker_Begin.Value;

            SqlConnection connection = db.GetConnection();

            string requestQuery = $"INSERT INTO ProvidedServices (ClientId, Status, Title, Address, DateOfStart)" +
                   $"VALUES ({clientId}, 'Опрацьовується', 'Підключення до мережі', '{requestAddress}', '{requestDateTime}')";

            SqlTransaction transaction = null;
            try
            {
                db.OpenConnection(connection);
                transaction = connection.BeginTransaction();

                SqlCommand requestCommand = new SqlCommand(requestQuery, connection, transaction);

                requestCommand.ExecuteNonQuery();

                transaction.Commit();
                db.CloseConnection(connection);

                MessageBox.Show("Запит створено успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientForm.LockConnectionRequestButton();
                this.Hide();
                this.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                transaction?.Rollback();
                db.CloseConnection(connection);
                this.Hide();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                transaction?.Rollback();
                db.CloseConnection(connection);
                this.Hide();
                this.Close();
            }


        }
    }
}
