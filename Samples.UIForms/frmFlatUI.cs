namespace Samples.UIForms
{
    public partial class frmFlatUI : Form
    {
        public frmFlatUI()
        {
            InitializeComponent();
            hideSubmenus();
        }

        private void hideSubmenus()
        {
            pnlMediaSubmenu.Visible = false;
            pnlPlaylistSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
            else
            {
                hideSubmenus();
                subMenu.Visible = true;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlMediaSubmenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlPlaylistSubmenu);
        }


        private Form activeForm = null;
        private void openFormChild(Form childForm)
        {
            if (activeForm != null)
            {
                if (activeForm.Name == childForm.Name)
                    return;

                activeForm.Close();
            }


            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlChild.Controls.Clear();
            pnlChild.Controls.Add(childForm);
            pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFormChild(new frmMain());
            hideSubmenus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFormChild(new frmDark());
            hideSubmenus();
        }
    }
}
