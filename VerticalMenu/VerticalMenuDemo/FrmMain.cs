using System;
using System.Drawing;
using System.Windows.Forms;
using VerticalMenu;
namespace VerticalMenuDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //vMenu1.SetMenu(new[] { "Student attendance", "Classes begin", "Classroom question" });

            vMenu1.SetMenu(new VMenuItem[]
            {
                new VMenuItem{ Text = "Electronic whiteboard screen signal source", HasSubMenuItem = true, LeftImage = Properties.Resources.menu, Tag = "Source", SubItems = new []{
                    new VMenuItem{ Text = "Main control screen", HasSubMenuItem = false, LeftImage = null, ClickAction = ()=>{
                         // Add a Click response here
                        var mainScreen = vMenu1.GetButtonByText("Main control screen")[0];
                        var promptScreen = vMenu1.GetButtonByText("Prompt screen")[0];
                        mainScreen.SetLeftImage(Properties.Resources.ok);
                        promptScreen.SetLeftImage(null);
                        mainScreen.ForeColor = Color.White;
                        mainScreen.BackColor = Color.Green;
                        promptScreen.ForeColor = Color.Black;
                        promptScreen.BackColor = Color.White;

                    } },
                    new VMenuItem{ Text = "Prompt screen", HasSubMenuItem = false, LeftImage = null, ClickAction = ()=>{
                        // Add a Click response here
                        var mainScreen = vMenu1.GetButtonByText("Main control screen")[0];
                        var promptScreen = vMenu1.GetButtonByText("Prompt screen")[0];
                        mainScreen.SetLeftImage(null);
                        promptScreen.SetLeftImage(Properties.Resources.ok);
                        promptScreen.ForeColor = Color.White;
                        promptScreen.BackColor = Color.Green;
                        mainScreen.ForeColor = Color.Black;
                        mainScreen.BackColor = Color.White;
                    } },
                } },

                new VMenuItem{ Text = "Student attendance", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                     // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Classes begin", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                     // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Classroom question", HasSubMenuItem = true, LeftImage = Properties.Resources.menu, SubItems = new []{
                    new VMenuItem{ Text = "Sending a question", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                         // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Display problem", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                         // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Voice problem", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Classroom test", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // Add a Click response here
                        ;
                    } },
                } },
                new VMenuItem{ Text = "Preparation materials", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                     // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Receive upload", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                    // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Effectiveness analysis", HasSubMenuItem = true, LeftImage = Properties.Resources.menu, SubItems = new []{
                    new VMenuItem{ Text = "Question and answer analysis", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                         // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Test analysis", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                         // Add a Click response here
                        ;
                    } },
                } },
                new VMenuItem{ Text = "Class image", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                     // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Teaching assistant", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                     // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Voice control", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                     // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Collaborative teacher", HasSubMenuItem = false, LeftImage = Properties.Resources.Start, ClickAction = ()=>{
                     // Add a Click response here
                    ;
                } },
                new VMenuItem{ Text = "Prompt screen", HasSubMenuItem = true, LeftImage = Properties.Resources.menu, SubItems = new []{
                    new VMenuItem{ Text = "Student list", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                         // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Class image", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                         // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Question and answer analysis", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Test analysis", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // Add a Click response here
                        ;
                    } },
                    new VMenuItem{ Text = "Attendance statistics", HasSubMenuItem = false, LeftImage = Properties.Resources.analysis, ClickAction = ()=>{
                        // Add a Click response here
                        ;
                    } },
                } },
            });
        }
    }
}
