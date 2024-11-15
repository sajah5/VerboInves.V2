using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;

namespace WinApp
{
    public partial class PasswordSubForm4Ar : Form
    {
        private Loading loadingForm;
        private List<string> passwordProtectedFiles;

        public PasswordSubForm4Ar()
        {
            InitializeComponent();
            passwordProtectedFiles = new List<string>();
        }

        // Method to receive the list of password-protected files
        public void SetPasswordProtectedFiles(List<string> filesWithPassword)
        {
            // Clear existing items
            passwordProtectedFiles.Clear();

            // Add the received files to the list
            passwordProtectedFiles.AddRange(filesWithPassword);
        }

        private void SendFilePathToPython(string baseUriString, int port)
        {
            var baseUri = new Uri($"{baseUriString}:{port}");
            var client = new RestClient(baseUri);

            var endpoint = new Uri(baseUri, "/process_file");
            var request = new RestRequest(endpoint, Method.Post);
            request.AddHeader("Content-Type", "application/json");

            // Show loading screen
            loadingForm = new Loading();
            loadingForm.SetLoadingText("Sending data to server...");
            loadingForm.Show();

            try
            {
                // Loop through each item in the list and send the file path
                foreach (var file in passwordProtectedFiles)
                {
                    var data = new { docxFilePath = file };
                    request.AddJsonBody(data);

                    var response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        var results = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                        MessageBox.Show("The file was opened successfully");
                    }
                    else
                    {
                        //MessageBox.Show($"Error {response.ErrorMessage}");
                    }
                }
            }
            finally
            {
                // Hide loading screen
                if (loadingForm != null)
                {
                    loadingForm.Hide();
                    loadingForm = null;
                }
            }
        }

        private void buttonMask_Click_1(object sender, EventArgs e)
        {
            SendFilePathToPython("http://127.0.0.1", 8040);
        }

        private void buttonRuleBased_Click_1(object sender, EventArgs e)
        {
            SendFilePathToPython("http://127.0.0.1", 8050);
        }

        private void buttonDictionry_Click(object sender, EventArgs e)
        {
            SendFilePathToPython("http://127.0.0.1", 8030);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close(); // إغلاق النافذة الحالية فقط
        }

        private static void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
