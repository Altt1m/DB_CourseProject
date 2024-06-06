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

        private void btn_�onnectionRequests_Click(object sender, EventArgs e)
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
                    ps.Address AS '������',
                    ps.DateOfStart AS '���� �������',
                    c.LastName AS '�������',
                    c.FirstName AS '��''�',
                    c.PhoneNumber AS '����� ��������',
                    c.Email AS 'Email'
                FROM 
                    ProvidedServices ps
                JOIN 
                    Clients c ON ps.ClientId = c.Id
                WHERE 
                    ps.Title = 'ϳ��������� �� �����'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // �������� ����� DataTable ��� ���������� ���������� ������

                adapter.Fill(dataTable); // ��������� DataTable ������������ ������
                dgw.DataSource = dataTable; // ����'����� DataTable �� DataGridView

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
                    ps.Address AS '������',
                    ps.DateOfStart AS '���� �������',
                    c.LastName AS '�������',
                    c.FirstName AS '��''�',
                    c.PhoneNumber AS '����� ��������',
                    c.Email AS 'Email'
                FROM 
                    ProvidedServices ps
                JOIN 
                    Clients c ON ps.ClientId = c.Id
                WHERE 
                    ps.Title LIKE '������:%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // �������� ����� DataTable ��� ���������� ���������� ������

                adapter.Fill(dataTable); // ��������� DataTable ������������ ������
                dgw.DataSource = dataTable; // ����'����� DataTable �� DataGridView

                db.CloseConnection(connection);
            }
        }
    }
}