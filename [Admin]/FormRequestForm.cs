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

                string query = $@"
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
                if (requestType == "connection") textBox_description.Enabled = false;

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

                LoadTeamIds();

                dateTimePicker_dateOfStart.Value = (DateTime)table.Rows[0]["Дата початку"];


            }
        }

        private void btn_formRequest_Click(object sender, EventArgs e)
        {
            // Перевірка дати
            if (dateTimePicker_dateOfStart.Value < DateTime.Today)
            {
                MessageBox.Show("Дата початку не може бути меншою за сьогоднішню дату.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dateTimePicker_dateOfFinish.Value < dateTimePicker_dateOfStart.Value)
            {
                MessageBox.Show("Дата завершення не може бути меншою за дату початку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка вартості
            if (!decimal.TryParse(textBox_price.Text, out decimal cost) || cost <= 0)
            {
                MessageBox.Show("Вартість має бути більше 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка доступності бригади
            int selectedTeamId;
            if (comboBox_teams.SelectedItem != null)
            {
                selectedTeamId = int.Parse(comboBox_teams.SelectedItem.ToString());
                using (SqlConnection connection = db.GetConnection())
                {
                    db.OpenConnection(connection);
                    string query = @"
                        SELECT MAX(DateOfFinish) AS LastFinishDate
                        FROM ProvidedServices
                        WHERE TechTeamId = @TeamId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TeamId", selectedTeamId);
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        DateTime lastEndDate = (DateTime)result;
                        if (lastEndDate >= DateTime.Today)
                        {
                            MessageBox.Show("Обрана бригада зайнята. Виберіть іншу бригаду або перевірте доступність пізніше.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            db.CloseConnection(connection);
                            return;
                        }
                    }
                    db.CloseConnection(connection);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть бригаду.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Оновлення статусу послуги
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string updateQuery = $@"
                UPDATE ProvidedServices
                SET Status = 'Виконано',
                    TechTeamId = @TeamId,
                    DateOfFinish = @DateOfFinish,
                    Price = @Price
                WHERE Id = {requestId}";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@DateOfFinish", dateTimePicker_dateOfFinish.Value);
                updateCommand.Parameters.AddWithValue("@Price", Convert.ToInt32(textBox_price.Text));
                updateCommand.Parameters.AddWithValue("@TeamId", selectedTeamId);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                db.CloseConnection(connection);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Статус послуги оновлено до 'Виконано'.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не вдалося оновити статус послуги.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (requestType == "connection") UpdateClientAddress(textBox_address.Text);

            CreateSettlement(Convert.ToInt32(textBox_clientId.Text), Convert.ToInt32(textBox_price.Text));
            CreatePayments(selectedTeamId);

            this.Hide(); this.Close();
        }

        private void CreateSettlement(int clientId, decimal price)
        {
            string query = $@"
            INSERT INTO ClientsSettlements (ClientId, Status, DateOfCreation, TotalSum)
            VALUES ({clientId}, 'Борг', @Date, {price})";

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                SqlCommand updateCommand = new SqlCommand(query, connection);

                updateCommand.Parameters.AddWithValue("@Date", dateTimePicker_dateOfFinish.Value);

                updateCommand.ExecuteNonQuery();

                db.CloseConnection(connection);
            }
        }

        private void CreatePayments(int selectedTeamId)
        {
            // Розрахунок різниці у датах
            TimeSpan duration = dateTimePicker_dateOfFinish.Value - dateTimePicker_dateOfStart.Value;

            // Отримання працівників обраної бригади
            DataTable teamTable = GetTeamMembers(selectedTeamId);

            // Розрахунок та збереження оплати для кожного працівника
            foreach (DataRow row in teamTable.Rows)
            {
                int employeeId = (int)row["Id"];
                decimal salaryPerHour = GetSalaryPerHour(employeeId); // Отримання погодинної зарплати
                int workedHours = (duration.Days + 1) * 6; // Кількість годин
                decimal totalSum = salaryPerHour * workedHours; // Розрахунок загальної суми

                // Збереження розрахунку у таблицю EmployeesPayments
                SaveEmployeePayment(employeeId, salaryPerHour, workedHours, totalSum);
            }

            DataTable employeesTable = GetNonTeamEmployees();

            foreach (DataRow row in employeesTable.Rows)
            {
                int employeeId = (int)row["Id"];
                decimal salaryPerHour = GetSalaryPerHour(employeeId);
                int workedHours = (duration.Days + 1) * 4; // Кількість годин
                decimal totalSum = salaryPerHour * workedHours; // Розрахунок загальної суми

                // Збереження розрахунку у таблицю EmployeesPayments
                SaveEmployeePayment(employeeId, salaryPerHour, workedHours, totalSum);
            }

        }

        private DataTable GetTeamMembers(int teamId)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = @"
                SELECT e.Id, SalaryPerHour 
                FROM Employees e
                JOIN Positions p ON e.PositionId = p.Id 
                WHERE e.TechTeamId = @TeamId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TeamId", teamId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                db.CloseConnection(connection);

                return table;
            }
        }

        private DataTable GetNonTeamEmployees()
        {
            string query = "SELECT e.Id, SalaryPerHour " +
                "FROM Employees e " +
                "JOIN Positions p ON e.PositionId = p.Id " +
                "WHERE e.PositionId <> 1";

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                db.CloseConnection(connection);

                return table;
            }

        }

        private decimal GetSalaryPerHour(int employeeId)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = @"
                SELECT SalaryPerHour
                FROM Employees e
                JOIN Positions p ON p.Id = e.PositionId 
                WHERE e.Id = @EmployeeId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                decimal salaryPerHour = (decimal)command.ExecuteScalar();

                db.CloseConnection(connection);

                return salaryPerHour;
            }
        }

        private void SaveEmployeePayment(int employeeId, decimal salaryPerHour, int workedHours, decimal totalSum)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = @"
                INSERT INTO EmployeesPayments (EmployeeId, SalaryPerHour, WorkedHours, DateOfPayment, TotalSum)
                VALUES (@EmployeeId, @SalaryPerHour, @WorkedHours, @DateOfPayment, @TotalSum)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                command.Parameters.AddWithValue("@SalaryPerHour", salaryPerHour);
                command.Parameters.AddWithValue("@WorkedHours", workedHours);
                command.Parameters.AddWithValue("@DateOfPayment", DBNull.Value);
                command.Parameters.AddWithValue("@TotalSum", totalSum);


                command.ExecuteNonQuery();

                db.CloseConnection(connection);
            }
        }


        private void btn_removeRequest_Click(object sender, EventArgs e)
        {
            RemoveRequest(requestId);
        }

        public void RemoveRequest(int reqId)
        {
            string query = $"DELETE FROM ProvidedServices WHERE Id = {requestId}";

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                SqlCommand command = new SqlCommand(query, connection);

                int rowsAffected = command.ExecuteNonQuery();

                db.CloseConnection(connection);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запит успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    this.Close(); // Закриття форми
                }
                else
                {
                    MessageBox.Show("Не вдалося видалити запит. Можливо, він вже опрацьований.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadTeamIds()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                string query = "SELECT Id FROM TechTeams";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox_teams.Items.Add(reader["Id"].ToString());
                }

                reader.Close();
                db.CloseConnection(connection);
            }
        }

        private void UpdateClientAddress(string address)
        {
            string updateAddressQuery = $@"
            UPDATE Clients
            SET Address = @Address
            WHERE Id = (SELECT ClientId FROM ProvidedServices WHERE Id = {requestId})";

            using (SqlConnection connection = db.GetConnection())
            {
                db.OpenConnection(connection);

                SqlCommand updateAddressCommand = new SqlCommand(updateAddressQuery, connection);
                updateAddressCommand.Parameters.AddWithValue("@Address", address);

                int rowsAffected = updateAddressCommand.ExecuteNonQuery();

                db.CloseConnection(connection);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Адресу клієнта успішно оновлено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не вдалося оновити адресу клієнта.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
