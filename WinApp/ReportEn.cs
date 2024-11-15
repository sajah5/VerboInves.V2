using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinApp
{
    public partial class ReportEn : UserControl
    {
        public ReportEn()
        {
            InitializeComponent();
        }

        public void SetResults(List<string> results)
        {
            listBoxResults.Font = new Font("Arial", 10); // تعيين الخط الذي يدعم اللغة العربية
            listBoxResults.RightToLeft = RightToLeft.Yes; // تعيين اتجاه الكتابة
            listBoxResults.Items.Clear();  // Clear the list before adding new items


            foreach (var result in results)
            {
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(result);

                // Display Metadata
                if (data.metadata != null)
                {
                    listBoxResults.Items.Add("=== Metadata results ===");
                    listBoxResults.Items.Add($"File name: {data.metadata.filename}");
                    listBoxResults.Items.Add($"Author: {data.metadata.author}");
                    listBoxResults.Items.Add($"Creation date: {data.metadata.created}");
                    listBoxResults.Items.Add($"Last modified by: {data.metadata.last_modified_by}");
                    listBoxResults.Items.Add($"Date of last modification: {data.metadata.modified}");
                    listBoxResults.Items.Add($"Size: {data.metadata.size} bytes");
                    listBoxResults.Items.Add($"Comments: {data.metadata.comments}");
                    listBoxResults.Items.Add($"Content status: {data.metadata.content_status}");
                    listBoxResults.Items.Add($"Title: {data.metadata.title}");
                    listBoxResults.Items.Add($"Keywords: {data.metadata.keywords}");
                    listBoxResults.Items.Add($"Subject: {data.metadata.subject}");
                    listBoxResults.Items.Add($"Category: {data.metadata.category}");
                    listBoxResults.Items.Add($"Word count: {data.metadata.words}");
                    listBoxResults.Items.Add($"Pages count: {data.metadata.pages}");
                    listBoxResults.Items.Add($"Watermark: {data.metadata.watermark}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display Hash Value (assuming it's returned as part of the response)
                if (data.hash_value != null)
                {
                    listBoxResults.Items.Add("=== Hash value result ===");
                    listBoxResults.Items.Add($"Hash: {data.hash_value}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display VBA Code (assuming it's returned as part of the response)
                if (data.vba_code != null)
                {
                    listBoxResults.Items.Add("=== VBA code result ===");
                    listBoxResults.Items.Add($"Presence of VBA code: {data.vba_code}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display Keyword Search
                if (data.result != null)
                {
                    listBoxResults.Items.Add("=== Keyword search results ===");
                    foreach (var wordInfo in data.result)
                    {
                        string word = wordInfo.Name;
                        var info = wordInfo.Value;
                        listBoxResults.Items.Add($"Word: {word}");
                        listBoxResults.Items.Add($"Total repetition: {info.count}");
                        listBoxResults.Items.Add("Location:");
                        foreach (var location in info.locations)
                        {
                            listBoxResults.Items.Add($" Paragraph: {location[0]}");
                            listBoxResults.Items.Add($" Line: {location[1]}");
                        }
                        listBoxResults.Items.Add(""); // Add an empty line for better readability
                    }
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display Malware Analysis
                if (data.MaliciousCount != null)
                {
                    listBoxResults.Items.Add("=== Malware scan results ===");
                    listBoxResults.Items.Add($"File name: {data.FileName}");
                    listBoxResults.Items.Add($"Malicious: {data.MaliciousCount}");
                    listBoxResults.Items.Add($"Suspicious: {data.SuspiciousCount}");
                    listBoxResults.Items.Add($"Undetected: {data.UndetectedCount}");
                    listBoxResults.Items.Add($"Harmless: {data.HarmlessCount}");
                    listBoxResults.Items.Add($"Timeout: {data.TimeoutCount}");
                    listBoxResults.Items.Add($"Confirmed timeout: {data.ConfirmedTimeoutCount}");
                    listBoxResults.Items.Add($"Failure: {data.FailureCount}");
                    listBoxResults.Items.Add($"Type unsupported: {data.TypeUnsupportedCount}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Collect Artifact data
                List<string> artifacts = new List<string>();
                if (data.mentioned_professional_names != null)
                {
                    foreach (var name in data.mentioned_professional_names)
                    {
                        artifacts.Add($"Professional names: {name}");
                    }
                }
                if (data.mentioned_female_names != null)
                {
                    foreach (var name in data.mentioned_female_names)
                    {
                        artifacts.Add($"Female names: {name}");
                    }
                }
                if (data.mentioned_male_names != null)
                {
                    foreach (var name in data.mentioned_male_names)
                    {
                        artifacts.Add($"Male name: {name}");
                    }
                }
                if (data.mentioned_usernames != null)
                {
                    foreach (var username in data.mentioned_usernames)
                    {
                        artifacts.Add($"User name: {username}");
                    }
                }
                if (data.mentioned_passwords != null)
                {
                    foreach (var password in data.mentioned_passwords)
                    {
                        artifacts.Add($"Password: {password}");
                    }
                }
                if (data.mentioned_phone_numbers != null)
                {
                    foreach (var phoneNumber in data.mentioned_phone_numbers)
                    {
                        artifacts.Add($"Phone number: {phoneNumber}");
                    }
                }
                if (data.mentioned_emails != null)
                {
                    foreach (var email in data.mentioned_emails)
                    {
                        artifacts.Add($"Emails: {email}");
                    }
                }
                if (data.mentioned_hashes != null)
                {
                    foreach (var hash in data.mentioned_hashes)
                    {
                        artifacts.Add($"Hashes: {hash}");
                    }
                }
                if (data.mentioned_dates != null)
                {
                    foreach (var date in data.mentioned_dates)
                    {
                        artifacts.Add($"Dates: {date}");
                    }
                }
                if (data.mentioned_clock_hours != null)
                {
                    foreach (var clockHour in data.mentioned_clock_hours)
                    {
                        artifacts.Add($"Clock hours: {clockHour}");
                    }
                }
                if (data.mentioned_cities != null)
                {
                    foreach (var city in data.mentioned_cities)
                    {
                        artifacts.Add($"Cities: {city}");
                    }
                }
                if (data.mentioned_coordinates != null)
                {
                    foreach (var coordinate in data.mentioned_coordinates)
                    {
                        artifacts.Add($"Coordinates: {coordinate}");
                    }
                }
                if (data.mentioned_ipv4_addresses != null)
                {
                    foreach (var ipv4 in data.mentioned_ipv4_addresses)
                    {
                        artifacts.Add($"IPv4 address: {ipv4}");
                    }
                }
                if (data.mentioned_ipv6_addresses != null)
                {
                    foreach (var ipv6 in data.mentioned_ipv6_addresses)
                    {
                        artifacts.Add($"IPv6 address: {ipv6}");
                    }
                }
                if (data.mentioned_mac_addresses != null)
                {
                    foreach (var mac in data.mentioned_mac_addresses)
                    {
                        artifacts.Add($"MAC address: {mac}");
                    }
                }
                if (data.mentioned_device_os != null)
                {
                    foreach (var os in data.mentioned_device_os)
                    {
                        artifacts.Add($"Device OS: {os}");
                    }
                }
                if (data.mentioned_hyperlinks != null)
                {
                    foreach (var hyperlink in data.mentioned_hyperlinks)
                    {
                        artifacts.Add($"Hyber links: {hyperlink}");
                    }
                }
                if (data.mentioned_websites != null)
                {
                    foreach (var website in data.mentioned_websites)
                    {
                        artifacts.Add($"Websites: {website}");
                    }
                }

                // Display all collected Artifact data
                if (artifacts.Count > 0)
                {
                    listBoxResults.Items.Add("=== Artifact results ===");
                    foreach (var artifact in artifacts)
                    {
                        listBoxResults.Items.Add(artifact);
                    }
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // جمع البيانات للتحويلها إلى مصفوفة للتحويلها لاحقا
            List<string> checkedListData = new List<string>();
            foreach (var item in listBoxResults.Items)
            {
                checkedListData.Add(item.ToString());
            }

            // فتح النموذج الجديد لاختيار الملفات للتنزيل
            FormDownloadEn downloadForm = new FormDownloadEn(checkedListData);
            HideControls();
            // إعداد الفورم ليظهر كـ Child داخل panel
            downloadForm.TopLevel = false;
            downloadForm.FormBorderStyle = FormBorderStyle.None;
            downloadForm.Dock = DockStyle.Fill;

            // إضافة الفورم إلى الـ panel
            panel1.Controls.Clear();
            panel1.Controls.Add(downloadForm);
            downloadForm.Show();
        }
        private void HideControls()
        {
            listBoxResults.Visible = false;
            button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // تأكد من أن panel1 هو اسم الـ Panel الذي تريد عرض SubForm2 فيه
            panel1.Controls.Clear(); // إزالة أي عناصر موجودة حالياً في الـ Panel

            // إنشاء نسخة من SubForm2
            SubForm3AnalysisEn subForm3 = new SubForm3AnalysisEn();

            // تعيين حجم SubForm2 ليكون مناسباً للـ Panel
            subForm3.TopLevel = false;
            subForm3.Dock = DockStyle.Fill;

            // إضافة SubForm2 إلى الـ Panel
            panel1.Controls.Add(subForm3);

            // عرض SubForm2 داخل الـ Panel
            subForm3.Show();
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxResults.RightToLeft = RightToLeft.No;

        }
    }
}

