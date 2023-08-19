using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VerticalMenu
{
    public partial class VMenu : UserControl
    {
        public VMenu()
        {
            InitializeComponent();

        }

        public void SetMenu(VMenuItem[] menuItems)
        {
            var pnl = this;
            var lst = new List<MenuItem>();
            var index = 0;
            foreach (var item in menuItems)
            {
                if (!item.HasSubMenuItem)
                {
                    var mi = new MenuItemGeneral();
                    mi.Dock = DockStyle.Top;
                    mi.SetButton(item.Text, item.LeftImage, item.ClickAction);
                    mi.Tag = index;
                    lst.Add(mi);
                }
                else
                {
                    // Regular foldable button item
                    var mi = new MenuItemWithSubItem();
                    mi.Dock = DockStyle.Top;
                    mi.Text = item.Text;
                    if (item.LeftImage != null)
                    {
                        mi.SetLeftImage(item.LeftImage);
                    }
                    mi.Tag = index;
                    lst.Add(mi);
                    foreach (var m in item.SubItems)
                    {
                        mi.AddButton(m.Text, m.LeftImage, m.ClickAction);
                    }
                }

                index++;
            }
            var vmis = lst.OrderByDescending(x => (int)x.Tag);
            foreach (var c in vmis) pnl.Controls.Add(c);

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public List<ImageButton> GetButtonByText(string text)
        {
            var pnl = this;
            var lst = new List<ImageButton>();
            foreach (var c in pnl.Controls)
            {
                var menuItem = c as MenuItem;
                if (menuItem != null)
                {
                    if (menuItem is MenuItemGeneral)
                    {
                        if (menuItem.Text == text)
                        {
                            var mi = menuItem as MenuItemGeneral;
                            lst.Add(mi.ImageButton);
                        }
                    }
                    else if (menuItem is MenuItemWithSubItem)
                    {
                        if (menuItem.Text == text)
                        {
                            lst.Add((menuItem as MenuItemWithSubItem).HeaderImageButton);
                        }
                        var mi = menuItem as MenuItemWithSubItem;
                        foreach (var sub in mi.GetDetailImageButtons())
                        {
                            if (sub.Text == text)
                            {
                                lst.Add(sub);
                            }
                        }
                    }
                }
            }

            return lst;
        }
    }

    public class VMenuItem
    {
        /// <summary>
        /// Button title
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Button action
        /// </summary>
        public Action ClickAction { get; set; }
        /// <summary>
        /// Left icon
        /// </summary>
        public Bitmap LeftImage { get; set; }
        /// <summary>
        /// Right side icon
        /// </summary>
        public Bitmap RightImage { get; set; }
        /// <summary>
        /// Whether to include submenu items
        /// </summary>
        public bool HasSubMenuItem { get; set; }
        /// <summary>
        /// Tag mark
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// Submenu item
        /// </summary>
        public IEnumerable<VMenuItem> SubItems { get; set; }
    }
}
