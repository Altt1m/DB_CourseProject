namespace WinFormsApp1
{
    partial class ClientRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegisterForm));
            icon_logo = new PictureBox();
            panel1 = new Panel();
            label_register = new Label();
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_middleName = new TextBox();
            textBox_email = new TextBox();
            textBox_phoneNumber = new TextBox();
            btn_register = new Button();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_register);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 75);
            panel1.TabIndex = 4;
            // 
            // label_register
            // 
            label_register.AutoSize = true;
            label_register.Font = new Font("Bahnschrift SemiCondensed", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_register.Location = new Point(171, 14);
            label_register.Name = "label_register";
            label_register.Size = new Size(209, 52);
            label_register.TabIndex = 0;
            label_register.Text = "Реєстрація";
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_login.Location = new Point(209, 104);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(137, 27);
            textBox_login.TabIndex = 5;
            textBox_login.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.Location = new Point(209, 159);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(137, 27);
            textBox_password.TabIndex = 6;
            textBox_password.TextAlign = HorizontalAlignment.Center;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_firstName.Location = new Point(209, 214);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(137, 27);
            textBox_firstName.TabIndex = 7;
            textBox_firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_lastName.Location = new Point(209, 269);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(137, 27);
            textBox_lastName.TabIndex = 8;
            textBox_lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 102);
            label1.Name = "label1";
            label1.Size = new Size(64, 29);
            label1.TabIndex = 9;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 157);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 10;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(78, 212);
            label3.Name = "label3";
            label3.Size = new Size(47, 29);
            label3.TabIndex = 11;
            label3.Text = "Ім'я";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 267);
            label4.Name = "label4";
            label4.Size = new Size(102, 29);
            label4.TabIndex = 12;
            label4.Text = "Прізвище";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 322);
            label5.Name = "label5";
            label5.Size = new Size(123, 29);
            label5.TabIndex = 13;
            label5.Text = "По батькові";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(69, 377);
            label6.Name = "label6";
            label6.Size = new Size(65, 29);
            label6.TabIndex = 14;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 432);
            label7.Name = "label7";
            label7.Size = new Size(168, 29);
            label7.TabIndex = 15;
            label7.Text = "Номер телефону";
            // 
            // textBox_middleName
            // 
            textBox_middleName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_middleName.Location = new Point(209, 324);
            textBox_middleName.Name = "textBox_middleName";
            textBox_middleName.Size = new Size(137, 27);
            textBox_middleName.TabIndex = 16;
            textBox_middleName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_email.Location = new Point(209, 379);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(137, 27);
            textBox_email.TabIndex = 17;
            textBox_email.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_phoneNumber
            // 
            textBox_phoneNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_phoneNumber.Location = new Point(209, 434);
            textBox_phoneNumber.Name = "textBox_phoneNumber";
            textBox_phoneNumber.Size = new Size(137, 27);
            textBox_phoneNumber.TabIndex = 18;
            textBox_phoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_register
            // 
            btn_register.FlatStyle = FlatStyle.Popup;
            btn_register.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.Location = new Point(93, 496);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(195, 49);
            btn_register.TabIndex = 19;
            btn_register.Text = "Зареєструватися";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // ClientRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(384, 557);
            Controls.Add(btn_register);
            Controls.Add(textBox_phoneNumber);
            Controls.Add(textBox_email);
            Controls.Add(textBox_middleName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_firstName);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(panel1);
            Name = "ClientRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_logo;
        private Panel panel1;
        private Label label_register;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_middleName;
        private TextBox textBox_email;
        private TextBox textBox_phoneNumber;
        private Button btn_register;
    }
}