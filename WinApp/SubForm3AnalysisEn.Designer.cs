namespace WinApp
{
    partial class SubForm3AnalysisEn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm3AnalysisEn));
            checkBoxMetadata = new CheckBox();
            checkBoxKeyword = new CheckBox();
            checkBoxArtifact = new CheckBox();
            checkBoxVBA = new CheckBox();
            checkBoxHash = new CheckBox();
            buttonNext = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            checkBoxMalwareScan = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBoxMetadata
            // 
            checkBoxMetadata.AutoSize = true;
            checkBoxMetadata.BackColor = Color.FromArgb(220, 238, 255);
            checkBoxMetadata.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMetadata.Location = new Point(210, 204);
            checkBoxMetadata.Name = "checkBoxMetadata";
            checkBoxMetadata.Size = new Size(200, 27);
            checkBoxMetadata.TabIndex = 0;
            checkBoxMetadata.Text = "Extract metadata";
            checkBoxMetadata.UseVisualStyleBackColor = false;
            checkBoxMetadata.CheckedChanged += checkBoxMetadata_CheckedChanged;
            // 
            // checkBoxKeyword
            // 
            checkBoxKeyword.AutoSize = true;
            checkBoxKeyword.BackColor = Color.FromArgb(220, 238, 255);
            checkBoxKeyword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxKeyword.Location = new Point(210, 303);
            checkBoxKeyword.Name = "checkBoxKeyword";
            checkBoxKeyword.Size = new Size(193, 27);
            checkBoxKeyword.TabIndex = 1;
            checkBoxKeyword.Text = "Keyword search";
            checkBoxKeyword.UseVisualStyleBackColor = false;
            checkBoxKeyword.CheckedChanged += checkBoxKeyword_CheckedChanged;
            // 
            // checkBoxArtifact
            // 
            checkBoxArtifact.AutoSize = true;
            checkBoxArtifact.BackColor = Color.FromArgb(220, 238, 255);
            checkBoxArtifact.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxArtifact.Location = new Point(208, 336);
            checkBoxArtifact.Name = "checkBoxArtifact";
            checkBoxArtifact.Size = new Size(178, 27);
            checkBoxArtifact.TabIndex = 2;
            checkBoxArtifact.Text = "Extract artifact";
            checkBoxArtifact.UseVisualStyleBackColor = false;
            checkBoxArtifact.CheckedChanged += checkBoxArtifact_CheckedChanged;
            // 
            // checkBoxVBA
            // 
            checkBoxVBA.AutoSize = true;
            checkBoxVBA.BackColor = Color.FromArgb(220, 238, 255);
            checkBoxVBA.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxVBA.ImageAlign = ContentAlignment.MiddleLeft;
            checkBoxVBA.Location = new Point(210, 270);
            checkBoxVBA.Name = "checkBoxVBA";
            checkBoxVBA.Size = new Size(226, 27);
            checkBoxVBA.TabIndex = 4;
            checkBoxVBA.Text = "VBA code presence";
            checkBoxVBA.TextImageRelation = TextImageRelation.TextBeforeImage;
            checkBoxVBA.UseVisualStyleBackColor = false;
            checkBoxVBA.CheckedChanged += checkBoxVBA_CheckedChanged;
            // 
            // checkBoxHash
            // 
            checkBoxHash.AutoSize = true;
            checkBoxHash.BackColor = Color.FromArgb(220, 238, 255);
            checkBoxHash.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHash.Location = new Point(210, 237);
            checkBoxHash.Name = "checkBoxHash";
            checkBoxHash.Size = new Size(176, 27);
            checkBoxHash.TabIndex = 5;
            checkBoxHash.Text = "Calculate hash";
            checkBoxHash.UseVisualStyleBackColor = false;
            checkBoxHash.CheckedChanged += checkBoxHash_CheckedChanged;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.White;
            buttonNext.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNext.ForeColor = Color.FromArgb(4, 0, 14);
            buttonNext.Location = new Point(589, 355);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(99, 37);
            buttonNext.TabIndex = 6;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 254, 254);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBoxMalwareScan);
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(checkBoxVBA);
            panel1.Controls.Add(checkBoxArtifact);
            panel1.Controls.Add(checkBoxHash);
            panel1.Controls.Add(checkBoxKeyword);
            panel1.Controls.Add(checkBoxMetadata);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 450);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 238, 255);
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 156);
            label1.Name = "label1";
            label1.Size = new Size(359, 34);
            label1.TabIndex = 11;
            label1.Text = "Select analysis options:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(4, 0, 14);
            button1.Location = new Point(43, 355);
            button1.Name = "button1";
            button1.Size = new Size(99, 37);
            button1.TabIndex = 10;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxMalwareScan
            // 
            checkBoxMalwareScan.AutoSize = true;
            checkBoxMalwareScan.BackColor = Color.FromArgb(220, 238, 255);
            checkBoxMalwareScan.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMalwareScan.Location = new Point(208, 369);
            checkBoxMalwareScan.Name = "checkBoxMalwareScan";
            checkBoxMalwareScan.Size = new Size(167, 27);
            checkBoxMalwareScan.TabIndex = 8;
            checkBoxMalwareScan.Text = "Malware scan";
            checkBoxMalwareScan.UseVisualStyleBackColor = false;
            checkBoxMalwareScan.CheckedChanged += checkBoxMalwareScan_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(795, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SubForm3AnalysisEn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(795, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SubForm3AnalysisEn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubForm3";
            Load += SubForm3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBoxMetadata;
        private CheckBox checkBoxKeyword;
        private CheckBox checkBoxArtifact;
        private CheckBox checkBoxVBA;
        private CheckBox checkBoxHash;
        private Button buttonNext;
        private Panel panel1;
        private CheckBox checkBoxMalwareScan;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
    }
}