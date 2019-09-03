using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Utils
{
    public class FeedBack
    {
        public bool HasErrors { get; set; }
        public List<string> Errors { get; set; }
        public List<string> Results { get; set; }
    }
}
