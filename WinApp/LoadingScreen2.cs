using System;
using System.Windows.Forms;

namespace WinApp
{
    public partial class LoadingScreen2 : Form
    {
        private int direction = 1; // 1 للتحرك لأعلى، -1 للتحرك لأسفل
        private int speed = 2; // سرعة الحركة (قيمة أقل لجعل الحركة أبطأ)
        private int originalTop; // الموقع الأصلي للصورة

        public LoadingScreen2()
        {
            InitializeComponent();
            // تعيين الصورة المتحركة إلى PictureBox
            pictureBox2.ImageLocation = @"C:\Users\saja\Desktop\project\GUI\Chatbot assistant answering questions online.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // اختياري: تحجيم الصورة
            this.ControlBox = false;

            originalTop = pictureBox2.Top; // حفظ الموقع الأصلي للصورة
            timer1.Interval = 70; // ضبط المؤقت إلى 100 مللي ثانية لجعل الحركة أبطأ
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
    }
}
