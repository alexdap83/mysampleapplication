using DevExpress.XtraBars;

namespace SampleApplication
{
    public class CheckableBarButtonItem : BarButtonItem
    {
        public CheckableBarButtonItem()
        {
            
        }

        public override bool CanDown
        {
            get { return true; }
        }
    }
}