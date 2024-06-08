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
            label_supplier = new Label();
            comboBox_supplier = new ComboBox();
            label1 = new Label();
            comboBox_material = new ComboBox();
            label2 = new Label();
            textBox_count = new TextBox();
            btn_purchase = new Button();
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
            label_purchase.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label_purchase.Location = new Point(196, 21);
            label_purchase.Name = "label_purchase";
            label_purchase.RightToLeft = RightToLeft.No;
            label_purchase.Size = new Size(284, 39);
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
            panel1.Size = new Size(495, 75);
            panel1.TabIndex = 7;
            // 
            // label_supplier
            // 
            label_supplier.AutoSize = true;
            label_supplier.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_supplier.Location = new Point(62, 113);
            label_supplier.Name = "label_supplier";
            label_supplier.Size = new Size(148, 29);
            label_supplier.TabIndex = 23;
            label_supplier.Text = "Постачальник";
            // 
            // comboBox_supplier
            // 
            comboBox_supplier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_supplier.FormattingEnabled = true;
            comboBox_supplier.Location = new Point(244, 113);
            comboBox_supplier.Name = "comboBox_supplier";
            comboBox_supplier.Size = new Size(157, 29);
            comboBox_supplier.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 186);
            label1.Name = "label1";
            label1.Size = new Size(97, 29);
            label1.TabIndex = 25;
            label1.Text = "Матеріал";
            // 
            // comboBox_material
            // 
            comboBox_material.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_material.FormattingEnabled = true;
            comboBox_material.Location = new Point(244, 186);
            comboBox_material.Name = "comboBox_material";
            comboBox_material.Size = new Size(157, 29);
            comboBox_material.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 259);
            label2.Name = "label2";
            label2.Size = new Size(100, 29);
            label2.TabIndex = 27;
            label2.Text = "Кількість";
            // 
            // textBox_count
            // 
            textBox_count.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_count.Location = new Point(244, 259);
            textBox_count.Name = "textBox_count";
            textBox_count.Size = new Size(157, 29);
            textBox_count.TabIndex = 28;
            textBox_count.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_purchase
            // 
            btn_purchase.FlatStyle = FlatStyle.Popup;
            btn_purchase.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_purchase.Location = new Point(181, 330);
            btn_purchase.Name = "btn_purchase";
            btn_purchase.Size = new Size(118, 49);
            btn_purchase.TabIndex = 29;
            btn_purchase.Text = "Закупити";
            btn_purchase.UseVisualStyleBackColor = true;
            btn_purchase.Click += btn_purchase_Click;
            // 
            // PurchaseMaterialsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(480, 390);
            Controls.Add(btn_purchase);
            Controls.Add(textBox_count);
            Controls.Add(label2);
            Controls.Add(comboBox_material);
            Controls.Add(label1);
            Controls.Add(comboBox_supplier);
            Controls.Add(label_supplier);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PurchaseMaterialsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PurchaseMaterialsForm";
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox icon_logo;
        private Label label_purchase;
        private Panel panel1;
        private Label label_supplier;
        private ComboBox comboBox_supplier;
        private Label label1;
        private ComboBox comboBox_material;
        private Label label2;
        private TextBox textBox_count;
        private Button btn_purchase;
    }
}