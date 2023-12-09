using ComponentFactory.Krypton.Toolkit;

namespace PosManager.Helper.CustomControls
{
    public class PlaceholderTextBox : KryptonTextBox
    {
        private string placeholderText = "Tìm kiếm";
        private Color placeholderColor = Color.Gray;

        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                Invalidate();
            }
        }

        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                Invalidate();
            }
        }

        public PlaceholderTextBox()
        {
            SetStyle(ControlStyles.UserPaint, true);
            ResetPlaceholder();
        }

        private void ResetPlaceholder()
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = PlaceholderText;
                ForeColor = PlaceholderColor;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(Text) && !Focused)
            {
                using (var brush = new SolidBrush(PlaceholderColor))
                {
                    e.Graphics.DrawString(PlaceholderText, Font, brush, new PointF(0, 0));
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (Text == PlaceholderText)
            {
                Text = "";
                ForeColor = SystemColors.ControlText;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            ResetPlaceholder();
        }
    }
}
