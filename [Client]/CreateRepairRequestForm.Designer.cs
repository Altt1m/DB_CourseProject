namespace WinFormsApp1._Client_
{
    partial class CreateRepairRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRepairRequestForm));
            icon_logo = new PictureBox();
            label_repairRequest = new Label();
            panel1 = new Panel();
            btn_createRepairRequest = new Button();
            label_DateOfStart = new Label();
            dateTimePicker_Begin = new DateTimePicker();
            label1 = new Label();
            textBox_Description = new TextBox();
            ((System.ComponentModel.ISupportInitialize)icon_logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label_repairRequest
            // 
            label_repairRequest.AutoSize = true;
            label_repairRequest.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_repairRequest.Location = new Point(221, 11);
            label_repairRequest.Name = "label_repairRequest";
            label_repairRequest.RightToLeft = RightToLeft.No;
            label_repairRequest.Size = new Size(184, 58);
            label_repairRequest.TabIndex = 0;
            label_repairRequest.Text = "Створення запиту\r\nна ремонт";
            label_repairRequest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_repairRequest);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 75);
            panel1.TabIndex = 6;
            // 
            // btn_createRepairRequest
            // 
            btn_createRepairRequest.FlatStyle = FlatStyle.Popup;
            btn_createRepairRequest.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createRepairRequest.Location = new Point(241, 356);
            btn_createRepairRequest.Name = "btn_createRepairRequest";
            btn_createRepairRequest.Size = new Size(126, 49);
            btn_createRepairRequest.TabIndex = 21;
            btn_createRepairRequest.Text = "Створити";
            btn_createRepairRequest.UseVisualStyleBackColor = true;
            btn_createRepairRequest.Click += btn_createRepairRequest_Click;
            // 
            // label_DateOfStart
            // 
            label_DateOfStart.AutoSize = true;
            label_DateOfStart.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_DateOfStart.Location = new Point(26, 278);
            label_DateOfStart.Name = "label_DateOfStart";
            label_DateOfStart.Size = new Size(129, 29);
            label_DateOfStart.TabIndex = 22;
            label_DateOfStart.Text = "Час початку";
            // 
            // dateTimePicker_Begin
            // 
            dateTimePicker_Begin.Location = new Point(207, 284);
            dateTimePicker_Begin.Name = "dateTimePicker_Begin";
            dateTimePicker_Begin.Size = new Size(151, 23);
            dateTimePicker_Begin.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 100);
            label1.Name = "label1";
            label1.Size = new Size(182, 58);
            label1.TabIndex = 24;
            label1.Text = "Опис проблеми\r\n(до 300 символів)";
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(207, 100);
            textBox_Description.Multiline = true;
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(348, 135);
            textBox_Description.TabIndex = 25;
            // 
            // CreateRepairRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(600, 417);
            Controls.Add(textBox_Description);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_Begin);
            Controls.Add(label_DateOfStart);
            Controls.Add(btn_createRepairRequest);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateRepairRequestForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Створити запит на ремонт";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_logo;
        private Label label_repairRequest;
        private Panel panel1;
        private Button btn_createRepairRequest;
        private Label label_DateOfStart;
        private DateTimePicker dateTimePicker_Begin;
        private Label label1;
        private TextBox textBox_Description;
    }
}