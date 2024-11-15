namespace WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            comboBoxAr_En = new ComboBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 238, 255);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(comboBoxAr_En);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 450);
            panel1.TabIndex = 0;
            // 
            // comboBoxAr_En
            // 
            comboBoxAr_En.FormattingEnabled = true;
            comboBoxAr_En.Items.AddRange(new object[] { "English", "عربي" });
            comboBoxAr_En.Location = new Point(145, 331);
            comboBoxAr_En.Name = "comboBoxAr_En";
            comboBoxAr_En.Size = new Size(151, 28);
            comboBoxAr_En.TabIndex = 1;
            comboBoxAr_En.Text = "Language";
            comboBoxAr_En.SelectedIndexChanged += comboBoxAr_En_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(747, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 42);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(220, 238, 255);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Cooper Black", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(4, 0, 14);
            label3.Location = new Point(713, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 42);
            label3.TabIndex = 4;
            label3.Text = "_";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(4, 0, 14);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Forte", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(220, 238, 255);
            button1.Location = new Point(120, 248);
            button1.Name = "button1";
            button1.Size = new Size(202, 77);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(4, 0, 14);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(795, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerboInves";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBoxAr_En;
    }
}