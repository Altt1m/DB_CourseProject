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
    public partial class PurchaseMaterialsForm : Form
    {
        Database db = new Database();

        public PurchaseMaterialsForm()
        {
            InitializeComponent();
            LoadSuppliers();
            LoadMaterials();
        }

        private void LoadSuppliers()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = "SELECT Title FROM Suppliers";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_supplier.Items.Add(reader["Title"].ToString());
                }

                reader.Close();
                db.CloseConnection(connection);
            }
        }

        private void LoadMaterials()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = "SELECT Title FROM Materials";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_material.Items.Add(reader["Title"].ToString());
                }

                reader.Close();
                db.CloseConnection(connection);
            }
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (comboBox_supplier.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть постачальника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox_material.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть матеріал.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox_count.Text, out int materialCount) || materialCount <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість матеріалу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int supplierId = comboBox_supplier.SelectedIndex + 1;
            int materialId = comboBox_material.SelectedIndex + 1;

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                // Отримання ціни матеріалу
                string getPriceQuery = "SELECT Price FROM Materials WHERE Id = @MaterialId";
                SqlCommand getPriceCommand = new SqlCommand(getPriceQuery, connection);
                getPriceCommand.Parameters.AddWithValue("@MaterialId", materialId);
                int materialPrice = (int)getPriceCommand.ExecuteScalar();

                decimal totalSum = materialCount * materialPrice;

                // Додавання покупки
                string insertQuery = @"
                    INSERT INTO MaterialsPurchases 
                    (MaterialId, SupplierId, MaterialsCount, DateOfPurchase, TotalSum) 
                    VALUES 
                    (@MaterialId, @SupplierId, @MaterialsCount, @DateOfPurchase, @TotalSum)";

                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@MaterialId", materialId);
                insertCommand.Parameters.AddWithValue("@SupplierId", supplierId);
                insertCommand.Parameters.AddWithValue("@MaterialsCount", materialCount);
                insertCommand.Parameters.AddWithValue("@DateOfPurchase", DateTime.Now);
                insertCommand.Parameters.AddWithValue("@TotalSum", totalSum);

                int rowsAffected = insertCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Оновлення кількості матеріалу
                    string updateAmountQuery = @"
                        UPDATE Materials
                        SET Amount = Amount + @MaterialsCount
                        WHERE Id = @MaterialId";

                    SqlCommand updateAmountCommand = new SqlCommand(updateAmountQuery, connection);
                    updateAmountCommand.Parameters.AddWithValue("@MaterialsCount", materialCount);
                    updateAmountCommand.Parameters.AddWithValue("@MaterialId", materialId);

                    updateAmountCommand.ExecuteNonQuery();

                    MessageBox.Show($"Ви успішно придбали:\n" +
                        $"{comboBox_material.SelectedItem}:{materialCount} на суму {totalSum}.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не вдалося здійснити покупку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                db.CloseConnection(connection);
            }


        }
    }
}
