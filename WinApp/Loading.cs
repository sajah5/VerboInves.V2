using System;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Loading : Form
    {
        private int direction = 1; // 1 للتحرك لأعلى، -1 للتحرك لأسفل
        private int speed = 2; // سرعة الحركة
        private int originalTop; // الموقع الأصلي للصورة

        public Loading()
        {
            InitializeComponent();
            // تعيين الصورة المتحركة إلى PictureBox
            pictureBox2.ImageLocation = @"C:\Users\saja\Desktop\project\GUI\Secure online payment and online transaction.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // اختياري: تحجيم الصورة
            this.ControlBox = false;

            originalTop = pictureBox2.Top; // حفظ الموقع الأصلي للصورة
            timer1.Interval = 50; // ضبط المؤقت (يمكنك ضبطه حسب الحاجة)
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // تحديث موقع الصورة
            pictureBox2.Top += direction * speed;

            // التحقق من الحدود لتغيير الاتجاه
            if (pictureBox2.Top <= originalTop - 20 || pictureBox2.Top >= originalTop + 20)
            {
                direction *= -1;
            }
        }

        public void SetLoadingText(string text)
        {
            // تحديث نص التحميل (إذا لزم الأمر)
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            // معالجة تحميل النموذج (إذا لزم الأمر)
        }

        private void pictureBoxLoading_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}