namespace WinFormsApp1._Admin_
{
    partial class PurchaseMaterialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseMaterialsForm));
            icon_logo = new PictureBox();
            label_purchase = new Label();
            panel1 = new Panel();
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
            // label_purchase
            // 
            label_purchase.AutoSize = true;
            label_purchase.Font = new Font("Bahnschrift SemiCondensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_purchase.Location = new Point(191, 24);
            label_purchase.Name = "label_purchase";
            label_purchase.RightToLeft = RightToLeft.No;
            label_purchase.Size = new Size(260, 35);
            label_purchase.TabIndex = 0;
            label_purchase.Text = "Закупівля матеріалів";
            label_purchase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_purchase);
            panel1.Location = new Point(-9, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 75);
            panel1.TabIndex = 7;
            // 
            // PurchaseMaterialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(603, 450);
            Controls.Add(panel1);
            Name = "PurchaseMaterialsForm";
            Text = "PurchaseMaterialsForm";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox icon_logo;
        private Label label_purchase;
        private Panel panel1;
    }
}