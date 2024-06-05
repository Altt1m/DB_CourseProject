using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class RoleSelectionForm : Form
    {
        public RoleSelectionForm()
        {
            InitializeComponent();
        }

        private void btn_clientAuth_Click(object sender, EventArgs e)
        {
            ClientAuthForm clientAuth = new ClientAuthForm();

            this.Hide();

            clientAuth.ShowDialog();

            this.Close();
        }

        private void btn_adminAuth_Click(object sender, EventArgs e)
        {
            AdminAuthForm adminAuth = new AdminAuthForm();

            this.Hide();

            adminAuth.ShowDialog();

            this.Close();
        }
    }
}
