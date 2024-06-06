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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1._Admin_
{
    public partial class FormRequestForm : Form
    {
        string requestType;
        int requestId;
        Database db = new Database();

        public FormRequestForm(string type, int id)
        {
            InitializeComponent();
            requestType = type;
            requestId = id;

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = null;
                if (requestType == "connection")
                {
                    query = $@"
                    SELECT 
                        ps.Id AS 'ID',
                        ps.ClientID AS 'CID',
                        ps.Address AS 'Адреса',
                        ps.DateOfStart AS 'Дата початку',
                        ps.Title AS 'Опис',
                        c.LastName AS 'Прізвище',
                        c.FirstName AS 'Ім''я'
                    FROM 
                        ProvidedServices ps
                    JOIN 
                        Clients c ON ps.ClientId = c.Id
                    WHERE 
                        ps.Id = {requestId}";
                    textBox_description.Enabled = false;
                }
                else if (requestType == "repair")
                {
                    query = $@"
                    SELECT 
                        ps.Id AS 'ID',
                        ps.ClientID AS 'CID',
                        ps.Address AS 'Адреса',
                        ps.DateOfStart AS 'Дата початку',
                        ps.Title AS 'Опис',
                        c.LastName AS 'Прізвище',
                        c.FirstName AS 'Ім''я'
                    FROM 
                        ProvidedServices ps
                    WHERE 
                        ps.Id = {requestId}";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable(); // Створимо новий DataTable для збереження результатів запиту

                adapter.Fill(table);

                db.CloseConnection(connection);

                textBox_Id.Text = table.Rows[0]["ID"].ToString();
                textBox_clientId.Text = table.Rows[0]["CID"].ToString();
                textBox_firstName.Text = table.Rows[0]["Ім'я"].ToString();
                textBox_lastName.Text = table.Rows[0]["Прізвище"].ToString();
                textBox_address.Text = table.Rows[0]["Адреса"].ToString();
                textBox_description.Text = table.Rows[0]["Опис"].ToString();

                dateTimePicker_dateOfStart.Value = (DateTime)table.Rows[0]["Дата початку"];

                
            }
        }


    }
}
