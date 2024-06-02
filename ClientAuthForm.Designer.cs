namespace WinFormsApp1
{
    partial class ClientAuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAuthForm));
            label1 = new Label();
            icon_logo = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            icon_client = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)icon_logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_client).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(172, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 29);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(172, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 29);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            // 
            // icon_client
            // 
            icon_client.Image = (Image)resources.GetObject("icon_client.Image");
            icon_client.Location = new Point(63, 107);
            icon_client.Name = "icon_client";
            icon_client.Size = new Size(70, 68);
            icon_client.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_client.TabIndex = 6;
            icon_client.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Bahnschrift SemiCondensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(127, 310);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 8;
            button1.Text = "Увійти";
            button1.UseVisualStyleBackColor = false;
            // 
            // ClientAuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(384, 381);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(icon_client);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "ClientAuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизація клієнта";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_client).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox icon_logo;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox icon_client;
        private PictureBox pictureBox1;
        private Button button1;
    }
}