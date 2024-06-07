namespace WinFormsApp1
{
    partial class RoleSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleSelectionForm));
            label_roleSelection = new Label();
            icon_logo = new PictureBox();
            panel1 = new Panel();
            icon_client = new PictureBox();
            icon_admin = new PictureBox();
            btn_clientAuth = new Button();
            btn_adminAuth = new Button();
            ((System.ComponentModel.ISupportInitialize)icon_logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_client).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_admin).BeginInit();
            SuspendLayout();
            // 
            // label_roleSelection
            // 
            label_roleSelection.AutoSize = true;
            label_roleSelection.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_roleSelection.Location = new Point(152, 23);
            label_roleSelection.Name = "label_roleSelection";
            label_roleSelection.Size = new Size(233, 35);
            label_roleSelection.TabIndex = 0;
            label_roleSelection.Text = "Оберіть свою роль:";
            label_roleSelection.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Controls.Add(label_roleSelection);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 75);
            panel1.TabIndex = 2;
            // 
            // icon_client
            // 
            icon_client.Image = (Image)resources.GetObject("icon_client.Image");
            icon_client.Location = new Point(63, 131);
            icon_client.Name = "icon_client";
            icon_client.Size = new Size(70, 68);
            icon_client.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_client.TabIndex = 3;
            icon_client.TabStop = false;
            // 
            // icon_admin
            // 
            icon_admin.Image = (Image)resources.GetObject("icon_admin.Image");
            icon_admin.Location = new Point(63, 239);
            icon_admin.Name = "icon_admin";
            icon_admin.Size = new Size(70, 68);
            icon_admin.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_admin.TabIndex = 4;
            icon_admin.TabStop = false;
            // 
            // btn_clientAuth
            // 
            btn_clientAuth.FlatStyle = FlatStyle.Popup;
            btn_clientAuth.Font = new Font("Bahnschrift SemiCondensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clientAuth.Location = new Point(162, 131);
            btn_clientAuth.Name = "btn_clientAuth";
            btn_clientAuth.Size = new Size(166, 66);
            btn_clientAuth.TabIndex = 7;
            btn_clientAuth.Text = "Клієнт";
            btn_clientAuth.UseVisualStyleBackColor = true;
            btn_clientAuth.Click += btn_clientAuth_Click;
            // 
            // btn_adminAuth
            // 
            btn_adminAuth.FlatStyle = FlatStyle.Popup;
            btn_adminAuth.Font = new Font("Bahnschrift SemiCondensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn_adminAuth.Location = new Point(162, 241);
            btn_adminAuth.Name = "btn_adminAuth";
            btn_adminAuth.Size = new Size(166, 66);
            btn_adminAuth.TabIndex = 8;
            btn_adminAuth.Text = "Адмін";
            btn_adminAuth.UseVisualStyleBackColor = true;
            btn_adminAuth.Click += btn_adminAuth_Click;
            // 
            // RoleSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(384, 381);
            Controls.Add(btn_adminAuth);
            Controls.Add(btn_clientAuth);
            Controls.Add(icon_admin);
            Controls.Add(icon_client);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RoleSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оберіть свою роль";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_client).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_admin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_roleSelection;
        private PictureBox icon_logo;
        private Panel panel1;
        private PictureBox icon_client;
        private PictureBox icon_admin;
        private Button btn_clientAuth;
        private Button btn_adminAuth;
    }
}