namespace WinFormsApp1
{
    partial class AdminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            dataGridView_admin = new DataGridView();
            icon_logo = new PictureBox();
            label_editDetails = new Label();
            panel1 = new Panel();
            btn_сonnectionRequests = new Button();
            btn_repairRequests = new Button();
            btn_formConnectionRequest = new Button();
            btn_formRepairRequest = new Button();
            btn_purchaseMaterials = new Button();
            btn_purchases = new Button();
            btn_other = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_admin
            // 
            dataGridView_admin.AllowUserToAddRows = false;
            dataGridView_admin.AllowUserToDeleteRows = false;
            dataGridView_admin.AllowUserToOrderColumns = true;
            dataGridView_admin.BackgroundColor = SystemColors.Control;
            dataGridView_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_admin.Location = new Point(345, 73);
            dataGridView_admin.Name = "dataGridView_admin";
            dataGridView_admin.ReadOnly = true;
            dataGridView_admin.RowTemplate.Height = 25;
            dataGridView_admin.Size = new Size(669, 457);
            dataGridView_admin.TabIndex = 0;
            // 
            // icon_logo
            // 
            icon_logo.BackColor = Color.FromArgb(128, 255, 255);
            icon_logo.Image = (Image)resources.GetObject("icon_logo.Image");
            icon_logo.Location = new Point(14, 11);
            icon_logo.Name = "icon_logo";
            icon_logo.Size = new Size(128, 58);
            icon_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_logo.TabIndex = 1;
            icon_logo.TabStop = false;
            // 
            // label_editDetails
            // 
            label_editDetails.AutoSize = true;
            label_editDetails.Font = new Font("Bahnschrift SemiCondensed", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_editDetails.Location = new Point(270, 16);
            label_editDetails.Name = "label_editDetails";
            label_editDetails.RightToLeft = RightToLeft.No;
            label_editDetails.Size = new Size(502, 52);
            label_editDetails.TabIndex = 0;
            label_editDetails.Text = "Середовище адміністратора";
            label_editDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_editDetails);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 75);
            panel1.TabIndex = 8;
            // 
            // btn_сonnectionRequests
            // 
            btn_сonnectionRequests.Location = new Point(185, 135);
            btn_сonnectionRequests.Name = "btn_сonnectionRequests";
            btn_сonnectionRequests.Size = new Size(132, 60);
            btn_сonnectionRequests.TabIndex = 9;
            btn_сonnectionRequests.Text = "Запити на підключення";
            btn_сonnectionRequests.UseVisualStyleBackColor = true;
            btn_сonnectionRequests.Click += btn_сonnectionRequests_Click;
            // 
            // btn_repairRequests
            // 
            btn_repairRequests.Location = new Point(185, 220);
            btn_repairRequests.Name = "btn_repairRequests";
            btn_repairRequests.Size = new Size(132, 60);
            btn_repairRequests.TabIndex = 10;
            btn_repairRequests.Text = "Запити на ремонт";
            btn_repairRequests.UseVisualStyleBackColor = true;
            btn_repairRequests.Click += btn_repairRequests_Click;
            // 
            // btn_formConnectionRequest
            // 
            btn_formConnectionRequest.Location = new Point(29, 135);
            btn_formConnectionRequest.Name = "btn_formConnectionRequest";
            btn_formConnectionRequest.Size = new Size(132, 60);
            btn_formConnectionRequest.TabIndex = 11;
            btn_formConnectionRequest.Text = "Оформити підключення";
            btn_formConnectionRequest.UseVisualStyleBackColor = true;
            // 
            // btn_formRepairRequest
            // 
            btn_formRepairRequest.Location = new Point(29, 220);
            btn_formRepairRequest.Name = "btn_formRepairRequest";
            btn_formRepairRequest.Size = new Size(132, 60);
            btn_formRepairRequest.TabIndex = 12;
            btn_formRepairRequest.Text = "Оформити ремонт";
            btn_formRepairRequest.UseVisualStyleBackColor = true;
            // 
            // btn_purchaseMaterials
            // 
            btn_purchaseMaterials.Location = new Point(29, 306);
            btn_purchaseMaterials.Name = "btn_purchaseMaterials";
            btn_purchaseMaterials.Size = new Size(132, 60);
            btn_purchaseMaterials.TabIndex = 13;
            btn_purchaseMaterials.Text = "Закупити матеріали";
            btn_purchaseMaterials.UseVisualStyleBackColor = true;
            // 
            // btn_purchases
            // 
            btn_purchases.Location = new Point(185, 306);
            btn_purchases.Name = "btn_purchases";
            btn_purchases.Size = new Size(132, 60);
            btn_purchases.TabIndex = 14;
            btn_purchases.Text = "Закупівлі";
            btn_purchases.UseVisualStyleBackColor = true;
            // 
            // btn_other
            // 
            btn_other.Location = new Point(107, 398);
            btn_other.Name = "btn_other";
            btn_other.Size = new Size(132, 60);
            btn_other.TabIndex = 15;
            btn_other.Text = "Інше";
            btn_other.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1026, 538);
            Controls.Add(btn_other);
            Controls.Add(btn_purchases);
            Controls.Add(btn_purchaseMaterials);
            Controls.Add(btn_formRepairRequest);
            Controls.Add(btn_formConnectionRequest);
            Controls.Add(btn_repairRequests);
            Controls.Add(btn_сonnectionRequests);
            Controls.Add(panel1);
            Controls.Add(dataGridView_admin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Середовище адміністратора";
            ((System.ComponentModel.ISupportInitialize)dataGridView_admin).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_admin;
        private PictureBox icon_logo;
        private Label label_editDetails;
        private Panel panel1;
        private Button btn_сonnectionRequests;
        private Button btn_repairRequests;
        private Button btn_formConnectionRequest;
        private Button btn_formRepairRequest;
        private Button btn_purchaseMaterials;
        private Button btn_purchases;
        private Button btn_other;
    }
}