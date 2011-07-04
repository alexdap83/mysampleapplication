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
        bool IsChecked(BarItem item)
        {
            if(item is BarButtonItem)
                return ((BarButtonItem)item).Down;
            return false;
        }

        void SetEnable(BarButtonItem item, bool isEnable)
        {
            item.Enabled = isEnable;
        }
        bool IsEnable(BarButtonItem item)
        {
            return item.Down;

        }

        private void SetChecked(BarCheckItem item, bool isChecked)
        {
            item.Checked = isChecked;
        }

        void SetVisible(RibbonPageGroup group, bool isVisible)
        {
            group.Visible = isVisible;
        }
        void SetVisible(BarButtonItem item, bool isVisible)
        {
            item.Visibility = isVisible ? BarItemVisibility.Always : BarItemVisibility.Never;
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
