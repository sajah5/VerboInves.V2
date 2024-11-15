using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Security.Cryptography;

namespace WinApp
{
    public partial class SubForm3AnalysisAr : Form
    {
        private LoadingScreen2 loadingForm;
        private List<string> filePaths; // قائمة مسارات الملفات
        private List<string> filesWithPassword; // قائمة الملفات التي تحتوي على كلمة مرور
        private List<string> filesWithoutPassword; // قائمة الملفات التي لا تحتوي على كلمة مرور
        private string selectedFilePath; // مسار الملف المحدد

        // متغيرات لتخزين حالة الـ CheckBox
        private bool processMetadata = false;
        private bool processKeyword = false;
        private bool processArtifact = false;
        private bool processVBA = false;
        private bool processHash = false;
        private bool processMalware = false;
        private bool createWordList = false; // متغير لتخزين اختيار المستخدم بخصوص إنشاء قائمة كلمات
        private string wordListFilePath; // مسار ملف قائمة الكلمات
        string fileHash = "fe000f29161d8a6db174f9d9f378c8ea04d48eb4125b8f793f590a7ab96dba79";


        private bool isForm5Open = false; // متغير لتتبع حالة الفورم الرابع

        public int maliciousCount { get; private set; }

        public SubForm3AnalysisAr()
        {
            InitializeComponent();
            filePaths = new List<string>();
            filesWithPassword = new List<string>();
            filesWithoutPassword = new List<string>();
        }

        public void SetFilePaths(List<string> paths)
        {
            filePaths = paths;
            ClassifyFiles(); // تصنيف الملفات عند تعيين المسارات
            DisplayClassificationMessage(); // عرض رسالة التصنيف
        }

        private void SubForm3_Load(object sender, EventArgs e)
        {
            if (filePaths.Count > 0)
            {
                selectedFilePath = filePaths[0];
            }

            DisplayClassificationMessage();
        }

        private void ClassifyFiles()
        {
            filesWithPassword.Clear();
            filesWithoutPassword.Clear();

            foreach (var path in filePaths)
            {
                try
                {
                    if (ContainsPassword(path))
                    {
                        filesWithPassword.Add(path);
                    }
                    else
                    {
                        filesWithoutPassword.Add(path);
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Error accessing file '{path}': {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private bool ContainsPassword(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (line.Contains("password", StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (IOException ex)
            {
                throw new IOException($"Error accessing file '{filePath}': {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        private void DisplayClassificationMessage()
        {
            string filesWithPasswordMessage = "Files containing password:\n";
            foreach (string file in filesWithPassword)
            {
                filesWithPasswordMessage += file + "\n";
            }

            string filesWithoutPasswordMessage = "Files without password:\n";
            foreach (string file in filesWithoutPassword)
            {
                filesWithoutPasswordMessage += file + "\n";
            }

            //MessageBox.Show(filesWithPasswordMessage + "\n" + filesWithoutPasswordMessage, "Files Classification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (filesWithPassword.Count > 0 && !isForm5Open)
            {
                OpenSubForm4WithPasswordFiles();
            }
        }

        private void OpenSubForm4WithPasswordFiles()
        {
            isForm5Open = true;
            PasswordSubForm4Ar subform4 = new PasswordSubForm4Ar();
            subform4.SetPasswordProtectedFiles(filesWithPassword);
            subform4.FormClosed += (s, args) => isForm5Open = false;
            subform4.Show();
        }

        public List<string> GetFilesWithPassword()
        {
            return filesWithPassword;
        }

        public void SetFilePath(string filePath)
        {
            filePaths.Clear();
            filePaths.Add(filePath);
            selectedFilePath = filePath;
        }

        private void ProcessFile(string endpointPath, string filePath, List<string> results)
        {
            try
            {
                var client = new RestClient(endpointPath);
                var request = new RestRequest("/process_file", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var requestBody = new { filePath };
                request.AddJsonBody(requestBody);

                Console.WriteLine($"Sending request to {endpointPath} with body: {JsonConvert.SerializeObject(requestBody)}");

                var response = client.Execute(request);

                Console.WriteLine($"Response from {endpointPath}: {response.Content}");

                if (response.IsSuccessful)
                {
                    results.Add(response.Content);
                }
                else
                {
                    Console.WriteLine($"Error processing {filePath}: {response.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception processing {filePath}: {ex.Message}");
            }
        }

        private void ProcessFiles(string endpointPath, string filePath, List<string> results)
        {
            try
            {
                var client = new RestClient(endpointPath);
                var request = new RestRequest("/process_file", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(new { docxFilePath = filePath });

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    results.Add(response.Content);
                }
                else
                {
                    Console.WriteLine($"Error processing {filePath}: {response.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {filePath}: {ex.Message}");
            }
        }

        private void Processfiles(string endpointPath, string filePath, string wordListFile, List<string> results)
        {
            try
            {
                var client = new RestClient(endpointPath);
                var request = new RestRequest("/process_file", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(new { docxFilePath = filePath, wordListFile });

                var response = client.Execute(request);

                Console.WriteLine($"Response from {endpointPath}: {response.Content}");

                if (response.IsSuccessful)
                {
                    results.Add(response.Content);
                }
                else
                {
                    Console.WriteLine($"Error processing {filePath}: {response.ErrorMessage}");
                    //MessageBox.Show($"Error processing {filePath}: {response.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {filePath}: {ex.Message}");
                //MessageBox.Show($"Error processing {filePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string ComputeFileHash(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                SHA256 sha256 = SHA256.Create();
                byte[] hashBytes = sha256.ComputeHash(stream);
                StringBuilder hashString = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }

                return hashString.ToString();
            }
        }
        private async Task ProcessMalware(string fileHash, List<string> results)
        {
            string apiKey = "237e0264a579c6806c981b9a81c585f713339166110504ee6f42cb15e1aa08f1";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-apikey", apiKey);

                HttpResponseMessage response = await client.GetAsync($"https://www.virustotal.com/api/v3/files/{fileHash}");

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);

                    // تحليل البيانات وتنسيقها
                    JObject formattedResult = new JObject();
                    formattedResult["FileName"] = json["data"]["attributes"]["names"]?.First?.ToString() ?? "Unknown";

                    JObject lastAnalysisStats = json["data"]["attributes"]["last_analysis_stats"] as JObject;
                    formattedResult["MaliciousCount"] = lastAnalysisStats["malicious"].Value<int>();
                    formattedResult["SuspiciousCount"] = lastAnalysisStats["suspicious"].Value<int>();
                    formattedResult["UndetectedCount"] = lastAnalysisStats["undetected"].Value<int>();
                    formattedResult["HarmlessCount"] = lastAnalysisStats["harmless"].Value<int>();
                    formattedResult["TimeoutCount"] = lastAnalysisStats["timeout"].Value<int>();
                    formattedResult["ConfirmedTimeoutCount"] = lastAnalysisStats["confirmed-timeout"].Value<int>();
                    formattedResult["FailureCount"] = lastAnalysisStats["failure"].Value<int>();
                    formattedResult["TypeUnsupportedCount"] = lastAnalysisStats["type-unsupported"].Value<int>();

                    // إضافة النتيجة كسلسلة JSON إلى قائمة النتائج
                    results.Add(formattedResult.ToString());
                }
            }
        }



        private async void buttonNext_Click(object sender, EventArgs e)
        {

            if (processMetadata || processKeyword || processArtifact || processVBA || processHash || processMalware)
            {
                loadingForm = new LoadingScreen2();
                loadingForm.Show();
            }

            List<string> allResults = new List<string>();

            await Task.Run(async () =>
            {
                foreach (var filePath in filePaths)
                {
                    if (processMetadata)
                    {
                        ProcessFile("http://127.0.0.1:8000", filePath, allResults);
                    }

                    if (processKeyword)
                    {
                        Processfiles("http://127.0.0.1:8020", filePath, wordListFilePath, allResults);
                    }

                    if (processArtifact)
                    {
                        ProcessFiles("http://127.0.0.1:8010", filePath, allResults);
                    }

                    if (processVBA)
                    {
                        ProcessFile("http://127.0.0.1:8080", filePath, allResults);
                    }

                    if (processHash)
                    {
                        ProcessFile("http://127.0.0.1:8090", filePath, allResults);
                    }
                    if (processMalware)
                    {
                        string fileHash = ComputeFileHash(filePath);
                        await ProcessMalware(fileHash, allResults); // تنفيذ المعالجة وانتظار الاكتمال
                    }
                }
            });

            if (loadingForm != null)
            {
                loadingForm.Hide();
                loadingForm.Dispose();
                loadingForm = null;
            }

            DisplayResultsInReport(allResults, processMetadata, processHash, processVBA, processKeyword, processArtifact, processMalware);
        }

        private void DisplayResultsInReport(List<string> results, bool displayMetadata, bool displayHashValue, bool displayVBA, bool displayKeywordSearch, bool displayArtifact, bool displayMalware)
        {
            HideControls();

            Report2Ar resultsForm = new Report2Ar();
            resultsForm.SetResults(results); // تم تعديل هذا المكان لدعم الإظهار المالوير

            panel1.Controls.Clear();
            panel1.Controls.Add(resultsForm);
            resultsForm.Show();
        }

        private void HideControls()
        {
            buttonNext.Visible = false;
            checkBoxMetadata.Visible = false;
            checkBoxHash.Visible = false;
            checkBoxVBA.Visible = false;
            checkBoxArtifact.Visible = false;
            checkBoxKeyword.Visible = false;
            checkBoxMalwareScan.Visible = false;
        }

        private void checkBoxMetadata_CheckedChanged(object sender, EventArgs e)
        {
            processMetadata = checkBoxMetadata.Checked;
        }

        private void checkBoxKeyword_CheckedChanged(object sender, EventArgs e)
        {
            processKeyword = checkBoxKeyword.Checked;
            if (checkBoxKeyword.Checked)
            {
                DialogResult result = MessageBox.Show("هل تريد رفع قائمة خاصة بك؟", "إنشاء قائمة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // عرض نموذج إنشاء قائمة الكلمات
                    SubForm5ListSplashAr wordListForm = new SubForm5ListSplashAr();
                    if (wordListForm.ShowDialog() == DialogResult.OK)
                    {
                        createWordList = true;
                        wordListFilePath = wordListForm.WordListFilePath; // استخدام مسار ملف القائمة المختار
                    }
                }
                else
                {
                    createWordList = false;
                    wordListFilePath = @"C:\Users\saja\Desktop\project\Code\Word_List\wordlist.txt"; // استخدام مسار ملف القائمة الأصلي
                }
            }
            else
            {
                createWordList = false;
            }
        }

        private void checkBoxArtifact_CheckedChanged(object sender, EventArgs e)
        {
            processArtifact = checkBoxArtifact.Checked;
        }

        private void checkBoxVBA_CheckedChanged(object sender, EventArgs e)
        {
            processVBA = checkBoxVBA.Checked;
        }

        private void checkBoxHash_CheckedChanged(object sender, EventArgs e)
        {
            processHash = checkBoxHash.Checked;
        }
        private void checkBoxMalwareScan_CheckedChanged(object sender, EventArgs e)
        {
            processMalware = checkBoxMalwareScan.Checked;
        }
        private void ShowWordListCreationDialog()
        {
            // قم بإظهار نافذة أو قم بالخطوات اللازمة لإنشاء قائمة الكلمات هنا
            // مثلاً، إظهار نموذج لإدخال كلمات القائمة
            // يمكنك استخدام SubForm5 كنموذج لإدخال كلمات القائمة
            SubForm5ListSplashAr wordListForm = new SubForm5ListSplashAr();
            wordListForm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // تأكد من أن panel1 هو اسم الـ Panel الذي تريد عرض SubForm2 فيه
            panel1.Controls.Clear(); // إزالة أي عناصر موجودة حالياً في الـ Panel

            // إنشاء نسخة من SubForm2
            SubForm2AcquisitionAr subForm2 = new SubForm2AcquisitionAr();

            // تعيين حجم SubForm2 ليكون مناسباً للـ Panel
            subForm2.TopLevel = false;
            subForm2.Dock = DockStyle.Fill;

            // إضافة SubForm2 إلى الـ Panel
            panel1.Controls.Add(subForm2);

            // عرض SubForm2 داخل الـ Panel
            subForm2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
