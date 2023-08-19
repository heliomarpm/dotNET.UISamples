using System;
using System.Drawing;
using System.Windows.Forms;

namespace VerticalMenu
{
    public partial class MenuItemGeneral : MenuItem
    {
        // Button height
        private int item_height = 40;
        public MenuItemGeneral()
        {
            InitializeComponent();

            btnMenuItem.FlatStyle = FlatStyle.Flat;
            btnMenuItem.FlatAppearance.BorderSize = 0;
            btnMenuItem.Height = 40;
            btnMenuItem.Dock = DockStyle.Top;
            btnMenuItem.Location = new System.Drawing.Point(0, 0);
            Height = item_height;
        }
        /// <summary>
        /// Set button title
        /// </summary>
        /// 
        public override string Text
        {
            get { return btnMenuItem.Text; }
            set { btnMenuItem.Text = value; }
        }

        /// <summary>
        /// Set the left icon
        /// </summary>
        /// <param name="img"></param>
        public void SetLeftImage(Bitmap img) => btnMenuItem.SetLeftImage(img);
        public void SetButton(string text, Bitmap img, Action a)
        {
            Text = text;
            SetLeftImage(img);
            if (a != null)
            {
                btnMenuItem.Click += (o, e) => a();
            }
        }

        public ImageButton ImageButton { get; private set; }
    }
}
