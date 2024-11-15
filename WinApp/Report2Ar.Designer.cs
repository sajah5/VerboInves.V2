namespace WinApp
{
    partial class Report2Ar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report2Ar));
            listBoxResults = new ListBox();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.White;
            listBoxResults.BorderStyle = BorderStyle.None;
            listBoxResults.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxResults.ForeColor = Color.Black;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 24;
            listBoxResults.Location = new Point(277, 70);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.RightToLeft = RightToLeft.Yes;
            listBoxResults.Size = new Size(490, 312);
            listBoxResults.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(4, 0, 14);
            button1.Location = new Point(250, 388);
            button1.Name = "button1";
            button1.Size = new Size(129, 44);
            button1.TabIndex = 6;
            button1.Text = "تحميل النتائج";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBoxResults);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 450);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 238, 255);
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(628, 19);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 9;
            label1.Text = ":عرض النتائج";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(4, 0, 14);
            button2.Location = new Point(108, 339);
            button2.Name = "button2";
            button2.Size = new Size(81, 43);
            button2.TabIndex = 8;
            button2.Text = "رجوع";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(795, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Report2Ar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(panel1);
            Name = "Report2Ar";
            Size = new Size(795, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
    }
}