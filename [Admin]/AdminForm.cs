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
                    ps.Status AS '����',
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
                    ps.Title = 'ϳ��������� �� �����'
                ORDER BY 
                    ps.DateOfStart";

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
                    ps.Status AS '����',
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

                try
                {
                    total = (decimal)selectCommand.ExecuteScalar();
                }
                catch
                {
                    total = 0;
                }
                

                if (total > 0)
                {
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show($"{DateTime.Today.Date} ���� ��������� {total:F2} ���.", "������� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.CloseConnection(connection);
                }
                else
                {
                    MessageBox.Show($"������� ����� �� �������", "������� ���������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.CloseConnection(connection);
                }

            }

        }

        private void btn_purchases_Click(object sender, EventArgs e)
        {
            ViewPurchases(dataGridView_admin);
        }

        private void ViewPurchases(DataGridView dgw)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);
                string query = $@"
                SELECT 
                    m.Title AS '�������',
                    s.Title AS '������������',
                    mp.MaterialsCount AS 'ʳ������',
                    mp.DateOfPurchase AS '���� �������',
                    FORMAT(mp.TotalSum, 'N2') AS '����'
                FROM 
                    MaterialsPurchases mp
                JOIN
                    Suppliers s ON s.Id = mp.SupplierId
                JOIN
                    Materials m ON m.Id = mp.MaterialId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable(); // �������� ����� DataTable ��� ���������� ���������� ������

                adapter.Fill(dataTable); // ��������� DataTable ������������ ������
                dgw.DataSource = dataTable; // ����'����� DataTable �� DataGridView

                db.CloseConnection(connection);
            }
        }

        private void btn_purchaseMaterials_Click(object sender, EventArgs e)
        {
            PurchaseMaterialsForm form = new PurchaseMaterialsForm();
            form.ShowDialog();
        }
    }
}