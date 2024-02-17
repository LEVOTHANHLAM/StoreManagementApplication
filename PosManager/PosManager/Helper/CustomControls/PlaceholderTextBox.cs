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
        public static void CreatTextBox(PlaceholderTextBox textBox)
        {
            // 
            // txtSearch
            // 
            textBox.ForeColor = Color.Gray;
            textBox.Location = new Point(3, 40);
            textBox.Name = "txtSearch";
            textBox.PlaceholderColor = Color.Gray;
            textBox.PlaceholderText = "Tìm Kiếm";
            textBox.Size = new Size(420, 36);
            textBox.StateCommon.Back.Color1 = Color.White;
            textBox.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            textBox.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            textBox.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            textBox.StateCommon.Border.Rounding = 18;
            textBox.StateCommon.Content.Color1 = Color.Black;
            textBox.StateCommon.Content.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            textBox.TabIndex = 3;
            textBox.Text = "Tìm Kiếm";
        }
    }
}
