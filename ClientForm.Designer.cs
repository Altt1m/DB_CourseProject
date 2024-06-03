namespace WinFormsApp1
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            label_clientForm = new Label();
            panel1 = new Panel();
            icon_logo = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_clientForm
            // 
            label_clientForm.AutoSize = true;
            label_clientForm.Font = new Font("Bahnschrift SemiCondensed", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_clientForm.Location = new Point(321, 13);
            label_clientForm.Name = "label_clientForm";
            label_clientForm.Size = new Size(339, 52);
            label_clientForm.TabIndex = 0;
            label_clientForm.Text = "Особистий кабінет";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(icon_logo);
            panel1.Controls.Add(label_clientForm);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 72);
            panel1.TabIndex = 4;
            // 
            // icon_logo
            // 
            icon_logo.BackColor = Color.FromArgb(128, 255, 255);
            icon_logo.Image = (Image)resources.GetObject("icon_logo.Image");
            icon_logo.Location = new Point(14, 7);
            icon_logo.Name = "icon_logo";
            icon_logo.Size = new Size(128, 58);
            icon_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            icon_logo.TabIndex = 1;
            icon_logo.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(539, 396);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(32, 94);
            button1.Name = "button1";
            button1.Size = new Size(132, 60);
            button1.TabIndex = 6;
            button1.Text = "Створити запит на підключення";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(196, 94);
            button2.Name = "button2";
            button2.Size = new Size(132, 60);
            button2.TabIndex = 7;
            button2.Text = "Створити запит на ремонтну роботу";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(32, 184);
            button3.Name = "button3";
            button3.Size = new Size(132, 60);
            button3.TabIndex = 8;
            button3.Text = "Змінити облікові дані";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(196, 184);
            button4.Name = "button4";
            button4.Size = new Size(132, 60);
            button4.TabIndex = 9;
            button4.Text = "Заборгованості";
            button4.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(921, 485);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Особистий кабінет";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_clientForm;
        private Panel panel1;
        private PictureBox icon_logo;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}