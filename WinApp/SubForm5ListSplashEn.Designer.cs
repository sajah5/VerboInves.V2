namespace WinApp
{
    partial class SubForm5ListSplashEn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm5ListSplashEn));
            btnSaveList = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSelectFile = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSaveList
            // 
            btnSaveList.BackColor = Color.White;
            btnSaveList.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveList.ForeColor = Color.FromArgb(4, 0, 14);
            btnSaveList.Location = new Point(281, 245);
            btnSaveList.Name = "btnSaveList";
            btnSaveList.Size = new Size(99, 37);
            btnSaveList.TabIndex = 1;
            btnSaveList.Text = "Save";
            btnSaveList.UseVisualStyleBackColor = false;
            btnSaveList.Click += btnSaveList_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 321);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(220, 238, 255);
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(389, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 42);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectFile.Location = new Point(139, 115);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(172, 77);
            btnSelectFile.TabIndex = 8;
            btnSelectFile.Text = "upload the list";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // SubForm5ListSplashEn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 62, 92);
            ClientSize = new Size(428, 328);
            Controls.Add(btnSelectFile);
            Controls.Add(pictureBox2);
            Controls.Add(btnSaveList);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubForm5ListSplashEn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubForm5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSaveList;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSelectFile;
    }
}