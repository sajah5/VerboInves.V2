namespace WinApp
{
    partial class SubForm2AcquisitionAr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtImagePath;
        private Label lblStatus;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm2AcquisitionAr));
            txtImagePath = new TextBox();
            lblStatus = new Label();
            button2 = new Button();
            button3 = new Button();
            Bulking = new Button();
            btnNext = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnImageDisk = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(168, 14);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.ReadOnly = true;
            txtImagePath.Size = new Size(404, 27);
            txtImagePath.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 13);
            lblStatus.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(543, 223);
            button2.Name = "button2";
            button2.Size = new Size(25, 25);
            button2.TabIndex = 2;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(543, 192);
            button3.Name = "button3";
            button3.Size = new Size(25, 25);
            button3.TabIndex = 3;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Bulking
            // 
            Bulking.BackColor = Color.White;
            Bulking.Location = new Point(543, 258);
            Bulking.Name = "Bulking";
            Bulking.Size = new Size(25, 25);
            Bulking.TabIndex = 7;
            Bulking.Text = " ";
            Bulking.UseVisualStyleBackColor = false;
            Bulking.Click += Bulking_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.FromArgb(4, 0, 14);
            btnNext.Location = new Point(672, 342);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(81, 43);
            btnNext.TabIndex = 11;
            btnNext.Text = "التالي";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 238, 255);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnImageDisk);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Bulking);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 450);
            panel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(108, 339);
            button1.Name = "button1";
            button1.Size = new Size(81, 43);
            button1.TabIndex = 19;
            button1.Text = "رجوع";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(407, 289);
            label5.Name = "label5";
            label5.Size = new Size(130, 35);
            label5.TabIndex = 18;
            label5.Text = "فحص شامل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(359, 254);
            label4.Name = "label4";
            label4.Size = new Size(178, 35);
            label4.TabIndex = 17;
            label4.Text = "صورة قرص صلب";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(472, 219);
            label3.Name = "label3";
            label3.Size = new Size(65, 35);
            label3.TabIndex = 16;
            label3.Text = "مجلد";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 184);
            label2.Name = "label2";
            label2.Size = new Size(113, 35);
            label2.TabIndex = 15;
            label2.Text = "ملف فردي";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(279, 136);
            label1.Name = "label1";
            label1.Size = new Size(341, 45);
            label1.TabIndex = 14;
            label1.Text = ":اختر طريقة لجمع الملفات";
            // 
            // btnImageDisk
            // 
            btnImageDisk.BackColor = Color.White;
            btnImageDisk.Location = new Point(542, 293);
            btnImageDisk.Name = "btnImageDisk";
            btnImageDisk.Size = new Size(26, 26);
            btnImageDisk.TabIndex = 0;
            btnImageDisk.Text = " ";
            btnImageDisk.UseVisualStyleBackColor = false;
            btnImageDisk.Click += btnImageDisk_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(795, 450);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // SubForm2AcquisitionAr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(795, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubForm2AcquisitionAr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button Bulking;
        private Button btnNext;
        private Panel panel1;
        private Button btnImageDisk;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}