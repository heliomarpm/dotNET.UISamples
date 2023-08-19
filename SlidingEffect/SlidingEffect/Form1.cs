using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SlidingEffect
{

    public partial class Form1 : Form
    {
        //Constants
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            //Load the Form At Position of Main Form
            int WidthOfMain = Application.OpenForms["MainForm"].Width;
            int HeightofMain = Application.OpenForms["MainForm"].Height;
            int LocationMainX = Application.OpenForms["MainForm"].Location.X;
            int locationMainy = Application.OpenForms["MainForm"].Location.Y;

            //Set the Location
            this.Location = new Point(LocationMainX + WidthOfMain, locationMainy + 10);

            //Animate form
            AnimateWindow(this.Handle, 500, AW_BLEND | AW_HOR_POSITIVE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
