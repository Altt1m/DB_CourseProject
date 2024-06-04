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
            string query = $"SELECT Id FROM ProvidedServices" +
                            $" WHERE Title='Підключення до мережі' AND ClientId='{clientId}'";

            SqlCommand command = new SqlCommand(query, connection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count >= 1)
            {
                btn_createConnectionRequest.Enabled = false;
            }
        }

        public void LockConnectionRequestButton()
        {
            btn_createConnectionRequest.Enabled = false;
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
    }
}
