using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Xceed.Words.NET; // مكتبة لمعالجة ملفات DOCX
using iTextSharp.text; // مكتبة لمعالجة ملفات PDF
using iTextSharp.text.pdf; // مكتبة لمعالجة ملفات PDF
using WinApp.Template;
using System.Drawing;
using Paragraph = iTextSharp.text.Paragraph; // استخدام تعليمة using لتسمية معينة لـ iTextSharp.text.Paragraph
using PdfParagraph = iTextSharp.text.Paragraph; // تسمية جديدة لتجنب التعارض
using static System.Net.Mime.MediaTypeNames;
using WinApp.Template;
using System.Collections.Generic;
using System.Drawing;


namespace WinApp
{
    public partial class FormDownloadAr : Form
    {
        private List<string> checkedListData;

        public FormDownloadAr(List<string> checkedListData)
        {
            InitializeComponent();
            this.checkedListData = checkedListData;

            // عرض البيانات في checkedListBoxFiles أو أي عنصر تحكم آخر
            PopulateCheckedListBox();
        }

        private void PopulateCheckedListBox()
        {
            foreach (var item in checkedListData)
            {
                // يمكنك هنا إضافة البيانات بشكل مناسب إلى القائمة المدققة
                checkedListBoxFiles.Items.Add(item);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // إغلاق نموذج التنزيل بالضغط على زر الإلغاء
        }

        private void SaveAsDocx(string filePath, List<string> selectedFiles)
        {
            var doc = DocX.Create(filePath);
            string FontName = "Courier New"; // تعيين نوع الخط الذي تفضله
            string fontName = "Georgia"; // تعيين نوع الخط الذي تفضله

            // إضافة صورة الشعار
            string logoPath = @"C:\Users\saja\Desktop\project\GUI\_a45c3743-b289-4704-a434-0c7333c24299-removebg-preview (1).png";

            if (File.Exists(logoPath))
            {
                var logo = doc.AddImage(logoPath).CreatePicture(100, 100); // تحديد حجم الصورة أكبر (200x200) على سبيل المثال
                var logoParagraph = doc.InsertParagraph().AppendPicture(logo).Alignment = Alignment.center;
            }

            // إضافة بيانات المقدمة
            var intro = doc.InsertParagraph()
                .AppendLine("اسم التطبيق: VerboInves")
                .Font(new Xceed.Words.NET.Font(FontName))
                .FontSize(10)
                .Color(Color.Gray)
                .Italic()
                .SpacingAfter(10)
                .AppendLine("إصدار التطبيق: 3.1")
                .Font(new Xceed.Words.NET.Font(fontName))
                .FontSize(10)
                .Color(Color.Gray)
                .Italic()
                .SpacingAfter(10)
                .AppendLine("المطورين: \n" +
                "سجى الحايك,\n" +
                " سرى الروسان,\n" +
                " سجى زميلي")
                 .Font(new Xceed.Words.NET.Font(fontName))
                 .FontSize(10)
                .Color(Color.Gray)
                .Italic()
                .SpacingAfter(10)
                .AppendLine("تاريخ الإصدار: 2024/1/30")
                .Font(new Xceed.Words.NET.Font(fontName))
                .FontSize(10)
                .Color(Color.Gray)
                .Italic()
                .SpacingAfter(10)
                .Alignment = Alignment.right;

            // إضافة خط فاصل بعد المقدمة
            doc.InsertParagraph(new string('=', 50))
                .FontSize(12)
                .Color(Color.Gray)
                .SpacingAfter(10)
                .Alignment = Alignment.center;

            var processedItems = new HashSet<string>();

            // إضافة البيانات المحددة
            foreach (var item in selectedFiles)
            {
                if (!processedItems.Contains(item))
                {
                    if ((item.StartsWith("===") && item.EndsWith("===")) || item.Trim() == "--------------------------------------------------------------------------------")
                    {
                        // تنسيق العناوين
                        doc.InsertParagraph(item)
                           .Font(new Xceed.Words.NET.Font(fontName))
                            .FontSize(14)
                            .Bold()
                            .SpacingAfter(10)
                            .Alignment = Alignment.center;
                    }
                    else
                    {
                        // تنسيق النص العادي
                        doc.InsertParagraph(item)
                            .Font(new Xceed.Words.NET.Font(fontName))
                            .FontSize(10)
                            .SpacingAfter(10)
                            .Alignment = Alignment.right;
                    }

                    // إضافة العنصر إلى HashSet
                    processedItems.Add(item);
                }
            }

            // إضافة تاريخ التقرير في الأسفل
            var footer = doc.InsertParagraph($"Date: {DateTime.Now.ToString("dd/MM/yyyy")}")
                .Font(new Xceed.Words.NET.Font(FontName))
                .FontSize(10)
                .Italic()
                .Color(Color.Gray)
                .SpacingBefore(20)
                .Alignment = Alignment.right;

            // حفظ الملف
            doc.Save();
        }

        private void SaveAsTxt(string filePath, List<string> selectedFiles)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // إضافة بيانات المقدمة
                writer.WriteLine("اسم التطبيق: VerboInves");
                writer.WriteLine("إصدار التطبيق: 3.1");
                writer.WriteLine("المطورين:\n" +
                    " سجى الحايك\n," +
                    " سرى الروسان\n," +
                    " سجى زميلي");
                writer.WriteLine("تاريخ الإصدار: 2024/1/30");
                writer.WriteLine("--------------------------------------------------------------------------------");

                // إضافة فراغ بين بيانات المقدمة والبيانات المحددة
                writer.WriteLine();

                // إضافة بيانات الملفات المحددة
                foreach (var item in selectedFiles)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void SaveAsHtml(string filePath, List<string> selectedFiles)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
                writer.WriteLine("<style>");
                writer.WriteLine("body { font-family: Georgia, sans-serif; background-color: #f0f0f0; color: #333; margin: 20px; text-align: right; }"); // محاذاة النصوص لليمين
                writer.WriteLine(".intro { font-size: 14px; color: #666; margin-bottom: 10px; text-align: right; }");
                writer.WriteLine("h1 { text-align: center; font-size: 28px; color: #333; }");
                writer.WriteLine("h2 { text-align: center; font-size: 22px; color: #333; }");
                writer.WriteLine("p { font-size: 16px; line-height: 1.6; margin-bottom: 8px; }");
                writer.WriteLine("ul { list-style-type: none; padding: 0; }");
                writer.WriteLine("li { font-size: 16px; margin-bottom: 8px; text-align: right; }"); // محاذاة النصوص لليمين
                writer.WriteLine(".center-text { text-align: center; }");
                writer.WriteLine(".middle-content { max-width: 90vw; margin: auto; padding: 20px; background-color: #fff; box-shadow: 0 0 10px rgba(0,0,0,0.1); }");
                writer.WriteLine("@media screen and (max-width: 768px) { .middle-content { max-width: 95vw; } }");
                writer.WriteLine("</style>");
                writer.WriteLine("</head>");
                writer.WriteLine("<body>");

                // إضافة بيانات المقدمة
                writer.WriteLine("<div class='middle-content'>");
                writer.WriteLine("<h1>Application Report</h1>");
                writer.WriteLine("<p class='intro'>اسم التطبيق: VerboInves</p>");
                writer.WriteLine("<p class='intro'>إصدار التطبيق: 3.1</p>");
                writer.WriteLine("<p class='intro'>المطورين: سجى الحايك, سرى الروسان, سجى زميلي</p>");
                writer.WriteLine("<p class='intro'>تاريخ النشر: 2024/1/30</p>");
                writer.WriteLine("<div class='center-text'> <img src=\"C:\\Users\\saja\\Desktop\\project\\GUI\\_a45c3743-b289-4704-a434-0c7333c24299-removebg-preview (1).png\" alt='Application Logo' width='100' height='100'></div>");
                writer.WriteLine("</div>");

                writer.WriteLine("<ul>");
                foreach (var item in selectedFiles)
                {
                    if (item.StartsWith("===") && item.EndsWith("===") || item.Contains("-------------------------------------------------------------------------"))
                    {
                        writer.WriteLine($"<h2 class='center-text'>{item.TrimStart('=').TrimEnd('=')}</h2>");
                    }
                    else
                    {
                        writer.WriteLine($"<li>{item}</li>");
                    }
                }
                writer.WriteLine("</ul>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }
        }

        /**private void SaveAsPdf(string filePath, List<string> selectedFiles)
        {
            // بيانات التطبيق
            string applicationName = "VerboInves";
            string applicationVersion = "1.0.0.0";
            string developers = "Saja Al-Hayek, Saja Zmaili, Sora Al-Rusan";
            string releaseDate = "2024/7/2";
            string applicationLogoPath = @"C:\Users\saja\Desktop\project\GUI\chatgpt robot with speech bubble.png"; // مسار صورة الشعار

            // إنشاء مستند PDF
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                // فتح المستند
                doc.Open();

                // إضافة المقدمة كصفحة منفردة
                Font arabicFont = FontFactory.GetFont("Arial Unicode MS", 12f, BaseColor.GRAY);
                Paragraph introParagraph = new Paragraph();
                introParagraph.Font = arabicFont;
                introParagraph.Alignment = Element.ALIGN_CENTER;
                introParagraph.Add(new Chunk("Application Report\n\n", FontFactory.GetFont("Arial Unicode MS", 24f))); // عنوان المستند
                introParagraph.Add(new Chunk($"Application Name: {applicationName}\n"));
                introParagraph.Add(new Chunk($"Application Version: {applicationVersion}\n"));
                introParagraph.Add(new Chunk($"Developer(s): {developers}\n"));
                introParagraph.Add(new Chunk($"Release Date: {releaseDate}\n"));
                doc.Add(introParagraph);

                // إضافة صورة الشعار
                if (File.Exists(applicationLogoPath))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(applicationLogoPath);
                    logo.Alignment = Element.ALIGN_CENTER;
                    logo.ScaleAbsolute(100f, 100f); // تحجيم الصورة
                    doc.Add(logo);
                }

                // إضافة صفحة جديدة بعد المقدمة
                doc.NewPage();

                // إضافة فصول المستند بعد المقدمة
                foreach (var item in selectedFiles)
                {
                    if (item.StartsWith("===") && item.EndsWith("===") || item.Trim() == "--------------------------------------------------------------------------------")
                    {
                        Paragraph titleParagraph = new Paragraph(item.Replace("==", "").Trim(), FontFactory.GetFont("Arial Unicode MS", 20f));
                        titleParagraph.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titleParagraph);
                    }
                    else
                    {
                        Paragraph normalParagraph = new Paragraph(item, FontFactory.GetFont("Arial Unicode MS", 12f));
                        normalParagraph.Alignment = Element.ALIGN_LEFT;
                        normalParagraph.SpacingAfter = 0f;
                        doc.Add(normalParagraph);
                    }
                }

                doc.Close();
                writer.Close();
            }
        }**/


        private void buttonDownload_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearSelection_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
            {
                checkedListBoxFiles.SetItemChecked(i, false);
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
            {
                checkedListBoxFiles.SetItemChecked(i, true);
            }
        }

        private void buttonDownload_Click_1(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save Data";

                // التحقق من الصيغة المختارة من خلال RadioButtons على الواجهة
                /** if (radioButtonPDF.Checked)
                 {
                     saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                 }**/
                if (radioButtonDOCX.Checked)
                {
                    saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                }
                else if (radioButtonTXT.Checked)
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                }
                else if (radioButtonHTML.Checked)
                {
                    saveFileDialog.Filter = "HTML Files (*.html)|*.html";
                }
                else
                {
                    saveFileDialog.Filter = "All Files (*.*)|*.*"; // إذا لم يتم اختيار أي صيغة
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // الحصول على قائمة الملفات المحددة
                    List<string> selectedFiles = new List<string>();
                    foreach (var item in checkedListBoxFiles.CheckedItems)
                    {
                        selectedFiles.Add(item.ToString());
                    }

                    if (selectedFiles.Count > 0)
                    {
                        string fileExtension = Path.GetExtension(filePath).ToLower();

                        switch (fileExtension)
                        {
                            /**case ".pdf":
                                SaveAsPdf(filePath, selectedFiles);
                                break;**/
                            case ".docx":
                                SaveAsDocx(filePath, selectedFiles);
                                break;
                            case ".txt":
                                SaveAsTxt(filePath, selectedFiles);
                                break;
                            case ".html":
                                SaveAsHtml(filePath, selectedFiles);
                                break;
                            default:
                                SaveAsTxt(filePath, selectedFiles);
                                break;
                        }

                        MessageBox.Show("تم حفظ البيانات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close(); // إغلاق نموذج التنزيل بعد الانتهاء من الحفظ
                    }
                    else
                    {
                        MessageBox.Show("رجاءًا حدد الصيغة أولًا.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to save data: {ex.Message}", "ُError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("Noto Sans Arabic", 14, FontStyle.Regular);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void HideControls()
        {
            button1.Visible = false;
            label1.Visible = false;
            buttonDownload.Visible = false;
            buttonSelectAll.Visible = false;
            buttonClearSelection.Visible = false;
            radioButtonDOCX.Visible = false;
            radioButtonTXT.Visible = false;
            radioButtonHTML.Visible = false;
            checkedListBoxFiles.Visible = false;
            label2.Visible = false;
            pictureBox1.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // إزالة أي عناصر موجودة حالياً في الـ Panel
            panel1.Controls.Clear();

            // إنشاء نسخة من الـ UserControl
            Report2Ar userControl = new Report2Ar();
            HideControls();

            userControl.Dock = DockStyle.Fill;

            // إضافة الـ UserControl إلى الـ panel
            panel1.Controls.Add(userControl);
            userControl.BringToFront();

            // تحديث واجهة المستخدم
            panel1.Invalidate();
            panel1.Update();

        }
    }
}
