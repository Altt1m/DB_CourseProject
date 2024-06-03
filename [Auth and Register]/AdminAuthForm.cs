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
    public partial class AdminAuthForm : Form
    {
        Database db = new Database();

        public AdminAuthForm()
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            string adminLogin = textBox_login.Text;
            string adminPass = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlConnection connection = db.GetConnection();

            string query = $"SELECT Id, Login, Password, IsAdmin FROM Accounts" +
                            $" WHERE Login='{adminLogin}' AND Password='{adminPass}' AND IsAdmin=1";

            SqlCommand command = new SqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                AdminForm client = new AdminForm();
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
