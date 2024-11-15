namespace WinApp
{
    partial class FormDownloadAr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDownloadAr));
            buttonDownload = new Button();
            radioButtonDOCX = new RadioButton();
            radioButtonTXT = new RadioButton();
            radioButtonHTML = new RadioButton();
            checkedListBoxFiles = new CheckedListBox();
            buttonSelectAll = new Button();
            buttonClearSelection = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.BackColor = Color.White;
            buttonDownload.FlatStyle = FlatStyle.Flat;
            buttonDownload.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDownload.ForeColor = Color.FromArgb(4, 0, 14);
            buttonDownload.Location = new Point(243, 385);
            buttonDownload.Margin = new Padding(3, 4, 3, 4);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(102, 32);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "تحميل";
            buttonDownload.UseVisualStyleBackColor = false;
            buttonDownload.Click += buttonDownload_Click_1;
            // 
            // radioButtonDOCX
            // 
            radioButtonDOCX.AutoSize = true;
            radioButtonDOCX.BackColor = Color.FromArgb(220, 238, 255);
            radioButtonDOCX.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonDOCX.Location = new Point(528, 236);
            radioButtonDOCX.Margin = new Padding(3, 4, 3, 4);
            radioButtonDOCX.Name = "radioButtonDOCX";
            radioButtonDOCX.Size = new Size(79, 24);
            radioButtonDOCX.TabIndex = 3;
            radioButtonDOCX.TabStop = true;
            radioButtonDOCX.Text = "DOCX";
            radioButtonDOCX.UseVisualStyleBackColor = false;
            // 
            // radioButtonTXT
            // 
            radioButtonTXT.AutoSize = true;
            radioButtonTXT.BackColor = Color.FromArgb(220, 238, 255);
            radioButtonTXT.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTXT.Location = new Point(698, 236);
            radioButtonTXT.Margin = new Padding(3, 4, 3, 4);
            radioButtonTXT.Name = "radioButtonTXT";
            radioButtonTXT.Size = new Size(62, 24);
            radioButtonTXT.TabIndex = 4;
            radioButtonTXT.TabStop = true;
            radioButtonTXT.Text = "TXT";
            radioButtonTXT.UseVisualStyleBackColor = false;
            // 
            // radioButtonHTML
            // 
            radioButtonHTML.AutoSize = true;
            radioButtonHTML.BackColor = Color.FromArgb(220, 238, 255);
            radioButtonHTML.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonHTML.Location = new Point(613, 236);
            radioButtonHTML.Margin = new Padding(3, 4, 3, 4);
            radioButtonHTML.Name = "radioButtonHTML";
            radioButtonHTML.Size = new Size(78, 24);
            radioButtonHTML.TabIndex = 5;
            radioButtonHTML.TabStop = true;
            radioButtonHTML.Text = "HTML";
            radioButtonHTML.UseVisualStyleBackColor = false;
            // 
            // checkedListBoxFiles
            // 
            checkedListBoxFiles.BackColor = Color.White;
            checkedListBoxFiles.BorderStyle = BorderStyle.None;
            checkedListBoxFiles.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxFiles.ForeColor = Color.Black;
            checkedListBoxFiles.FormattingEnabled = true;
            checkedListBoxFiles.Location = new Point(103, 175);
            checkedListBoxFiles.Name = "checkedListBoxFiles";
            checkedListBoxFiles.RightToLeft = RightToLeft.Yes;
            checkedListBoxFiles.Size = new Size(400, 168);
            checkedListBoxFiles.TabIndex = 6;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.BackColor = Color.White;
            buttonSelectAll.FlatStyle = FlatStyle.Flat;
            buttonSelectAll.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelectAll.ForeColor = Color.FromArgb(4, 0, 14);
            buttonSelectAll.Location = new Point(671, 329);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(89, 38);
            buttonSelectAll.TabIndex = 7;
            buttonSelectAll.Text = "تحديد الكل";
            buttonSelectAll.UseVisualStyleBackColor = false;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // buttonClearSelection
            // 
            buttonClearSelection.BackColor = Color.White;
            buttonClearSelection.FlatStyle = FlatStyle.Flat;
            buttonClearSelection.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearSelection.ForeColor = Color.FromArgb(4, 0, 14);
            buttonClearSelection.Location = new Point(566, 329);
            buttonClearSelection.Name = "buttonClearSelection";
            buttonClearSelection.Size = new Size(89, 38);
            buttonClearSelection.TabIndex = 8;
            buttonClearSelection.Text = "مسح التحديد";
            buttonClearSelection.UseVisualStyleBackColor = false;
            buttonClearSelection.Click += buttonClearSelection_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(795, 450);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 238, 255);
            label1.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(501, 191);
            label1.Name = "label1";
            label1.Size = new Size(282, 31);
            label1.TabIndex = 11;
            label1.Text = ":حدد تنسيق الملف لتنزيل النتائج";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(220, 238, 255);
            label2.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(515, 284);
            label2.Name = "label2";
            label2.Size = new Size(268, 31);
            label2.TabIndex = 12;
            label2.Text = ":حدد البيانات التي تريد تحميلها";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 338);
            button1.Name = "button1";
            button1.Size = new Size(81, 43);
            button1.TabIndex = 13;
            button1.Text = "رجوع";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 450);
            panel1.TabIndex = 14;
            // 
            // FormDownloadAr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(795, 450);
            Controls.Add(checkedListBoxFiles);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClearSelection);
            Controls.Add(buttonSelectAll);
            Controls.Add(radioButtonHTML);
            Controls.Add(radioButtonTXT);
            Controls.Add(radioButtonDOCX);
            Controls.Add(buttonDownload);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDownloadAr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDownload";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDownload;
        private RadioButton radioButtonDOCX;
        private RadioButton radioButtonTXT;
        private RadioButton radioButtonHTML;
        private CheckedListBox checkedListBoxFiles;
        private Button buttonSelectAll;
        private Button buttonClearSelection;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
    }
}