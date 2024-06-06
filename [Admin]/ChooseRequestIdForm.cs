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

namespace WinFormsApp1._Admin_
{
    public partial class ChooseRequestIdForm : Form
    {
        Database db = new Database();
        string requestType;

        public ChooseRequestIdForm(string type)
        {
            InitializeComponent();
            requestType = type;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            // Перевірка коректності введення ID
            if (!int.TryParse(textBox_Id.Text, out int id))
            {
                MessageBox.Show("Будь ласка, введіть коректний числовий ID.", "Невірний ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Запит для перевірки існування рядка з таким ID
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = null;
                if (requestType == "connection")
                {
                    query = "SELECT COUNT(*) FROM ProvidedServices " +
                        "WHERE Id = @Id AND Title = 'Підключення до мережі' AND Status = 'Опрацьовується'";
                }
                else if (requestType == "repair")
                {
                    query = "SELECT COUNT(*) FROM ProvidedServices " +
                        "WHERE Id = @Id AND Title LIKE 'Ремонт:%' AND Status = 'Опрацьовується'";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                int count = (int)command.ExecuteScalar();

                db.CloseConnection(connection);

                // Перевірка, чи знайдено рядок з таким ID
                if (count == 0)
                {
                    MessageBox.Show($"Рядок з ID {id} не знайдено.", "ID не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show($"Рядок з ID {id} знайдено.", "ID знайдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    int requestId = Convert.ToInt32(textBox_Id.Text);
                    FormRequestForm formRequest = new FormRequestForm(requestType, requestId);
                    formRequest.ShowDialog();
                    this.Close();
                    return;
                    // Додаткові дії можна реалізувати тут
                }
            }
        }

    }
}
