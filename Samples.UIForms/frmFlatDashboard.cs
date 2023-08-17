using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Samples.UIForms
{
    public partial class frmFlatDashboard : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        private const int SW_RESTORE = 9;

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect, int nTopRect, int nRightRect, int nButtonRect,
        //    int nWidthEllipse, int nHeightEllipse
        //);

        public frmFlatDashboard()
        {
            InitializeComponent();

            //Aplica os cantos arredondados no formulario
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 8, 8));
        }

        private void NavMenuClick(object sender, EventArgs e)
        {
            var menu = sender as Button;
            pnlNav.Top = menu.Top;
            pnlNav.Height = menu.Height;
            pnlNav.Left = menu.Left;
            menu.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void NavMenuLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(24, 30, 51);
        }

        private void frmFlatDashboard_Load(object sender, EventArgs e)
        {
            NavMenuClick(btnDashboard, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnFormMax.Text = "ä";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnFormMax.Text = "å";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
