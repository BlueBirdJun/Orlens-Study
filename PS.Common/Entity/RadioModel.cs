using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Entity
{
    public class RadioModel
    {
        public string webHookIDX { get; set; }
        public string prTitle { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public string url { get; set; }
        public List<string> sendID { get; set; }
        public string writerID { get; set; }
        public string sendTime { get; set; }
        public string method { get; set; }
        public string methodParameter { get; set; }
    }
}
