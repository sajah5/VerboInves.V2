using System.Drawing.Drawing2D;

namespace WinApp
{
    public partial class Form1 : Form
    {
        private string selectedLanguage; // متغير لتخزين اللغة المختارة

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += Form1_Paint; // إضافة معالج حدث الرسم
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // رسم دائرة بسيطة حول النموذج
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        // Override the default behavior of clicking on the form
        protected override void OnClick(EventArgs e)
        {
            // Prevent the form from being activated or brought to front
            this.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            comboBoxAr_En.Visible = false;
            pictureBox1.Visible = false; // قم بتعديل اسم pictureBox1 بما يتوافق مع اسم الصورة الخاصة بك
                                         // فتح الفورم بناءً على اللغة المختارة
            if (string.IsNullOrEmpty(selectedLanguage))
            {
                selectedLanguage = "English"; // تعيين اللغة الافتراضية إذا كانت فارغة
            }
            // فتح الفورم بناءً على اللغة المختارة
            if (selectedLanguage == "English")
            {
                SubForm2AcquisitionEn englishForm = new SubForm2AcquisitionEn();
                englishForm.TopLevel = false;
                englishForm.AutoScroll = true;
                panel1.Controls.Add(englishForm); // panel1 هو اسم العنصر Panel الذي قمت بإضافته إلى النموذج الرئيسي
                englishForm.Show();
            }
            else if (selectedLanguage == "عربي")
            {
                SubForm2AcquisitionAr arabicForm = new SubForm2AcquisitionAr();
                arabicForm.TopLevel = false;
                arabicForm.AutoScroll = true;
                panel1.Controls.Add(arabicForm); // panel1 هو اسم العنصر Panel الذي قمت بإضافته إلى النموذج الرئيسي
                arabicForm.Show();
            }
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxAr_En_SelectedIndexChanged(object sender, EventArgs e)
        {
            // تخزين اللغة المختارة في المتغير
            selectedLanguage = comboBoxAr_En.SelectedItem?.ToString();
        }
    }
}
