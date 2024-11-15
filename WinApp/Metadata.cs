using System;

namespace WinApp
{
    public class Metadata
    {
        public string filename { get; set; }
        public string author { get; set; }
        public string created { get; set; }
        public string last_modified_by { get; set; }
        public string modified { get; set; }
        public int? size { get; set; }
        public string comments { get; set; }
        public string content_status { get; set; }
        public string title { get; set; }
        public string keywords { get; set; }
        public string subject { get; set; }
        public string category { get; set; }
        public int? words { get; set; }
        public int? pages { get; set; }
        public string watermark { get; set; }
    }
}
