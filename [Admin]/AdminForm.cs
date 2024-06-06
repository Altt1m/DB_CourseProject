using Microsoft.Data.SqlClient;
using System.Data;

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
                    ps.Title = 'Підключення до мережі'";

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
    }
}