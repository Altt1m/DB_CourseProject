namespace WinFormsApp1
{
    partial class CreateConnectionRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateConnectionRequestForm));
            icon_logo = new PictureBox();
            label_register = new Label();
            panel1 = new Panel();
            textBox_Address = new TextBox();
            label_Address = new Label();
            label_DateOfStart = new Label();
            dateTimePicker_Begin = new DateTimePicker();
            btn_createConnectionRequest = new Button();
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
            // label_register
            // 
            label_register.AutoSize = true;
            label_register.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_register.Location = new Point(155, 11);
            label_register.Name = "label_register";
            label_register.RightToLeft = RightToLeft.No;
            label_register.Size = new Size(184, 58);
            label_register.TabIndex = 0;
            label_register.Text = "Створення запиту\r\nна підключення";
            label_register.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_register);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 75);
            panel1.TabIndex = 5;
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(227, 102);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(151, 23);
            textBox_Address.TabIndex = 6;
            textBox_Address.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_Address.Location = new Point(81, 96);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(83, 29);
            label_Address.TabIndex = 10;
            label_Address.Text = "Адреса";
            // 
            // label_DateOfStart
            // 
            label_DateOfStart.AutoSize = true;
            label_DateOfStart.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_DateOfStart.Location = new Point(58, 168);
            label_DateOfStart.Name = "label_DateOfStart";
            label_DateOfStart.Size = new Size(129, 29);
            label_DateOfStart.TabIndex = 11;
            label_DateOfStart.Text = "Час початку";
            // 
            // dateTimePicker_Begin
            // 
            dateTimePicker_Begin.Location = new Point(227, 174);
            dateTimePicker_Begin.Name = "dateTimePicker_Begin";
            dateTimePicker_Begin.Size = new Size(151, 23);
            dateTimePicker_Begin.TabIndex = 12;
            // 
            // btn_createConnectionRequest
            // 
            btn_createConnectionRequest.FlatStyle = FlatStyle.Popup;
            btn_createConnectionRequest.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createConnectionRequest.Location = new Point(173, 235);
            btn_createConnectionRequest.Name = "btn_createConnectionRequest";
            btn_createConnectionRequest.Size = new Size(126, 49);
            btn_createConnectionRequest.TabIndex = 20;
            btn_createConnectionRequest.Text = "Створити";
            btn_createConnectionRequest.UseVisualStyleBackColor = true;
            btn_createConnectionRequest.Click += btn_createConnectionRequest_Click;
            // 
            // CreateConnectionRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(449, 296);
            Controls.Add(btn_createConnectionRequest);
            Controls.Add(dateTimePicker_Begin);
            Controls.Add(label_DateOfStart);
            Controls.Add(label_Address);
            Controls.Add(textBox_Address);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateConnectionRequestForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Створити запит на підключення";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_logo;
        private Label label_register;
        private Panel panel1;
        private TextBox textBox_Address;
        private Label label_Address;
        private Label label_DateOfStart;
        private DateTimePicker dateTimePicker_Begin;
        private Button btn_createConnectionRequest;
    }
}