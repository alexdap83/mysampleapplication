using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace SampleApplication
{
    public partial class MainForm
    {
        void SetChecked(BarButtonItem item, bool isChecked)
        {
            item.Down = isChecked;
        }
        bool IsChecked(BarButtonItem item)
        {
            return item.Down;

        }
        void SetVisible(RibbonPageGroup group, bool isVisible)
        {
            group.Visible = isVisible;
        }
        bool IsVisible(RibbonPageGroup group)
        {
            return group.Visible;
        }

        void SetSelectedPage(int pageIndex)
        {
            ribbon.SelectedPage = ribbon.Pages[pageIndex];
        }
    }
}
