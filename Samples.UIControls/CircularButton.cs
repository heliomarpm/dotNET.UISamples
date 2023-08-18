using System.Drawing.Drawing2D;

namespace Samples.UIControls
{
    public partial class CircularButton : Button
    {
        public CircularButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);

            base.OnPaint(e);
        }
    }
}
