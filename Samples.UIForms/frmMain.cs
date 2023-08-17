using System;
using System.Windows.Forms;

namespace Samples.UIForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x84:
        //            base.WndProc(ref m);
        //            if ((int)m.Result == 0x1)
        //                m.Result = (IntPtr)0x2;
        //            return;
        //    }
        //    base.WndProc(ref m);
        //}

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmFlatUI();
            frm.Show();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                WinAPI.Drag(this.Handle);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            //this.TopMost = true;

            //WinApi.AnimateWindows(this.Handle, 2000, WinApi.BLEND);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.LWin)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    this.Bounds = Screen.PrimaryScreen.Bounds;
                    this.TopMost = true;
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmFlatDashboard().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlertBox.ShowAlert("Alerta de sucesso", AlertType.Success);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AlertBox.ShowAlert("Alerta de Erro", AlertType.Error);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AlertBox.ShowAlert("Alerta de Informações", AlertType.Info);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AlertBox.ShowAlert("Alerta de Warning", AlertType.Warning);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
