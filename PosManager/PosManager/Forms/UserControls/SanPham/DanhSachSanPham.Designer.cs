namespace PosManager.Forms.UserControls.SanPham
{
    partial class DanhSachSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new SplitContainer();
            btnThemSanPham = new PictureBox();
            panel1 = new Panel();
            txtSearchSanPham = new Helper.CustomControls.PlaceholderTextBox();
            LayoutMain = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)panelMain).BeginInit();
            panelMain.Panel1.SuspendLayout();
            panelMain.Panel2.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnThemSanPham).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.FixedPanel = FixedPanel.Panel1;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Orientation = Orientation.Horizontal;
            // 
            // panelMain.Panel1
            // 
            panelMain.Panel1.Controls.Add(btnThemSanPham);
            panelMain.Panel1.Controls.Add(panel1);
            panelMain.Panel1.Padding = new Padding(10, 10, 10, 2);
            // 
            // panelMain.Panel2
            // 
            panelMain.Panel2.Controls.Add(LayoutMain);
            panelMain.Panel2.Padding = new Padding(10);
            panelMain.Size = new Size(783, 525);
            panelMain.SplitterDistance = 59;
            panelMain.TabIndex = 0;
            panelMain.SplitterMoved += panelMain_SplitterMoved;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Dock = DockStyle.Left;
            btnThemSanPham.Image = Properties.Resources.icons8_add_40;
            btnThemSanPham.Location = new Point(333, 10);
            btnThemSanPham.MinimumSize = new Size(30, 30);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(30, 47);
            btnThemSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            btnThemSanPham.TabIndex = 46;
            btnThemSanPham.TabStop = false;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearchSanPham);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(323, 47);
            panel1.TabIndex = 0;
            // 
            // txtSearchSanPham
            // 
            txtSearchSanPham.Dock = DockStyle.Fill;
            txtSearchSanPham.ForeColor = Color.Gray;
            txtSearchSanPham.Location = new Point(5, 5);
            txtSearchSanPham.Name = "txtSearchSanPham";
            txtSearchSanPham.PlaceholderColor = Color.Gray;
            txtSearchSanPham.PlaceholderText = "Tìm Kiếm";
            txtSearchSanPham.Size = new Size(313, 36);
            txtSearchSanPham.StateCommon.Back.Color1 = Color.White;
            txtSearchSanPham.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtSearchSanPham.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtSearchSanPham.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearchSanPham.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearchSanPham.StateCommon.Border.Rounding = 18;
            txtSearchSanPham.StateCommon.Content.Color1 = Color.Black;
            txtSearchSanPham.StateCommon.Content.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSearchSanPham.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearchSanPham.TabIndex = 4;
            txtSearchSanPham.Text = "Tìm Kiếm";
            txtSearchSanPham.TextChanged += txtSearchSanPham_TextChanged;
            // 
            // LayoutMain
            // 
            LayoutMain.AutoScroll = true;
            LayoutMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LayoutMain.Dock = DockStyle.Fill;
            LayoutMain.Location = new Point(10, 10);
            LayoutMain.Name = "LayoutMain";
            LayoutMain.Padding = new Padding(7);
            LayoutMain.Size = new Size(763, 442);
            LayoutMain.TabIndex = 0;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "UserControl1";
            Size = new Size(783, 525);
            panelMain.Panel1.ResumeLayout(false);
            panelMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelMain).EndInit();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnThemSanPham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer panelMain;
        private Panel panel1;
        private Helper.CustomControls.PlaceholderTextBox txtSearchSanPham;
        private PictureBox btnThemSanPham;
        private FlowLayoutPanel LayoutMain;
    }
}
