using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SampleApplication
{
    public class Batch
    {
        public Image Icon { get; set; }
        public string BatchName { get; set; }
        public string JobName { get; set; }
        public int Documents { get; set; }
        public int Pages { get; set; }
        public string Status { get; set; }
    }
}
