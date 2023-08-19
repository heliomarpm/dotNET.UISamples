using System.Collections;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace Samples.UIControls
{
    [Designer(typeof(LineDesigner))]
    public partial class Line : UserControl
    {
        public enum ELineStyle
        {
            Line3D = 0,
            LineFlat = 1,
        }

        public Line()
        {
            InitializeComponent();
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }

        /// <summary>
        /// Performs the work of setting the specified bounds of this control.
        /// </summary>
        /// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left"/> property value of the control.</param>
        /// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top"/> property value of the control.</param>
        /// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width"/> property value of the control.</param>
        /// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height"/> property value of the control.</param>
        /// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified"/> values.</param>
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            int qtdLine = _lineStyle == ELineStyle.Line3D ? 2 : 1;
            if (!_isVertical)
                height = (_thickness * qtdLine) + 0;
            else
                width = (_thickness * qtdLine) + 0;

            base.SetBoundsCore(x, y, width, height, specified);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            bool line3D = _lineStyle == ELineStyle.Line3D;
            var lineColor = line3D ? Color.White : ForeColor;
            var posLine = line3D ? _thickness : 0;

            var sz = _isVertical ? Height / 2 : Width / 2;

            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);

            using var pen = new Pen(lineColor, _thickness);
            if (!_isVertical)
                e.Graphics.DrawLine(pen, -sz + Padding.Left, posLine, sz - Padding.Right, posLine);
            else
                e.Graphics.DrawLine(pen, posLine, -sz + Padding.Top, posLine, sz - Padding.Bottom);


            if (line3D)
            {
                using var pen2 = new Pen(SystemColors.ControlDark, _thickness);
                if (!_isVertical)
                    e.Graphics.DrawLine(pen2, -sz + Padding.Left, -1, sz - Padding.Right, -1);
                else
                    e.Graphics.DrawLine(pen2, -1, -sz + Padding.Top, -1, sz - Padding.Bottom);
            }

        }


        private ELineStyle _lineStyle = ELineStyle.Line3D;
        public new ELineStyle BorderStyle
        {
            get => _lineStyle;
            set
            {
                _lineStyle = value;
                this.Invalidate();
            }
        }

        private bool _isVertical;
        public bool Vertical
        {
            get => _isVertical;
            set
            {
                _isVertical = value;
                Invalidate();
            }
        }

        private int _thickness = 1;
        public int Thickness
        {
            get => _thickness;
            set
            {
                _thickness = value <= 0 ? 1 : value;
                if (Height < _thickness)
                    Height = _thickness;
                else
                    Invalidate();
            }
        }
    }

    internal class LineDesigner : ControlDesigner
    {
        /// <summary>
        /// Initializes a newly created component.
        /// </summary>
        /// <param name="defaultValues">A name/value dictionary of default values to apply to properties. May be null if no default values are specified.</param>
        public override void InitializeNewComponent(IDictionary defaultValues)
        {
            base.InitializeNewComponent(defaultValues);

            if (ParentComponent is Control control)
                Control.Width = control.ClientSize.Width;

            Control.Left = 0;
            Control.Height = 1;
        }

        /// <summary>
        /// Prevents resizing
        /// </summary>
        public override SelectionRules SelectionRules
        {
            get
            {
                return SelectionRules.LeftSizeable | SelectionRules.RightSizeable | SelectionRules.Moveable | SelectionRules.Visible;
            }
        }
    }
}
