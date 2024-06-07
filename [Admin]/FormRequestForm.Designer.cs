namespace WinFormsApp1._Admin_
{
    partial class FormRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequestForm));
            icon_logo = new PictureBox();
            label_formRequest = new Label();
            panel1 = new Panel();
            label_Id = new Label();
            textBox_Id = new TextBox();
            label_clientId = new Label();
            textBox_clientId = new TextBox();
            label_firstName = new Label();
            label_lastName = new Label();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            label_description = new Label();
            textBox_description = new TextBox();
            label_address = new Label();
            textBox_address = new TextBox();
            label_dateOfStart = new Label();
            label_dateOfFinish = new Label();
            label_price = new Label();
            dateTimePicker_dateOfStart = new DateTimePicker();
            dateTimePicker_dateOfFinish = new DateTimePicker();
            textBox_price = new TextBox();
            btn_formRequest = new Button();
            label1 = new Label();
            comboBox_teams = new ComboBox();
            btn_removeRequest = new Button();
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
            // label_formRequest
            // 
            label_formRequest.AutoSize = true;
            label_formRequest.Font = new Font("Bahnschrift SemiCondensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_formRequest.Location = new Point(163, 20);
            label_formRequest.Name = "label_formRequest";
            label_formRequest.RightToLeft = RightToLeft.No;
            label_formRequest.Size = new Size(295, 42);
            label_formRequest.TabIndex = 0;
            label_formRequest.Text = "Оформлення запиту";
            label_formRequest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_formRequest);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 75);
            panel1.TabIndex = 7;
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_Id.Location = new Point(23, 82);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(32, 29);
            label_Id.TabIndex = 13;
            label_Id.Text = "ID";
            // 
            // textBox_Id
            // 
            textBox_Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Id.Location = new Point(69, 82);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.ReadOnly = true;
            textBox_Id.Size = new Size(87, 29);
            textBox_Id.TabIndex = 14;
            textBox_Id.TextAlign = HorizontalAlignment.Center;
            // 
            // label_clientId
            // 
            label_clientId.AutoSize = true;
            label_clientId.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_clientId.Location = new Point(23, 123);
            label_clientId.Name = "label_clientId";
            label_clientId.Size = new Size(44, 29);
            label_clientId.TabIndex = 15;
            label_clientId.Text = "CID";
            // 
            // textBox_clientId
            // 
            textBox_clientId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_clientId.Location = new Point(69, 123);
            textBox_clientId.Name = "textBox_clientId";
            textBox_clientId.ReadOnly = true;
            textBox_clientId.Size = new Size(87, 29);
            textBox_clientId.TabIndex = 16;
            textBox_clientId.TextAlign = HorizontalAlignment.Center;
            // 
            // label_firstName
            // 
            label_firstName.AutoSize = true;
            label_firstName.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_firstName.Location = new Point(173, 82);
            label_firstName.Name = "label_firstName";
            label_firstName.Size = new Size(47, 29);
            label_firstName.TabIndex = 17;
            label_firstName.Text = "Ім'я";
            // 
            // label_lastName
            // 
            label_lastName.AutoSize = true;
            label_lastName.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_lastName.Location = new Point(173, 123);
            label_lastName.Name = "label_lastName";
            label_lastName.Size = new Size(102, 29);
            label_lastName.TabIndex = 18;
            label_lastName.Text = "Прізвище";
            // 
            // textBox_firstName
            // 
            textBox_firstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_firstName.Location = new Point(276, 82);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.ReadOnly = true;
            textBox_firstName.Size = new Size(147, 29);
            textBox_firstName.TabIndex = 19;
            textBox_firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_lastName.Location = new Point(276, 123);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.ReadOnly = true;
            textBox_lastName.Size = new Size(147, 29);
            textBox_lastName.TabIndex = 20;
            textBox_lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_description.Location = new Point(23, 229);
            label_description.Name = "label_description";
            label_description.Size = new Size(61, 29);
            label_description.TabIndex = 21;
            label_description.Text = "Опис";
            // 
            // textBox_description
            // 
            textBox_description.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_description.Location = new Point(90, 229);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(333, 116);
            textBox_description.TabIndex = 22;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_address.Location = new Point(84, 176);
            label_address.Name = "label_address";
            label_address.Size = new Size(83, 29);
            label_address.TabIndex = 23;
            label_address.Text = "Адреса";
            // 
            // textBox_address
            // 
            textBox_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_address.Location = new Point(173, 176);
            textBox_address.Name = "textBox_address";
            textBox_address.ReadOnly = true;
            textBox_address.Size = new Size(215, 29);
            textBox_address.TabIndex = 24;
            textBox_address.TextAlign = HorizontalAlignment.Center;
            // 
            // label_dateOfStart
            // 
            label_dateOfStart.AutoSize = true;
            label_dateOfStart.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_dateOfStart.Location = new Point(60, 363);
            label_dateOfStart.Name = "label_dateOfStart";
            label_dateOfStart.Size = new Size(141, 29);
            label_dateOfStart.TabIndex = 25;
            label_dateOfStart.Text = "Дата початку";
            // 
            // label_dateOfFinish
            // 
            label_dateOfFinish.AutoSize = true;
            label_dateOfFinish.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_dateOfFinish.Location = new Point(72, 408);
            label_dateOfFinish.Name = "label_dateOfFinish";
            label_dateOfFinish.Size = new Size(117, 29);
            label_dateOfFinish.TabIndex = 26;
            label_dateOfFinish.Text = "Дата кінця";
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_price.Location = new Point(84, 453);
            label_price.Name = "label_price";
            label_price.Size = new Size(93, 29);
            label_price.TabIndex = 27;
            label_price.Text = "Вартість";
            // 
            // dateTimePicker_dateOfStart
            // 
            dateTimePicker_dateOfStart.Location = new Point(229, 369);
            dateTimePicker_dateOfStart.Name = "dateTimePicker_dateOfStart";
            dateTimePicker_dateOfStart.Size = new Size(159, 23);
            dateTimePicker_dateOfStart.TabIndex = 28;
            // 
            // dateTimePicker_dateOfFinish
            // 
            dateTimePicker_dateOfFinish.Location = new Point(229, 414);
            dateTimePicker_dateOfFinish.Name = "dateTimePicker_dateOfFinish";
            dateTimePicker_dateOfFinish.Size = new Size(159, 23);
            dateTimePicker_dateOfFinish.TabIndex = 29;
            // 
            // textBox_price
            // 
            textBox_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_price.Location = new Point(229, 453);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(159, 29);
            textBox_price.TabIndex = 30;
            textBox_price.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_formRequest
            // 
            btn_formRequest.BackColor = Color.Lime;
            btn_formRequest.FlatStyle = FlatStyle.Popup;
            btn_formRequest.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_formRequest.Location = new Point(242, 552);
            btn_formRequest.Name = "btn_formRequest";
            btn_formRequest.Size = new Size(119, 49);
            btn_formRequest.TabIndex = 31;
            btn_formRequest.Text = "Оформити";
            btn_formRequest.UseVisualStyleBackColor = false;
            btn_formRequest.Click += btn_formRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 497);
            label1.Name = "label1";
            label1.Size = new Size(93, 29);
            label1.TabIndex = 32;
            label1.Text = "Бригада";
            // 
            // comboBox_teams
            // 
            comboBox_teams.FormattingEnabled = true;
            comboBox_teams.Location = new Point(229, 503);
            comboBox_teams.Name = "comboBox_teams";
            comboBox_teams.Size = new Size(159, 23);
            comboBox_teams.TabIndex = 33;
            // 
            // btn_removeRequest
            // 
            btn_removeRequest.BackColor = Color.Tomato;
            btn_removeRequest.FlatStyle = FlatStyle.Popup;
            btn_removeRequest.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_removeRequest.Location = new Point(90, 552);
            btn_removeRequest.Name = "btn_removeRequest";
            btn_removeRequest.Size = new Size(121, 49);
            btn_removeRequest.TabIndex = 34;
            btn_removeRequest.Text = "Видалити";
            btn_removeRequest.UseVisualStyleBackColor = false;
            btn_removeRequest.Click += btn_removeRequest_Click;
            // 
            // FormRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(451, 613);
            Controls.Add(btn_removeRequest);
            Controls.Add(comboBox_teams);
            Controls.Add(label1);
            Controls.Add(btn_formRequest);
            Controls.Add(textBox_price);
            Controls.Add(dateTimePicker_dateOfFinish);
            Controls.Add(dateTimePicker_dateOfStart);
            Controls.Add(label_price);
            Controls.Add(label_dateOfFinish);
            Controls.Add(label_dateOfStart);
            Controls.Add(textBox_address);
            Controls.Add(label_address);
            Controls.Add(textBox_description);
            Controls.Add(label_description);
            Controls.Add(textBox_lastName);
            Controls.Add(textBox_firstName);
            Controls.Add(label_lastName);
            Controls.Add(label_firstName);
            Controls.Add(textBox_clientId);
            Controls.Add(label_clientId);
            Controls.Add(textBox_Id);
            Controls.Add(label_Id);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRequestForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформити запит";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_logo;
        private Label label_formRequest;
        private Panel panel1;
        private Label label_Id;
        private TextBox textBox_Id;
        private Label label_clientId;
        private TextBox textBox_clientId;
        private Label label_firstName;
        private Label label_lastName;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private Label label_description;
        private TextBox textBox_description;
        private Label label_address;
        private TextBox textBox_address;
        private Label label_dateOfStart;
        private Label label_dateOfFinish;
        private Label label_price;
        private DateTimePicker dateTimePicker_dateOfStart;
        private DateTimePicker dateTimePicker_dateOfFinish;
        private TextBox textBox_price;
        private Button btn_formRequest;
        private Label label1;
        private ComboBox comboBox_teams;
        private Button btn_removeRequest;
    }
}