using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinApp
{
    public partial class SplashForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private bool increasing = true;
        private float scale = 1.0f;
        private float step = 0.02f; // تعديل حجم التغيير في كل مرة

        public SplashForm()
        {
            InitializeComponent();
            InitializeFormAppearance();
            InitializeTimer();
        }

        private void InitializeFormAppearance()
        {
            // تحديد اللون الأسود كمفتاح شفافية
            this.TransparencyKey = Color.Black;
            // تعيين لون الفورم خلفية ليكون اللون الأسود
            this.BackColor = Color.Black;

            // إعداد PictureBox لعرض الصورة
            pictureBox1.Image = Image.FromFile(@"C:\Users\saja\Desktop\project\GUI\_a45c3743-b289-4704-a434-0c7333c24299-removebg-preview (1).png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // استخدم Zoom للحفاظ على نسب الصورة
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50; // مدة الزمن بين كل نبضة
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (increasing)
            {
                scale += step;
                if (scale >= 1.2f) increasing = false;
            }
            else
            {
                scale -= step;
                if (scale <= 0.8f) increasing = true;
            }

            int newWidth = (int)(pictureBox1.Image.Width * scale);
            int newHeight = (int)(pictureBox1.Image.Height * scale);
            pictureBox1.Size = new Size(newWidth, newHeight);
            pictureBox1.Location = new Point((this.ClientSize.Width - newWidth) / 2, (this.ClientSize.Height - newHeight) / 2);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // عرض الفورم الأساسي بعد 5 ثواني
            System.Windows.Forms.Timer splashTimer = new System.Windows.Forms.Timer();
            splashTimer.Interval = 5000;
            splashTimer.Tick += (s, args) =>
            {
                splashTimer.Stop();
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            };
            splashTimer.Start();
        }
    }
}
