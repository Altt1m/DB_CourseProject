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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1._Client_
{
    public partial class CreateRepairRequestForm : Form
    {
        Database db = new Database();
        int clientId;

        public CreateRepairRequestForm(int userId)
        {
            InitializeComponent();
            clientId = userId;
        }

        private void btn_createRepairRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Description.Text))
            {
                MessageBox.Show("Опишіть вашу проблему.", "Опис", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox_Description.Text.Length > 250)
            {
                MessageBox.Show("Опишіть коротше (до 250 символів).", "Опис", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((dateTimePicker_Begin.Value - DateTime.Now).TotalDays < 0)
            {
                MessageBox.Show("Оберіть щонайменше сьогоднішню дату.", "Дата початку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string requestDescription = textBox_Description.Text;
            DateTime requestDateTime = dateTimePicker_Begin.Value;

            SqlConnection connection = db.GetConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string selectAddressQuery = $"SELECT Address FROM Clients WHERE Id = {clientId}";

            string requestQuery = $"INSERT INTO ProvidedServices (ClientId, Status, Title, Address, DateOfStart) " +
                      $"VALUES (@ClientId, 'Опрацьовується', 'Ремонт:{requestDescription}', @Address, @DateOfStart)";

            SqlTransaction transaction = null;
            try
            {
                db.OpenConnection(connection);
                transaction = connection.BeginTransaction();


                SqlCommand selectAddressCommand = new SqlCommand(selectAddressQuery, connection, transaction);

                adapter.SelectCommand = selectAddressCommand;
                adapter.Fill(table);

                string clientAddress = (string)table.Rows[0]["Address"];


                SqlCommand requestCommand = new SqlCommand(requestQuery, connection, transaction);
                // Додавання параметрів
                requestCommand.Parameters.AddWithValue("@ClientId", clientId);
                requestCommand.Parameters.AddWithValue("@Address", clientAddress);
                requestCommand.Parameters.AddWithValue("@DateOfStart", requestDateTime);

                requestCommand.ExecuteNonQuery();

                transaction.Commit();
                db.CloseConnection(connection);

                MessageBox.Show("Запит створено успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                transaction?.Rollback();
                db.CloseConnection(connection);
                this.Hide();
                this.Close();
                return;
            }
        }
    }
}
