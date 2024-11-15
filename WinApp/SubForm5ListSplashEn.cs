using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class SubForm5ListSplashEn : Form
    {
        // متغير لتخزين مسار الملف المحدد
        private string selectedFilePath;

        public string WordListFilePath { get; private set; }

        public SubForm5ListSplashEn()
        {
            InitializeComponent();
        }

        private void btnSaveList_Click_1(object sender, EventArgs e)
        {
            // التحقق مما إذا كان هناك ملف تم تحديده بالفعل
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                // حفظ المسار المحدد في الخاصية WordListFilePath
                WordListFilePath = selectedFilePath;
                DialogResult = DialogResult.OK; // إشارة بنجاح العملية للنموذج المستدعي
                Close(); // إغلاق النموذج
            }
            else
            {
                MessageBox.Show("Please select a file first.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            // إنشاء وتهيئة OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Files (*.docx;*.doc)|*.docx;*.doc|" +
                                        "PDF Files (*.pdf)|*.pdf|" +
                                        "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Select a File";

                // عرض الحوار والتحقق مما إذا تم اختيار ملف
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // الحصول على مسار الملف المحدد وتخزينه
                    selectedFilePath = openFileDialog.FileName;

                    // عرض مسار الملف (للتصحيح أو لإعلام المستخدم)
                    MessageBox.Show("Selected file path: " + selectedFilePath);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); // إغلاق النافذة الحالية فقط
        }
    }
}

