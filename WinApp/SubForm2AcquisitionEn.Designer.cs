namespace WinApp
{
    partial class SubForm2AcquisitionEn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm2AcquisitionEn));
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
            button2.Location = new Point(186, 236);
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
            button3.Location = new Point(186, 200);
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
            Bulking.Location = new Point(186, 269);
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
            btnNext.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.FromArgb(4, 0, 14);
            btnNext.Location = new Point(589, 355);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(99, 37);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
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
            button1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(43, 355);
            button1.Name = "button1";
            button1.Size = new Size(99, 37);
            button1.TabIndex = 13;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(217, 300);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 17;
            label5.Text = "Bulking";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(217, 269);
            label4.Name = "label4";
            label4.Size = new Size(134, 27);
            label4.TabIndex = 16;
            label4.Text = "Disk image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 232);
            label3.Name = "label3";
            label3.Size = new Size(117, 27);
            label3.TabIndex = 15;
            label3.Text = "Directory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 200);
            label2.Name = "label2";
            label2.Size = new Size(134, 27);
            label2.TabIndex = 14;
            label2.Text = "Logical file";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 154);
            label1.Name = "label1";
            label1.Size = new Size(286, 39);
            label1.TabIndex = 13;
            label1.Text = "Choose options:";
            // 
            // btnImageDisk
            // 
            btnImageDisk.BackColor = Color.White;
            btnImageDisk.Location = new Point(185, 300);
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
            // SubForm2AcquisitionEn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(795, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubForm2AcquisitionEn";
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
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}