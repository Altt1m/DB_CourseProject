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
    public partial class ClientAuthForm : Form
    {
        Database db = new Database();

        public ClientAuthForm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RoleSelectionForm roleSelection = new RoleSelectionForm();

            this.Hide();

            roleSelection.ShowDialog();

            this.Close();
        }

        private void label_register_Click(object sender, EventArgs e)
        {
            ClientRegisterForm clientRegister = new ClientRegisterForm();

            this.Hide();

            clientRegister.ShowDialog();

            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userLogin = textBox_login.Text;
            string userPass = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlConnection connection = db.GetConnection();

            string query = $"SELECT Id, Login, Password, IsAdmin FROM Accounts" +
                            $" WHERE Login='{userLogin}' AND Password='{userPass}' AND IsAdmin=0";

            SqlCommand command = new SqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                int userId = (int)table.Rows[0]["Id"];

                db.OpenConnection(connection);

                string clientQuery = $"SELECT Id FROM Clients WHERE Id = {userId}";
                SqlCommand clientCommand = new SqlCommand(clientQuery, connection);
                int clientId = (int)clientCommand.ExecuteScalar();

                db.CloseConnection(connection);

                ClientForm client = new ClientForm(clientId);
                this.Hide();
                client.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Пароль неправильний або такої обліковки не існує", "Пароль неправильний", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
