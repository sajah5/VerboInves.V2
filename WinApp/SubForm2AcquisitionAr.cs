using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WinApp
{
    public partial class SubForm2AcquisitionAr : Form
    {
        private Loading loadingForm;
        private List<string> allFiles; // قائمة لجميع ملفات الوورد
        private SubForm3AnalysisAr subForm3; // متغير عضو لتخزين مثيل SubForm3

        public SubForm2AcquisitionAr()
        {
            InitializeComponent();
            allFiles = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // حدث زر button1
        }

        private void PerformExtraction(string imagePath)
        {
            // تنفيذ عملية الاستخراج
        }

        private void AddFileToAppropriateList(string filePath)
        {
            if (IsPasswordProtected(filePath))
            {
                // إضافة الملفات المحمية بكلمة مرور إلى القائمة المناسبة
            }
            else
            {
                // إضافة الملفات غير المحمية إلى القائمة المناسبة
            }
        }

        private bool IsPasswordProtected(string filePath)
        {
            try
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, false))
                {
                    foreach (var part in doc.Package.GetParts())
                    {
                        if (part.ContentType.EndsWith("xml") && part.Uri.ToString().EndsWith(".xml"))
                        {
                            using (var stream = part.GetStream())
                            using (var reader = new StreamReader(stream))
                            {
                                string content = reader.ReadToEnd();
                                if (content.Contains("<w:encryptedPackage"))
                                {
                                    return true;
                                }
                            }
                        }
                    }

                    DocumentProtection dp = doc.MainDocumentPart.DocumentSettingsPart.Settings.ChildElements.OfType<DocumentProtection>().FirstOrDefault();
                    if (dp != null && dp.Enforcement == DocumentFormat.OpenXml.OnOffValue.FromBoolean(true))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening file: {filePath}");
                Console.WriteLine($"Error details: {ex.Message}");
            }

            return false;
        }

        private void UpdateListBoxes()
        {
            // تحديث القوائم
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder containing Word files";

                // Show loading screen
                ShowLoadingScreen();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    string[] wordFiles = Directory.GetFiles(selectedFolderPath, "*.doc").Concat(Directory.GetFiles(selectedFolderPath, "*.docx")).Concat(Directory.GetFiles(selectedFolderPath, "*.docm")).ToArray();

                    int totalFiles = wordFiles.Length;
                    int processedFiles = 0;

                    // Perform folder bulk processing in a background thread
                    await Task.Run(() =>
                    {
                        foreach (string filePath in wordFiles)
                        {
                            allFiles.Add(filePath); // Add file to the list
                            processedFiles++;
                            int progress = (int)((processedFiles / (double)totalFiles) * 100);
                        }
                    });

                    // Update list boxes after adding files
                    UpdateListBoxes();
                    //MessageBox.Show($"Found {wordFiles.Length} Word files in selected folder.", "Word Files Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide loading screen when folder bulk processing completes
                    HideLoadingScreen();
                }
                else
                {
                    HideLoadingScreen();
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Documents (*.docx;*.doc;*.docm)|*.docx;*.doc;*.docm|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Show loading screen
                    ShowLoadingScreen();

                    // Perform single file processing in a background thread
                    await Task.Run(() =>
                    {
                        allFiles.Add(selectedFilePath); // Add file to the list
                    });

                    // Update list boxes after adding the file
                    UpdateListBoxes();
                    //MessageBox.Show($"Selected file: {selectedFilePath}", "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide loading screen when processing completes
                    HideLoadingScreen();
                }
                else
                {
                    HideLoadingScreen();
                }
            }
        }

        private async void Bulking_Click(object sender, EventArgs e)
        {
            string rootDirectory = "C:\\"; // تغيير هذا إلى المجلد الجذر الذي ترغب في البحث فيه

            // Show loading screen
            ShowLoadingScreen();

            // Perform bulk search in a background thread
            await Task.Run(() =>
            {
                FindWordFiles(rootDirectory);
            });

            // Update list boxes after bulk search
            UpdateListBoxes();

            // Hide loading screen when bulk search completes
            HideLoadingScreen();
        }

        private void FindWordFiles(string rootDir)
        {
            TraverseDirectory(rootDir);
        }

        private void TraverseDirectory(string currentDir)
        {
            try
            {
                foreach (string file in Directory.GetFiles(currentDir, "*.doc"))
                {
                    allFiles.Add(file);
                }

                foreach (string file in Directory.GetFiles(currentDir, "*.docx"))
                {
                    allFiles.Add(file);
                }

                foreach (string file in Directory.GetFiles(currentDir, "*.docm"))
                {
                    allFiles.Add(file);
                }

                foreach (string dir in Directory.GetDirectories(currentDir))
                {
                    TraverseDirectory(dir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Access to directory {currentDir} is denied.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accessing directory {currentDir}. Error details: {ex.Message}");
            }
        }

        private void listBoxUnprotected_SelectedIndexChanged(object sender, EventArgs e)
        {
            // التعامل مع حدث تغيير التحديد في قائمة المستندات غير المحمية
        }

        private void listBoxPasswordProtected_SelectedIndexChanged(object sender, EventArgs e)
        {
            // التعامل مع حدث تغيير التحديد في قائمة المستندات المحمية بكلمة مرور
        }

        private void buttonViewSelectedFile_Click(object sender, EventArgs e)
        {
            // التعامل مع حدث عرض الملف المحدد
        }

        private void OpenFileInSubForm3(string filePath)
        {
            if (subForm3 == null)
            {
                subForm3 = new SubForm3AnalysisAr();
            }
            subForm3.SetFilePath(filePath);
            subForm3.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HideControls();

            if (subForm3 == null)
            {
                subForm3 = new SubForm3AnalysisAr();
                subForm3.SetFilePaths(allFiles);
            }

            subForm3.TopLevel = false;
            subForm3.FormBorderStyle = FormBorderStyle.None;
            subForm3.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(subForm3);
            subForm3.Show();
        }

        private void HideControls()
        {
            // إخفاء عناصر التحكم
            btnImageDisk.Visible = false;
            Bulking.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            btnNext.Visible = false;
        }

        private void btnImageDisk_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Forensic Images|*.dd;*.img;*.ad1;*.eo1";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // Show loading screen
                    ShowLoadingScreen();

                    // Perform image disk extraction in a background thread
                    Task.Run(() =>
                    {
                        ExtractWordDocuments(imagePath);
                        // Hide loading screen when extraction completes
                        HideLoadingScreen();
                    });
                }
            }
        }

        private void ExtractWordDocuments(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
                MessageBox.Show("Please select a valid forensic image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tempDirectory = Path.Combine(Directory.GetCurrentDirectory(), "TempRecoveredFiles_" + Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDirectory);

            string outputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "RecoveredWordDocuments_" + Guid.NewGuid().ToString());
            Directory.CreateDirectory(outputDirectory);

            string tskRecoverArgs = $"-a \"{imagePath}\" \"{tempDirectory}\"";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "tsk_recover",
                Arguments = tskRecoverArgs,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
                process.ErrorDataReceived += (s, e) => Console.WriteLine(e.Data);
                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    MessageBox.Show("Error recovering files from image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] recoveredFiles = Directory.GetFiles(tempDirectory, "*.*", SearchOption.AllDirectories);

                foreach (string file in recoveredFiles)
                {
                    if (IsWordDocument(file))
                    {
                        File.Copy(file, Path.Combine(outputDirectory, Path.GetFileName(file)), true);
                    }
                }

                Invoke(new Action(() =>
                {
                    MessageBox.Show($"Recovered {recoveredFiles.Length} Word documents from image.", "Recovery Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (string file in Directory.GetFiles(outputDirectory, "*.doc").Concat(Directory.GetFiles(outputDirectory, "*.docx")).Concat(Directory.GetFiles(outputDirectory, "*.docm")))
                    {
                        allFiles.Add(file); // Add recovered files to the list
                    }
                    UpdateListBoxes();
                }));
            }
        }

        private bool IsWordDocument(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return extension.Equals(".doc", StringComparison.OrdinalIgnoreCase) ||
                   extension.Equals(".docx", StringComparison.OrdinalIgnoreCase) ||
                   extension.Equals(".docm", StringComparison.OrdinalIgnoreCase);
        }

        private void ShowLoadingScreen()
        {
            loadingForm = new Loading();
            loadingForm.Show();
        }

        private void HideLoadingScreen()
        {
            if (loadingForm != null)
            {
                loadingForm.Close();
                loadingForm = null;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (subForm3 != null)
            {
                subForm3.Hide();
            }
            ShowControls();
        }

        private void ShowControls()
        {
            btnImageDisk.Visible = true;
            Bulking.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            btnNext.Visible = true;
        }

        private void SubForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loadingForm != null && !loadingForm.IsDisposed)
            {
                loadingForm.Close();
            }
        }

        private void SubForm2_Load(object sender, EventArgs e)
        {
            // إعداد النموذج عند تحميله
        }

        private void buttonUnlockPassword_Click(object sender, EventArgs e)
        {
            // معالجة حدث فتح كلمة المرور
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // تأكد من أن panel1 هو اسم الـ Panel الذي تريد عرض SubForm2 فيه
            panel1.Controls.Clear(); // إزالة أي عناصر موجودة حالياً في الـ Panel

            // إنشاء نسخة من SubForm2
            Form1 subForm2 = new Form1();

            // تعيين حجم SubForm2 ليكون مناسباً للـ Panel
            subForm2.TopLevel = false;
            subForm2.Dock = DockStyle.Fill;

            // إضافة SubForm2 إلى الـ Panel
            panel1.Controls.Add(subForm2);

            // عرض SubForm2 داخل الـ Panel
            subForm2.Show();
        }
    }
}
