using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace VerticalMenu
{
    public partial class MenuItemWithSubItem : MenuItem, INotifyPropertyChanged
    {
        // Height of each button
        private int item_height = 40;
        // Number of buttons
        private int itemCount = 0;

        public MenuItemWithSubItem()
        {
            InitializeComponent();
            // Set the image on the right
            btnMenuItem.SetRightImage(Properties.Resources.unfold_more_24);
            btnMenuItem.Click += (s, e) =>
            {
                IsShowSubItems = !IsShowSubItems;
                if (!IsShowSubItems)
                {
                    Height = item_height;
                    btnMenuItem.SetRightImage(Properties.Resources.unfold_more_24);
                    btnMenuItem.Refresh();
                }
                else
                {
                    Height = item_height + item_height * itemCount;
                    btnMenuItem.SetRightImage(Properties.Resources.unfold_less_24);
                    btnMenuItem.Refresh();
                }
            };

            PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "Dock")
                {
                    ;
                }
            };
            // The submenu is not displayed by default
            IsShowSubItems = false;
            // Initialize control height
            Height = item_height;
        }

        /// <summary>
        /// Whether to display sub-panels
        /// </summary>
        public bool IsShowSubItems { get; set; }

        public override string Text
        {
            get { return btnMenuItem.Text; }
            set { btnMenuItem.Text = value; }
        }

        #region Implement the INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        /// <summary>
        /// Notify the design panel in time after the design pattern Dock changes
        /// </summary>
        public override DockStyle Dock { get { return base.Dock; } set { base.Dock = value; NotifyPropertyChanged("Dock"); } }
        /// <summary>
        /// Add button
        /// </summary>
        /// <param name="name"></param>
        /// <param name="a"></param>
        public void AddButton(string text, Bitmap leftImage, Action a)
        {
            var btn = new ImageButton();
            btn.Dock = DockStyle.Top;
            btn.Text = text;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Height = item_height;
            btn.Location = new System.Drawing.Point(0, 0);
            if (leftImage != null)
            {
                btn.SetLeftImage(leftImage);
            }
            btn.Tag = itemCount + 1;
            if (a != null)
            {
                btn.Click += (o, e) => a();
            }
            pnlContainer.Controls.Add(btn);
            var lst = new List<Button>();
            foreach (Control c in pnlContainer.Controls) lst.Add(c as Button);
            pnlContainer.Controls.Clear();
            var btns = lst.OrderByDescending(x => (int)x.Tag);
            foreach (Button c in btns) pnlContainer.Controls.Add(c);

            if (IsShowSubItems)
            {
                Height = item_height + item_height * itemCount;
            }
            itemCount++;
        }
        /// <summary>
        /// Set the left icon
        /// </summary>
        /// <param name="img"></param>
        public void SetLeftImage(Bitmap img) => btnMenuItem.SetLeftImage(img);

        public ImageButton HeaderImageButton { get { return btnMenuItem; } }

        public List<ImageButton> GetDetailImageButtons()
        {
            var lst = new List<ImageButton>();

            foreach (Control c in pnlContainer.Controls) lst.Add(c as ImageButton);

            return lst;
        }

    }
}
