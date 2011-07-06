using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SampleApplication
{
    public class Batch
    {
        public int Icon { get; set; }
        public string BatchName { get; set; }
        public string JobName { get; set; }
        public int Documents { get; set; }
        public int Pages { get; set; }
        public string Status { get; set; }
    }
    public class Performance
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }
    
}
