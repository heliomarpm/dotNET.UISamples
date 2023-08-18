namespace Samples.UIControls
{
    public partial class Line : UserControl
    {
        public Line()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var sz = _isVertical ? Height / 2 : Width / 2;
            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);

            using (var pen = new Pen(ForeColor, _thckness))
            {
                if (!_isVertical)
                {
                    e.Graphics.DrawLine(pen, -sz + Padding.Left, 0, sz - Padding.Right, 0);
                }
                else
                {
                    e.Graphics.DrawLine(pen, 0, -sz + Padding.Top, 0, sz - Padding.Bottom);
                }
            }
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }

        //public new Color ForeColor { get; set; }

        private bool _isVertical;
        public bool isVertical
        {
            get => _isVertical;
            set
            {
                _isVertical = value;
                Invalidate();
            }
        }

        private int _thckness;
        public int Thickness
        {
            get => _thckness;
            set
            {
                _thckness = value;
                if (Height < _thckness)
                    Height = _thckness;
                else
                    Invalidate();
            }
        }
    }
}
