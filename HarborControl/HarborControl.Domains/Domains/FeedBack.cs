using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
   public class FeedBack
    {
        public bool Success { get; set; }
        public string message { get; set; }
        public Exception exception { get; set; }
    }
}
