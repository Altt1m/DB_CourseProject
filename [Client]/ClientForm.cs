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
using WinFormsApp1._Client_;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class ClientForm : Form
    {
        Database db = new Database();
        int clientId;

        public ClientForm(int userId)
        {
            InitializeComponent();

            clientId = userId;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlConnection connection = db.GetConnection();

            string connectionCheckQuery = $"SELECT Id FROM ProvidedServices" +
                            $" WHERE Title='Підключення до мережі' AND ClientId={clientId}";

            string addressCheckQuery = $"SELECT Address FROM ProvidedServices WHERE ClientId={clientId}";

            SqlCommand connectionCheckCommand = new SqlCommand(connectionCheckQuery, connection);
            SqlCommand addressCheckCommand = new SqlCommand(addressCheckQuery, connection);

            adapter.SelectCommand = connectionCheckCommand;
            adapter.Fill(table);

            if (table.Rows.Count >= 1)
            {
                btn_createConnectionRequest.Enabled = false;
            }

            adapter.SelectCommand = addressCheckCommand;
            adapter.Fill(table);

            if (table.Rows.Count != 0 && table.Rows[0]["Address"] != null) btn_createRepairRequest.Enabled = true;

        }

        public void LockConnectionRequestButton()
        {
            btn_createConnectionRequest.Enabled = false;
        }

        private void btn_viewAllRequests_Click(object sender, EventArgs e)
        {
            ViewAllRequests(dataGridView_client);
        }

        public void ViewAllRequests(DataGridView dgw)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string query = $"SELECT " +
                    $"Status AS 'Стан'," +
                    $"Title AS 'Опис'," +
                    $"Address AS 'Адреса'," +
                    $"DateOfStart AS 'Дата початку'," +
                    $"DateOfFinish AS 'Дата завершення'," +
                    $"Price AS 'Вартість' " +
                    $"FROM ProvidedServices WHERE ClientId = {clientId}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // Створимо новий DataTable для збереження результатів запиту

                adapter.Fill(dataTable); // Заповнимо DataTable результатами запиту
                dgw.DataSource = dataTable; // Прив'яжемо DataTable до DataGridView

                db.CloseConnection(connection);
            }
        }

        private void btn_viewSettlements_Click(object sender, EventArgs e)
        {
            ViewAllSettlements(dataGridView_client);
        }

        public void ViewAllSettlements(DataGridView dgw)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string query = $"SELECT " +
                    $"Status AS 'Стан'," +
                    $"DateOfCreation AS 'Дата створення'," +
                    $"DateOfSettlement AS 'Дата сплати'," +
                    $"CONCAT(FORMAT(TotalSum, 'N2'), ' грн.') AS 'Сума' " + // Форматування суми з двома десятковими знаками і додавання "грн."
                    $"FROM ClientsSettlements WHERE ClientId = {clientId}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // Створимо новий DataTable для збереження результатів запиту

                adapter.Fill(dataTable); // Заповнимо DataTable результатами запиту
                dgw.DataSource = dataTable; // Прив'яжемо DataTable до DataGridView

                db.CloseConnection(connection);
            }
        }


        private void btn_viewAccountDetails_Click(object sender, EventArgs e)
        {
            dataGridView_client.Columns.Clear(); // Очистити стовпці

            ViewAccountDetails(dataGridView_client);
        }

        public void ViewAccountDetails(DataGridView dgw)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string query = $"SELECT " +
                    $"LastName AS 'Прізвище', " +
                    $"FirstName AS 'Ім`я', " +
                    $"MiddleName AS 'По батькові', " +
                    $"Email AS 'Пошта', " +
                    $"PhoneNumber AS 'Телефон', " +
                    $"Address AS 'Адреса' " +
                    $"FROM Clients " +
                    $"WHERE Id = {clientId}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // Створимо новий DataTable для збереження результатів запиту

                adapter.Fill(dataTable); // Заповнимо DataTable результатами запиту
                dgw.DataSource = dataTable; // Прив'яжемо DataTable до DataGridView

                db.CloseConnection(connection);
            }
        }

        private void btn_createConnectionRequest_Click(object sender, EventArgs e)
        {
            CreateConnectionRequestForm connectionRequest = new CreateConnectionRequestForm(clientId, this);
            connectionRequest.ShowDialog();
        }

        private void btn_createRepairRequest_Click(object sender, EventArgs e)
        {
            CreateRepairRequestForm repairRequest = new CreateRepairRequestForm(clientId);
            repairRequest.ShowDialog();
        }

        private void btn_editAccountDetails_Click(object sender, EventArgs e)
        {
            EditAccountDetailsForm editDetails = new EditAccountDetailsForm(clientId);
            editDetails.ShowDialog();
        }

        private void btn_payDebts_Click(object sender, EventArgs e)
        {
            PayDebts(clientId);
        }

        private void PayDebts(int clientId)
        {
            decimal total;

            string selectQuery = @"
            SELECT SUM(TotalSum) AS TotalSumTotal
            FROM ClientsSettlements 
            WHERE DateOfSettlement IS NULL";

            string updateQuery = $@"
                UPDATE ClientsSettlements
                SET DateOfSettlement = @Date
                WHERE DateOfSettlement IS NULL";

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@Date", DateTime.Today);

                total = (decimal)selectCommand.ExecuteScalar();

                if (total > 0)
                {
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show($"Ви сплатили {total:F2} грн.", "Борг", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.CloseConnection(connection);
                }
                else
                {
                    MessageBox.Show($"У вас немає боргів", "Борг", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.CloseConnection(connection);
                }

            }
        }
    }
}