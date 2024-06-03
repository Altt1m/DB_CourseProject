namespace WinFormsApp1
{
    partial class AdminAuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAuthForm));
            label1 = new Label();
            icon_logo = new PictureBox();
            panel1 = new Panel();
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            icon_password = new PictureBox();
            btn_login = new Button();
            btn_back = new Button();
            icon_admin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)icon_logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_admin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 13);
            label1.Name = "label1";
            label1.Size = new Size(231, 52);
            label1.TabIndex = 0;
            label1.Text = "Авторизація";
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
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 75);
            panel1.TabIndex = 3;
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_login.Location = new Point(170, 127);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(133, 29);
            textBox_login.TabIndex = 4;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.Location = new Point(170, 217);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(133, 29);
            textBox_password.TabIndex = 5;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // icon_password
            // 
            icon_password.Image = (Image)resources.GetObject("icon_password.Image");
            icon_password.Location = new Point(61, 195);
            icon_password.Name = "icon_password";
            icon_password.Size = new Size(70, 68);
            icon_password.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_password.TabIndex = 7;
            icon_password.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Bahnschrift SemiCondensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(133, 297);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(134, 42);
            btn_login.TabIndex = 8;
            btn_login.Text = "Увійти";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_back
            // 
            btn_back.BackgroundImage = (Image)resources.GetObject("btn_back.BackgroundImage");
            btn_back.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.Location = new Point(12, 323);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(42, 46);
            btn_back.TabIndex = 10;
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // icon_admin
            // 
            icon_admin.Image = (Image)resources.GetObject("icon_admin.Image");
            icon_admin.Location = new Point(61, 106);
            icon_admin.Name = "icon_admin";
            icon_admin.Size = new Size(70, 68);
            icon_admin.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_admin.TabIndex = 11;
            icon_admin.TabStop = false;
            // 
            // AdminAuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(384, 381);
            Controls.Add(btn_back);
            Controls.Add(btn_login);
            Controls.Add(icon_password);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(panel1);
            Controls.Add(icon_admin);
            Name = "AdminAuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизація адміна";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_password).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox icon_logo;
        private Panel panel1;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private PictureBox icon_password;
        private Button btn_login;
        private Button btn_back;
        private PictureBox icon_admin;
    }
}