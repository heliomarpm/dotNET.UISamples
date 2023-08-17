﻿using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Samples.UIForms.Controls
{
    class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            var grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);

            base.OnPaint(pevent);
        }
    }
}
