using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.UIForms
{
    public partial class uc_SmoothProgressBar : UserControl
    {
        public enum EBorderStyle
        {
            Border3D = 0,
            Flat = 1
        }

        public uc_SmoothProgressBar()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            // Invalidate the control to get a repaint.
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(_progressColor);
            float percent = (float)(_value - _min) / (float)(_max - _min);
            Rectangle rect = this.ClientRectangle;

            // Calculate area for drawing the progress.
            rect.Width = (int)((float)rect.Width * percent);

            // Draw the progress meter.
            g.FillRectangle(brush, rect);

            // Draw a three-dimensional border around the control.
            Draw3DBorder(g);

            // Clean up.
            brush.Dispose();
            g.Dispose();
        }

        private int _min = 0;// Minimum value for progress range
        public int Minimum
        {
            get { return _min; }
            set
            {
                // Prevent a negative value.
                if (value < 0) value = 0;

                // Make sure that the minimum value is never set higher than the maximum value.
                if (value > _max) _max = value;

                _min = value;

                // Ensure value is still in range
                if (_value < _min) _value = _min;

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        private int _max = 100;// Maximum value for progress range
        public int Maximum
        {
            get { return _max; }
            set
            {
                // Make sure that the maximum value is never set lower than the minimum value.
                if (value < _min) _min = value;

                _max = value;

                // Make sure that value is still in range.
                if (_value > _max) _value = _max;

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        private int _value = 0;// Current progress
        public int Value
        {
            get { return _value; }
            set
            {
                int oldValue = _value;

                // Make sure that the value does not stray outside the valid range.
                if (value < _min)
                {
                    _value = _min;
                }
                else if (value > _max)
                {
                    _value = _max;
                }
                else
                {
                    _value = value;
                }

                // Invalidate only the changed area.
                float percent;

                Rectangle newValueRect = this.ClientRectangle;
                Rectangle oldValueRect = this.ClientRectangle;

                // Use a new value to calculate the rectangle for progress.
                percent = (float)(_value - _min) / (float)(_max - _min);
                newValueRect.Width = (int)((float)newValueRect.Width * percent);

                // Use an old value to calculate the rectangle for progress.
                percent = (float)(oldValue - _min) / (float)(_max - _min);
                oldValueRect.Width = (int)((float)oldValueRect.Width * percent);

                Rectangle updateRect = new Rectangle();

                // Find only the part of the screen that must be updated.
                if (newValueRect.Width > oldValueRect.Width)
                {
                    updateRect.X = oldValueRect.Size.Width;
                    updateRect.Width = newValueRect.Width - oldValueRect.Width;
                }
                else
                {
                    updateRect.X = newValueRect.Size.Width;
                    updateRect.Width = oldValueRect.Width - newValueRect.Width;
                }

                updateRect.Height = this.Height;

                // Invalidate the intersection region only.
                this.Invalidate(updateRect);
            }
        }

        private Color _progressColor = Color.RoyalBlue;
        public Color ProgressBarColor
        {
            get { return _progressColor; }
            set
            {
                _progressColor = value;
                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        private Color _borderColor = Color.White;
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                if (_borderStyle == EBorderStyle.Flat)
                    this.Invalidate();
            }
        }

        private EBorderStyle _borderStyle = EBorderStyle.Border3D;
        public new EBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                this.Invalidate();
            }
        }

        private void Draw3DBorder(Graphics g)
        {
            var pen1 = Pens.White;
            var pen2 = Pens.DarkGray;

            if (_borderStyle == EBorderStyle.Flat)
            {
                pen1 = new (_borderColor);
                pen2 = new(_borderColor);
            }
            int PenWidth = (int)pen1.Width;

            g.DrawLine(pen2,
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Top),
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Top));
            g.DrawLine(pen2,
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Top),
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Height - PenWidth));
            g.DrawLine(pen1,
            new Point(this.ClientRectangle.Left, this.ClientRectangle.Height - PenWidth),
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Height - PenWidth));
            g.DrawLine(pen1,
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Top),
            new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Height - PenWidth));
        }
    }
}
