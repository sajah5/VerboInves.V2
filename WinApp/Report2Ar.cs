using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Report2Ar : UserControl
    {
        public Report2Ar()
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
                    listBoxResults.Items.Add("=== نتائج البيانات الوصفية ===");
                    listBoxResults.Items.Add($"اسم الملف: {data.metadata.filename}");
                    listBoxResults.Items.Add($"المؤلف: {data.metadata.author}");
                    listBoxResults.Items.Add($"تاريخ الإنشاء: {data.metadata.created}");
                    listBoxResults.Items.Add($"آخر تعديل بواسطة: {data.metadata.last_modified_by}");
                    listBoxResults.Items.Add($"تاريخ آخر تعديل: {data.metadata.modified}");
                    listBoxResults.Items.Add($"الحجم: {data.metadata.size} bytes");
                    listBoxResults.Items.Add($"التعليقات: {data.metadata.comments}");
                    listBoxResults.Items.Add($"حالة المحتوى: {data.metadata.content_status}");
                    listBoxResults.Items.Add($"العنوان: {data.metadata.title}");
                    listBoxResults.Items.Add($"الكلمات المفتاحية: {data.metadata.keywords}");
                    listBoxResults.Items.Add($"الموضوع: {data.metadata.subject}");
                    listBoxResults.Items.Add($"الفئة: {data.metadata.category}");
                    listBoxResults.Items.Add($"عدد الكلمات: {data.metadata.words}");
                    listBoxResults.Items.Add($"عدد الصفحات: {data.metadata.pages}");
                    listBoxResults.Items.Add($"العلامة المائية: {data.metadata.watermark}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display Hash Value (assuming it's returned as part of the response)
                if (data.hash_value != null)
                {
                    listBoxResults.Items.Add("=== نتائج قيمة التجزئة ===");
                    listBoxResults.Items.Add($"قيمة التجزئة: {data.hash_value}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display VBA Code (assuming it's returned as part of the response)
                if (data.vba_code != null)
                {
                    listBoxResults.Items.Add("===  نتائج VBA ===");
                    listBoxResults.Items.Add($" هل VBA موجود؟: {data.vba_code}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display Keyword Search
                if (data.result != null)
                {
                    listBoxResults.Items.Add("=== الكلمات المفتاحية ===");
                    foreach (var wordInfo in data.result)
                    {
                        string word = wordInfo.Name;
                        var info = wordInfo.Value;
                        listBoxResults.Items.Add($"الكلمة: {word}");
                        listBoxResults.Items.Add($"إجمالي التكرارات: {info.count}");
                        listBoxResults.Items.Add("الموقع:");
                        foreach (var location in info.locations)
                        {
                            listBoxResults.Items.Add($" الفقرة: {location[0]}");
                            listBoxResults.Items.Add($" السطر: {location[1]}");
                        }
                        listBoxResults.Items.Add(""); // Add an empty line for better readability
                    }
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Display Malware Analysis
                if (data.MaliciousCount != null)
                {
                    listBoxResults.Items.Add("=== تحليل البرمجيات الخبيثة ===");
                    listBoxResults.Items.Add($"اسم الملف: {data.FileName}");
                    listBoxResults.Items.Add($"عدد الملفات الخبيثة: {data.MaliciousCount}");
                    listBoxResults.Items.Add($"عدد الملفات المشتبه بها: {data.SuspiciousCount}");
                    listBoxResults.Items.Add($"عدد الملفات غير المكتشفة: {data.UndetectedCount}");
                    listBoxResults.Items.Add($"عدد الملفات غير الضارة: {data.HarmlessCount}");
                    listBoxResults.Items.Add($"عدد الأخطاء بسبب انتهاء الوقت: {data.TimeoutCount}");
                    listBoxResults.Items.Add($"عدد الأخطاء بسبب انتهاء الوقت المؤكدة: {data.ConfirmedTimeoutCount}");
                    listBoxResults.Items.Add($"عدد حالات الفشل: {data.FailureCount}");
                    listBoxResults.Items.Add($"عدد الملفات غير المدعومة: {data.TypeUnsupportedCount}");
                    listBoxResults.Items.Add(new string('-', 80)); // Add a separator
                }

                // Collect Artifact data
                List<string> artifacts = new List<string>();
                if (data.mentioned_professional_names != null)
                {
                    foreach (var name in data.mentioned_professional_names)
                    {
                        artifacts.Add($"الأسماء المهنية: {name}");
                    }
                }
                if (data.mentioned_female_names != null)
                {
                    foreach (var name in data.mentioned_female_names)
                    {
                        artifacts.Add($"أسماء الإناث: {name}");
                    }
                }
                if (data.mentioned_male_names != null)
                {
                    foreach (var name in data.mentioned_male_names)
                    {
                        artifacts.Add($"أسماء الذكور: {name}");
                    }
                }
                if (data.mentioned_usernames != null)
                {
                    foreach (var username in data.mentioned_usernames)
                    {
                        artifacts.Add($"اسم المستخدم: {username}");
                    }
                }
                if (data.mentioned_passwords != null)
                {
                    foreach (var password in data.mentioned_passwords)
                    {
                        artifacts.Add($"كلمات المرور: {password}");
                    }
                }
                if (data.mentioned_phone_numbers != null)
                {
                    foreach (var phoneNumber in data.mentioned_phone_numbers)
                    {
                        artifacts.Add($"أرقام الهواتف: {phoneNumber}");
                    }
                }
                if (data.mentioned_emails != null)
                {
                    foreach (var email in data.mentioned_emails)
                    {
                        artifacts.Add($"البريد الإلكتروني: {email}");
                    }
                }
                if (data.mentioned_hashes != null)
                {
                    foreach (var hash in data.mentioned_hashes)
                    {
                        artifacts.Add($"قيم التجزئة: {hash}");
                    }
                }
                if (data.mentioned_dates != null)
                {
                    foreach (var date in data.mentioned_dates)
                    {
                        artifacts.Add($"التواريخ: {date}");
                    }
                }
                if (data.mentioned_clock_hours != null)
                {
                    foreach (var clockHour in data.mentioned_clock_hours)
                    {
                        artifacts.Add($"الساعات: {clockHour}");
                    }
                }
                if (data.mentioned_cities != null)
                {
                    foreach (var city in data.mentioned_cities)
                    {
                        artifacts.Add($"المدن: {city}");
                    }
                }
                if (data.mentioned_coordinates != null)
                {
                    foreach (var coordinate in data.mentioned_coordinates)
                    {
                        artifacts.Add($"الإحداثيات: {coordinate}");
                    }
                }
                if (data.mentioned_ipv4_addresses != null)
                {
                    foreach (var ipv4 in data.mentioned_ipv4_addresses)
                    {
                        artifacts.Add($"IPv4 عناوين: {ipv4}");
                    }
                }
                if (data.mentioned_ipv6_addresses != null)
                {
                    foreach (var ipv6 in data.mentioned_ipv6_addresses)
                    {
                        artifacts.Add($"IPv6 عناوين: {ipv6}");
                    }
                }
                if (data.mentioned_mac_addresses != null)
                {
                    foreach (var mac in data.mentioned_mac_addresses)
                    {
                        artifacts.Add($"MAC عناوين: {mac}");
                    }
                }
                if (data.mentioned_device_os != null)
                {
                    foreach (var os in data.mentioned_device_os)
                    {
                        artifacts.Add($"نظام التشغيل الجهاز: {os}");
                    }
                }
                if (data.mentioned_hyperlinks != null)
                {
                    foreach (var hyperlink in data.mentioned_hyperlinks)
                    {
                        artifacts.Add($"الروابط التشعبية: {hyperlink}");
                    }
                }
                if (data.mentioned_websites != null)
                {
                    foreach (var website in data.mentioned_websites)
                    {
                        artifacts.Add($"المواقع الإلكترونية: {website}");
                    }
                }

                // Display all collected Artifact data
                if (artifacts.Count > 0)
                {
                    listBoxResults.Items.Add("=== نتائج الأدلة ===");
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
            FormDownloadAr downloadForm = new FormDownloadAr(checkedListData);
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
            SubForm3AnalysisAr subForm3 = new SubForm3AnalysisAr();

            // تعيين حجم SubForm2 ليكون مناسباً للـ Panel
            subForm3.TopLevel = false;
            subForm3.Dock = DockStyle.Fill;

            // إضافة SubForm2 إلى الـ Panel
            panel1.Controls.Add(subForm3);

            // عرض SubForm2 داخل الـ Panel
            subForm3.Show();
        }
    }
}

