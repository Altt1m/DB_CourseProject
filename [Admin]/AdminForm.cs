using Azure.Core;
using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1._Admin_;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        Database db = new Database();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_сonnectionRequests_Click(object sender, EventArgs e)
        {
            ViewConnectionRequests(dataGridView_admin);
        }

        public void ViewConnectionRequests(DataGridView dgw)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string query = $@"
                SELECT 
                    ps.Id AS 'ID',
                    ps.Status AS 'Стан',
                    ps.Address AS 'Адреса',
                    ps.DateOfStart AS 'Дата початку',
                    c.LastName AS 'Прізвище',
                    c.FirstName AS 'Ім''я',
                    c.PhoneNumber AS 'Номер телефону',
                    c.Email AS 'Email'
                FROM 
                    ProvidedServices ps
                JOIN 
                    Clients c ON ps.ClientId = c.Id
                WHERE 
                    ps.Title = 'Підключення до мережі'
                ORDER BY 
                    ps.DateOfStart";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // Створимо новий DataTable для збереження результатів запиту

                adapter.Fill(dataTable); // Заповнимо DataTable результатами запиту
                dgw.DataSource = dataTable; // Прив'яжемо DataTable до DataGridView

                db.CloseConnection(connection);
            }
        }

        private void btn_repairRequests_Click(object sender, EventArgs e)
        {
            ViewRepairRequests(dataGridView_admin);
        }

        public void ViewRepairRequests(DataGridView dgw)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string query = $@"
                SELECT 
                    ps.Id AS 'ID',
                    ps.Address AS 'Адреса',
                    ps.Status AS 'Стан',
                    ps.DateOfStart AS 'Дата початку',
                    c.LastName AS 'Прізвище',
                    c.FirstName AS 'Ім''я',
                    c.PhoneNumber AS 'Номер телефону',
                    c.Email AS 'Email'
                FROM 
                    ProvidedServices ps
                JOIN 
                    Clients c ON ps.ClientId = c.Id
                WHERE 
                    ps.Title LIKE 'Ремонт:%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // Створимо новий DataTable для збереження результатів запиту

                adapter.Fill(dataTable); // Заповнимо DataTable результатами запиту
                dgw.DataSource = dataTable; // Прив'яжемо DataTable до DataGridView

                db.CloseConnection(connection);
            }
        }

        private void btn_formConnectionRequest_Click(object sender, EventArgs e)
        {
            ChooseRequestIdForm requestId = new ChooseRequestIdForm("connection");
            requestId.ShowDialog();
        }

        private void btn_formRepairRequest_Click(object sender, EventArgs e)
        {
            ChooseRequestIdForm requestId = new ChooseRequestIdForm("repair");
            requestId.ShowDialog();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            decimal total;

            string selectQuery = @"
            SELECT SUM(TotalSum) AS TotalSumTotal
            FROM EmployeesPayments 
            WHERE DateOfPayment IS NULL";

            string updateQuery = $@"
                UPDATE EmployeesPayments
                SET DateOfPayment = @Date
                WHERE DateOfPayment IS NULL";

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

                    MessageBox.Show($"{DateTime.Today.Date} було виплачено {total:F2} грн.", "Виплата робітникам", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.CloseConnection(connection);
                }
                else
                {
                    MessageBox.Show($"Виплата нікому не потрібна", "Виплата робітникам", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.CloseConnection(connection);
                }

            }

        }
    }
}