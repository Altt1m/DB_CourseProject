namespace WinFormsApp1._Client_
{
    partial class EditAccountDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccountDetailsForm));
            icon_logo = new PictureBox();
            label_editDetails = new Label();
            panel1 = new Panel();
            textBox_phoneNumber = new TextBox();
            textBox_email = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btn_save = new Button();
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
            // label_editDetails
            // 
            label_editDetails.AutoSize = true;
            label_editDetails.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_editDetails.Location = new Point(168, 11);
            label_editDetails.Name = "label_editDetails";
            label_editDetails.RightToLeft = RightToLeft.No;
            label_editDetails.Size = new Size(171, 58);
            label_editDetails.TabIndex = 0;
            label_editDetails.Text = "Редагування\r\nоблікових даних";
            label_editDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_editDetails);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 75);
            panel1.TabIndex = 7;
            // 
            // textBox_phoneNumber
            // 
            textBox_phoneNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_phoneNumber.Location = new Point(239, 169);
            textBox_phoneNumber.Name = "textBox_phoneNumber";
            textBox_phoneNumber.Size = new Size(215, 27);
            textBox_phoneNumber.TabIndex = 22;
            textBox_phoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_email.Location = new Point(239, 111);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(215, 27);
            textBox_email.TabIndex = 21;
            textBox_email.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 164);
            label7.Name = "label7";
            label7.Size = new Size(168, 29);
            label7.TabIndex = 20;
            label7.Text = "Номер телефону";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(89, 109);
            label6.Name = "label6";
            label6.Size = new Size(65, 29);
            label6.TabIndex = 19;
            label6.Text = "Email";
            // 
            // btn_save
            // 
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.Location = new Point(186, 240);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(129, 49);
            btn_save.TabIndex = 23;
            btn_save.Text = "Зберегти";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // EditAccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(501, 301);
            Controls.Add(btn_save);
            Controls.Add(textBox_phoneNumber);
            Controls.Add(textBox_email);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditAccountDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редагувати облікові дані";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_logo;
        private Label label_editDetails;
        private Panel panel1;
        private TextBox textBox_phoneNumber;
        private TextBox textBox_email;
        private Label label7;
        private Label label6;
        private Button btn_save;
    }
}