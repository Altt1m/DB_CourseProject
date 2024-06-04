namespace WinFormsApp1
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            label_clientForm = new Label();
            panel1 = new Panel();
            icon_logo = new PictureBox();
            dataGridView_client = new DataGridView();
            btn_createConnectionRequest = new Button();
            btn_createRepairRequest = new Button();
            btn_editAccountDetails = new Button();
            btn_payDebts = new Button();
            btn_viewSettlements = new Button();
            btn_viewAccountDetails = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_client).BeginInit();
            SuspendLayout();
            // 
            // label_clientForm
            // 
            label_clientForm.AutoSize = true;
            label_clientForm.Font = new Font("Bahnschrift SemiCondensed", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_clientForm.Location = new Point(321, 13);
            label_clientForm.Name = "label_clientForm";
            label_clientForm.Size = new Size(339, 52);
            label_clientForm.TabIndex = 0;
            label_clientForm.Text = "Особистий кабінет";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_clientForm);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 72);
            panel1.TabIndex = 4;
            // 
            // icon_logo
            // 
            icon_logo.BackColor = Color.FromArgb(128, 255, 255);
            icon_logo.Image = (Image)resources.GetObject("icon_logo.Image");
            icon_logo.Location = new Point(14, 7);
            icon_logo.Name = "icon_logo";
            icon_logo.Size = new Size(128, 58);
            icon_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_logo.TabIndex = 1;
            icon_logo.TabStop = false;
            // 
            // dataGridView_client
            // 
            dataGridView_client.AllowUserToAddRows = false;
            dataGridView_client.AllowUserToDeleteRows = false;
            dataGridView_client.AllowUserToOrderColumns = true;
            dataGridView_client.BackgroundColor = SystemColors.Control;
            dataGridView_client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_client.Location = new Point(370, 77);
            dataGridView_client.Name = "dataGridView_client";
            dataGridView_client.ReadOnly = true;
            dataGridView_client.RowTemplate.Height = 25;
            dataGridView_client.Size = new Size(539, 396);
            dataGridView_client.TabIndex = 5;
            // 
            // btn_createConnectionRequest
            // 
            btn_createConnectionRequest.Location = new Point(32, 94);
            btn_createConnectionRequest.Name = "btn_createConnectionRequest";
            btn_createConnectionRequest.Size = new Size(132, 60);
            btn_createConnectionRequest.TabIndex = 6;
            btn_createConnectionRequest.Text = "Створити запит на підключення";
            btn_createConnectionRequest.UseVisualStyleBackColor = true;
            btn_createConnectionRequest.Click += btn_createConnectionRequest_Click;
            // 
            // btn_createRepairRequest
            // 
            btn_createRepairRequest.Location = new Point(196, 94);
            btn_createRepairRequest.Name = "btn_createRepairRequest";
            btn_createRepairRequest.Size = new Size(132, 60);
            btn_createRepairRequest.TabIndex = 7;
            btn_createRepairRequest.Text = "Створити запит на ремонтну роботу";
            btn_createRepairRequest.UseVisualStyleBackColor = true;
            btn_createRepairRequest.Click += btn_createRepairRequest_Click;
            // 
            // btn_editAccountDetails
            // 
            btn_editAccountDetails.Location = new Point(32, 278);
            btn_editAccountDetails.Name = "btn_editAccountDetails";
            btn_editAccountDetails.Size = new Size(132, 60);
            btn_editAccountDetails.TabIndex = 8;
            btn_editAccountDetails.Text = "Редагувати\r\nоблікові дані";
            btn_editAccountDetails.UseVisualStyleBackColor = true;
            // 
            // btn_payDebts
            // 
            btn_payDebts.Location = new Point(196, 278);
            btn_payDebts.Name = "btn_payDebts";
            btn_payDebts.Size = new Size(132, 60);
            btn_payDebts.TabIndex = 9;
            btn_payDebts.Text = "Сплатити борг";
            btn_payDebts.UseVisualStyleBackColor = true;
            // 
            // btn_viewSettlements
            // 
            btn_viewSettlements.Location = new Point(196, 184);
            btn_viewSettlements.Name = "btn_viewSettlements";
            btn_viewSettlements.Size = new Size(132, 60);
            btn_viewSettlements.TabIndex = 10;
            btn_viewSettlements.Text = "Продивитися розрахунки";
            btn_viewSettlements.UseVisualStyleBackColor = true;
            // 
            // btn_viewAccountDetails
            // 
            btn_viewAccountDetails.Location = new Point(32, 184);
            btn_viewAccountDetails.Name = "btn_viewAccountDetails";
            btn_viewAccountDetails.Size = new Size(132, 60);
            btn_viewAccountDetails.TabIndex = 11;
            btn_viewAccountDetails.Text = "Продивитися облікові дані";
            btn_viewAccountDetails.UseVisualStyleBackColor = true;
            btn_viewAccountDetails.Click += btn_viewAccountDetails_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(921, 485);
            Controls.Add(btn_viewAccountDetails);
            Controls.Add(btn_viewSettlements);
            Controls.Add(btn_payDebts);
            Controls.Add(btn_editAccountDetails);
            Controls.Add(btn_createRepairRequest);
            Controls.Add(btn_createConnectionRequest);
            Controls.Add(dataGridView_client);
            Controls.Add(panel1);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Особистий кабінет";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_client).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_clientForm;
        private Panel panel1;
        private PictureBox icon_logo;
        private DataGridView dataGridView_client;
        private Button btn_createConnectionRequest;
        private Button btn_createRepairRequest;
        private Button btn_editAccountDetails;
        private Button btn_payDebts;
        private Button btn_viewSettlements;
        private Button btn_viewAccountDetails;
    }
}