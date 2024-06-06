namespace WinFormsApp1._Admin_
{
    partial class ChooseRequestIdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseRequestIdForm));
            icon_logo = new PictureBox();
            label_chooseID = new Label();
            panel1 = new Panel();
            label_Id = new Label();
            textBox_Id = new TextBox();
            btn_proceed = new Button();
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
            // label_chooseID
            // 
            label_chooseID.AutoSize = true;
            label_chooseID.Font = new Font("Bahnschrift SemiCondensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_chooseID.Location = new Point(163, 25);
            label_chooseID.Name = "label_chooseID";
            label_chooseID.RightToLeft = RightToLeft.No;
            label_chooseID.Size = new Size(202, 33);
            label_chooseID.TabIndex = 0;
            label_chooseID.Text = "Оберіть ID запиту\r\n";
            label_chooseID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_chooseID);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 75);
            panel1.TabIndex = 6;
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_Id.Location = new Point(66, 110);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(32, 29);
            label_Id.TabIndex = 12;
            label_Id.Text = "ID";
            // 
            // textBox_Id
            // 
            textBox_Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Id.Location = new Point(165, 110);
            textBox_Id.Name = "textBox_Id";
            textBox_Id.Size = new Size(127, 29);
            textBox_Id.TabIndex = 11;
            textBox_Id.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_proceed
            // 
            btn_proceed.FlatStyle = FlatStyle.Popup;
            btn_proceed.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_proceed.Location = new Point(138, 177);
            btn_proceed.Name = "btn_proceed";
            btn_proceed.Size = new Size(89, 49);
            btn_proceed.TabIndex = 21;
            btn_proceed.Text = "Далі";
            btn_proceed.UseVisualStyleBackColor = true;
            btn_proceed.Click += btn_proceed_Click;
            // 
            // ChooseRequestIdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(360, 238);
            Controls.Add(btn_proceed);
            Controls.Add(label_Id);
            Controls.Add(textBox_Id);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChooseRequestIdForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Обрати ID запиту";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_logo;
        private Label label_chooseID;
        private Panel panel1;
        private Label label_Id;
        private TextBox textBox_Id;
        private Button btn_proceed;
    }
}