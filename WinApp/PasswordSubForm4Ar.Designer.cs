namespace WinApp
{
    partial class PasswordSubForm4Ar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordSubForm4Ar));
            buttonMask = new Button();
            buttonRuleBased = new Button();
            buttonDictionry = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonMask
            // 
            buttonMask.BackColor = Color.Transparent;
            buttonMask.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMask.ForeColor = Color.FromArgb(4, 0, 14);
            buttonMask.Location = new Point(159, 173);
            buttonMask.Name = "buttonMask";
            buttonMask.Size = new Size(131, 40);
            buttonMask.TabIndex = 1;
            buttonMask.Text = "النمط المموه";
            buttonMask.UseVisualStyleBackColor = false;
            buttonMask.Click += buttonMask_Click_1;
            // 
            // buttonRuleBased
            // 
            buttonRuleBased.BackColor = Color.Transparent;
            buttonRuleBased.BackgroundImageLayout = ImageLayout.None;
            buttonRuleBased.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRuleBased.ForeColor = Color.FromArgb(4, 0, 14);
            buttonRuleBased.Location = new Point(309, 173);
            buttonRuleBased.Name = "buttonRuleBased";
            buttonRuleBased.Size = new Size(146, 40);
            buttonRuleBased.TabIndex = 2;
            buttonRuleBased.Text = "القواعد المحددة";
            buttonRuleBased.UseVisualStyleBackColor = false;
            buttonRuleBased.Click += buttonRuleBased_Click_1;
            // 
            // buttonDictionry
            // 
            buttonDictionry.BackColor = Color.White;
            buttonDictionry.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDictionry.ForeColor = Color.FromArgb(4, 0, 14);
            buttonDictionry.Location = new Point(475, 173);
            buttonDictionry.Name = "buttonDictionry";
            buttonDictionry.Size = new Size(131, 40);
            buttonDictionry.TabIndex = 3;
            buttonDictionry.Text = "القاموس";
            buttonDictionry.UseVisualStyleBackColor = false;
            buttonDictionry.Click += buttonDictionry_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 296);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(220, 238, 255);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(664, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 38);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 238, 255);
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(401, 103);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 7;
            label1.Text = ":اختر طريقة لفتح الملف";
            // 
            // PasswordSubForm4Ar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 62, 92);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(700, 300);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonDictionry);
            Controls.Add(buttonRuleBased);
            Controls.Add(buttonMask);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordSubForm4Ar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Unlocking";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonMask;
        private Button buttonRuleBased;
        private Button buttonDictionry;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}