using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace WinApp.Template
{
    public partial class Docx : Form
    {
        public Docx()
        {
            InitializeComponent();
        }

        public void CreateTemplate(string outputPath, List<dynamic> results)
        {
            using (DocX document = DocX.Create(outputPath))
            {
                // Add a title
                document.InsertParagraph("Report Template")
                    .FontSize(20d)
                    .Bold()
                    .Alignment = Alignment.center;

                // Loop through each result
                foreach (var result in results)
                {
                    // Display Metadata if available
                    if (result.metadata != null)
                    {
                        document.InsertParagraph("=== Metadata ===")
                            .FontSize(14d)
                            .Bold()
                            .Color(System.Drawing.Color.Blue);

                        document.InsertParagraph($"Filename: {result.metadata.filename}")
                            .FontSize(12d);
                        document.InsertParagraph($"Author: {result.metadata.author}")
                            .FontSize(12d);
                        document.InsertParagraph($"Created: {result.metadata.created}")
                            .FontSize(12d);
                        document.InsertParagraph($"Last Modified By: {result.metadata.last_modified_by}")
                            .FontSize(12d);
                        document.InsertParagraph($"Modified: {result.metadata.modified}")
                            .FontSize(12d);
                        document.InsertParagraph($"Size: {result.metadata.size} bytes")
                            .FontSize(12d);
                        document.InsertParagraph($"Comments: {result.metadata.comments}")
                            .FontSize(12d);
                        document.InsertParagraph($"Content Status: {result.metadata.content_status}")
                            .FontSize(12d);
                        document.InsertParagraph($"Title: {result.metadata.title}")
                            .FontSize(12d);
                        document.InsertParagraph($"Keywords: {result.metadata.keywords}")
                            .FontSize(12d);
                        document.InsertParagraph($"Subject: {result.metadata.subject}")
                            .FontSize(12d);
                        document.InsertParagraph($"Category: {result.metadata.category}")
                            .FontSize(12d);
                        document.InsertParagraph($"Words: {result.metadata.words}")
                            .FontSize(12d);
                        document.InsertParagraph($"Pages: {result.metadata.pages}")
                            .FontSize(12d);
                        document.InsertParagraph($"Watermark: {result.metadata.watermark}")
                            .FontSize(12d);

                        document.InsertParagraph(""); // Add an empty line
                    }

                    // Display Hash Value if available
                    if (result.hash_value != null)
                    {
                        document.InsertParagraph("=== Hash Value ===")
                            .FontSize(14d)
                            .Bold()
                            .Color(System.Drawing.Color.Blue);

                        document.InsertParagraph($"Hash Value: {result.hash_value}")
                            .FontSize(12d);

                        document.InsertParagraph(""); // Add an empty line
                    }

                    // Display VBA Code Presence if available
                    if (result.vba_code != null)
                    {
                        document.InsertParagraph("=== VBA Code Presence ===")
                            .FontSize(14d)
                            .Bold()
                            .Color(System.Drawing.Color.Blue);

                        document.InsertParagraph($"VBA Code Presence: {result.vba_code}")
                            .FontSize(12d);

                        document.InsertParagraph(""); // Add an empty line
                    }

                    // Display Keyword Search if available
                    if (result.result != null)
                    {
                        document.InsertParagraph("=== Keyword Search ===")
                            .FontSize(14d)
                            .Bold()
                            .Color(System.Drawing.Color.Blue);

                        foreach (var wordInfo in result.result)
                        {
                            string word = wordInfo.Name;
                            var info = wordInfo.Value;

                            document.InsertParagraph($"Word: {word}")
                                .FontSize(12d);
                            document.InsertParagraph($"Total repetitions: {info.count}")
                                .FontSize(12d);
                            document.InsertParagraph("Locations:")
                                .FontSize(12d);

                            foreach (var location in info.locations)
                            {
                                document.InsertParagraph($"- Paragraph: {location[0]}, Line: {location[1]}")
                                    .FontSize(12d);
                            }

                            document.InsertParagraph(""); // Add an empty line
                        }

                        document.InsertParagraph(""); // Add an empty line
                    }

                    // Display Artifacts if available
                    if (result.artifacts != null)
                    {
                        document.InsertParagraph("=== Artifacts ===")
                            .FontSize(14d)
                            .Bold()
                            .Color(System.Drawing.Color.Blue);

                        foreach (var artifact in result.artifacts)
                        {
                            document.InsertParagraph(artifact)
                                .FontSize(12d);
                        }

                        document.InsertParagraph(""); // Add an empty line
                    }

                    document.InsertParagraph(new string('-', 60)); // Add a separator between results
                }

                // Save the document
                document.Save();
            }
        }
    }
}
