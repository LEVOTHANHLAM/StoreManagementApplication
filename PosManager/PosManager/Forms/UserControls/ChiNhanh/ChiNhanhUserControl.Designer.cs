using PosManager.Forms.UserControls.Kho;
using PosManager.Helper.CustomControls;

namespace PosManager.Forms.UserControls
{
    partial class ChiNhanhUserControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiNhanhUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            panel4 = new Panel();
            txtSearch = new PlaceholderTextBox();
            btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            cbbCuonTrang = new ComboBox();
            pDatagridView = new Panel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnQuayLaiTrang = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnTrang1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnTrang2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnTrang3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            btnTrangCuoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnTiepTucTrang = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            lbThongBaoSoTrang = new Label();
            dtgvAccount = new DataGridView();
            cChon = new DataGridViewCheckBoxColumn();
            cSTT = new DataGridViewTextBoxColumn();
            cMaCuaHang = new DataGridViewTextBoxColumn();
            cTenCuaHang = new DataGridViewTextBoxColumn();
            cMaKho = new DataGridViewTextBoxColumn();
            cTenKho = new DataGridViewTextBoxColumn();
            cEdit = new DataGridViewImageColumn();
            cId = new DataGridViewTextBoxColumn();
            ctmsAcc = new ContextMenuStrip(components);
            selectedToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            selectAllHighlightedToolStripMenuItem = new ToolStripMenuItem();
            deselectAllToolStripMenuItem = new ToolStripMenuItem();
            kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            pDatagridView.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            ctmsAcc.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pDatagridView);
            splitContainer1.Size = new Size(1334, 768);
            splitContainer1.SplitterDistance = 83;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(414, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 83);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(btnExport);
            panel4.Controls.Add(btnDelete);
            panel4.Location = new Point(488, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(429, 79);
            panel4.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(3, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderColor = Color.Gray;
            txtSearch.PlaceholderText = "Tìm Kiếm";
            txtSearch.Size = new Size(420, 36);
            txtSearch.StateCommon.Back.Color1 = Color.White;
            txtSearch.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtSearch.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtSearch.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearch.StateCommon.Border.Rounding = 18;
            txtSearch.StateCommon.Content.Color1 = Color.Black;
            txtSearch.StateCommon.Content.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "Tìm Kiếm";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(65, 3);
            btnExport.MaximumSize = new Size(133, 35);
            btnExport.MinimumSize = new Size(133, 35);
            btnExport.Name = "btnExport";
            btnExport.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExport.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExport.OverrideDefault.Back.ColorAngle = 45F;
            btnExport.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExport.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExport.OverrideDefault.Border.ColorAngle = 45F;
            btnExport.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExport.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExport.OverrideDefault.Border.Rounding = 18;
            btnExport.OverrideDefault.Border.Width = 1;
            btnExport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExport.Size = new Size(133, 35);
            btnExport.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExport.StateCommon.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExport.StateCommon.Back.ColorAngle = 45F;
            btnExport.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExport.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExport.StateCommon.Border.ColorAngle = 45F;
            btnExport.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExport.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExport.StateCommon.Border.Rounding = 18;
            btnExport.StateCommon.Border.Width = 1;
            btnExport.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExport.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExport.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.StatePressed.Back.Color1 = Color.FromArgb(21, 146, 197);
            btnExport.StatePressed.Back.Color2 = Color.FromArgb(22, 122, 206);
            btnExport.StatePressed.Back.ColorAngle = 130F;
            btnExport.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnExport.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnExport.StatePressed.Border.ColorAngle = 130F;
            btnExport.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExport.StatePressed.Border.Rounding = 18;
            btnExport.StatePressed.Border.Width = 1;
            btnExport.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExport.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExport.StateTracking.Back.ColorAngle = 45F;
            btnExport.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExport.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExport.StateTracking.Border.ColorAngle = 45F;
            btnExport.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExport.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExport.StateTracking.Border.Rounding = 18;
            btnExport.StateTracking.Border.Width = 1;
            btnExport.TabIndex = 9;
            btnExport.Values.Image = (Image)resources.GetObject("btnExport.Values.Image");
            btnExport.Values.Text = "Xuất File";
            btnExport.Click += btnExport_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(236, 3);
            btnDelete.MaximumSize = new Size(133, 35);
            btnDelete.MinimumSize = new Size(133, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.OverrideDefault.Back.Color1 = Color.FromArgb(255, 128, 128);
            btnDelete.OverrideDefault.Back.Color2 = Color.FromArgb(255, 128, 128);
            btnDelete.OverrideDefault.Back.ColorAngle = 45F;
            btnDelete.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnDelete.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnDelete.OverrideDefault.Border.ColorAngle = 45F;
            btnDelete.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete.OverrideDefault.Border.Rounding = 18;
            btnDelete.OverrideDefault.Border.Width = 1;
            btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnDelete.Size = new Size(133, 35);
            btnDelete.StateCommon.Back.Color1 = Color.FromArgb(255, 128, 128);
            btnDelete.StateCommon.Back.Color2 = Color.FromArgb(255, 128, 128);
            btnDelete.StateCommon.Back.ColorAngle = 45F;
            btnDelete.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnDelete.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnDelete.StateCommon.Border.ColorAngle = 45F;
            btnDelete.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete.StateCommon.Border.Rounding = 18;
            btnDelete.StateCommon.Border.Width = 1;
            btnDelete.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDelete.StateCommon.Content.ShortText.Color2 = Color.White;
            btnDelete.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.StatePressed.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnDelete.StatePressed.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnDelete.StatePressed.Back.ColorAngle = 130F;
            btnDelete.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnDelete.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnDelete.StatePressed.Border.ColorAngle = 130F;
            btnDelete.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StatePressed.Border.Rounding = 18;
            btnDelete.StatePressed.Border.Width = 1;
            btnDelete.StateTracking.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnDelete.StateTracking.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnDelete.StateTracking.Back.ColorAngle = 45F;
            btnDelete.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnDelete.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnDelete.StateTracking.Border.ColorAngle = 45F;
            btnDelete.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete.StateTracking.Border.Rounding = 18;
            btnDelete.StateTracking.Border.Width = 1;
            btnDelete.TabIndex = 10;
            btnDelete.Values.Image = (Image)resources.GetObject("btnDelete.Values.Image");
            btnDelete.Values.Text = "Xoá";
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cbbCuonTrang);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 83);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 64);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 25;
            label2.Text = "Mục";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 64);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 17;
            label1.Text = "Hiển Thị";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 10);
            btnAdd.MaximumSize = new Size(133, 35);
            btnAdd.MinimumSize = new Size(133, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnAdd.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAdd.OverrideDefault.Back.ColorAngle = 45F;
            btnAdd.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdd.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdd.OverrideDefault.Border.ColorAngle = 45F;
            btnAdd.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd.OverrideDefault.Border.Rounding = 18;
            btnAdd.OverrideDefault.Border.Width = 1;
            btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAdd.Size = new Size(133, 35);
            btnAdd.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnAdd.StateCommon.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAdd.StateCommon.Back.ColorAngle = 45F;
            btnAdd.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdd.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdd.StateCommon.Border.ColorAngle = 45F;
            btnAdd.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd.StateCommon.Border.Rounding = 18;
            btnAdd.StateCommon.Border.Width = 1;
            btnAdd.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAdd.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAdd.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.StatePressed.Back.Color1 = Color.FromArgb(21, 146, 197);
            btnAdd.StatePressed.Back.Color2 = Color.FromArgb(22, 122, 206);
            btnAdd.StatePressed.Back.ColorAngle = 130F;
            btnAdd.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnAdd.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnAdd.StatePressed.Border.ColorAngle = 130F;
            btnAdd.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.StatePressed.Border.Rounding = 18;
            btnAdd.StatePressed.Border.Width = 1;
            btnAdd.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnAdd.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAdd.StateTracking.Back.ColorAngle = 45F;
            btnAdd.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdd.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdd.StateTracking.Border.ColorAngle = 45F;
            btnAdd.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdd.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdd.StateTracking.Border.Rounding = 18;
            btnAdd.StateTracking.Border.Width = 1;
            btnAdd.TabIndex = 8;
            btnAdd.Values.Image = (Image)resources.GetObject("btnAdd.Values.Image");
            btnAdd.Values.Text = " Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // cbbCuonTrang
            // 
            cbbCuonTrang.DisplayMember = "DisplayText";
            cbbCuonTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCuonTrang.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbbCuonTrang.FormattingEnabled = true;
            cbbCuonTrang.Items.AddRange(new object[] { "10", "20", "50", "100" });
            cbbCuonTrang.Location = new Point(58, 56);
            cbbCuonTrang.Name = "cbbCuonTrang";
            cbbCuonTrang.Size = new Size(54, 24);
            cbbCuonTrang.TabIndex = 24;
            cbbCuonTrang.ValueMember = "Value";
            cbbCuonTrang.SelectedIndexChanged += cbbCuonTrang_SelectedIndexChanged;
            // 
            // pDatagridView
            // 
            pDatagridView.Controls.Add(panel3);
            pDatagridView.Controls.Add(dtgvAccount);
            pDatagridView.Dock = DockStyle.Fill;
            pDatagridView.Location = new Point(0, 0);
            pDatagridView.Name = "pDatagridView";
            pDatagridView.Size = new Size(1334, 681);
            pDatagridView.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(lbThongBaoSoTrang);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 639);
            panel3.Name = "panel3";
            panel3.Size = new Size(1334, 42);
            panel3.TabIndex = 16;
            panel3.Paint += panel3_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnQuayLaiTrang);
            flowLayoutPanel1.Controls.Add(btnTrang1);
            flowLayoutPanel1.Controls.Add(btnTrang2);
            flowLayoutPanel1.Controls.Add(btnTrang3);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(btnTrangCuoi);
            flowLayoutPanel1.Controls.Add(btnTiepTucTrang);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(967, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(367, 42);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // btnQuayLaiTrang
            // 
            btnQuayLaiTrang.Enabled = false;
            btnQuayLaiTrang.Location = new Point(3, 3);
            btnQuayLaiTrang.Name = "btnQuayLaiTrang";
            btnQuayLaiTrang.OverrideDefault.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.OverrideDefault.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.OverrideDefault.Back.ColorAngle = 45F;
            btnQuayLaiTrang.OverrideDefault.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.OverrideDefault.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.OverrideDefault.Border.ColorAngle = 45F;
            btnQuayLaiTrang.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnQuayLaiTrang.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnQuayLaiTrang.OverrideDefault.Border.Rounding = 18;
            btnQuayLaiTrang.OverrideDefault.Border.Width = 1;
            btnQuayLaiTrang.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnQuayLaiTrang.Size = new Size(46, 35);
            btnQuayLaiTrang.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.StateCommon.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.StateCommon.Back.ColorAngle = 45F;
            btnQuayLaiTrang.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.StateCommon.Border.ColorAngle = 45F;
            btnQuayLaiTrang.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnQuayLaiTrang.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnQuayLaiTrang.StateCommon.Border.Rounding = 18;
            btnQuayLaiTrang.StateCommon.Border.Width = 1;
            btnQuayLaiTrang.StateCommon.Content.ShortText.Color1 = Color.White;
            btnQuayLaiTrang.StateCommon.Content.ShortText.Color2 = Color.White;
            btnQuayLaiTrang.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuayLaiTrang.StatePressed.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnQuayLaiTrang.StatePressed.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnQuayLaiTrang.StatePressed.Back.ColorAngle = 130F;
            btnQuayLaiTrang.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnQuayLaiTrang.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnQuayLaiTrang.StatePressed.Border.ColorAngle = 130F;
            btnQuayLaiTrang.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnQuayLaiTrang.StatePressed.Border.Rounding = 18;
            btnQuayLaiTrang.StatePressed.Border.Width = 1;
            btnQuayLaiTrang.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnQuayLaiTrang.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnQuayLaiTrang.StateTracking.Back.ColorAngle = 45F;
            btnQuayLaiTrang.StateTracking.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.StateTracking.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnQuayLaiTrang.StateTracking.Border.ColorAngle = 45F;
            btnQuayLaiTrang.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnQuayLaiTrang.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnQuayLaiTrang.StateTracking.Border.Rounding = 18;
            btnQuayLaiTrang.StateTracking.Border.Width = 1;
            btnQuayLaiTrang.TabIndex = 10;
            btnQuayLaiTrang.Values.Text = "<";
            btnQuayLaiTrang.Click += btnQuayLaiTrang_Click;
            // 
            // btnTrang1
            // 
            btnTrang1.Enabled = false;
            btnTrang1.Location = new Point(55, 3);
            btnTrang1.Name = "btnTrang1";
            btnTrang1.OverrideDefault.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang1.OverrideDefault.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang1.OverrideDefault.Back.ColorAngle = 45F;
            btnTrang1.OverrideDefault.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang1.OverrideDefault.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang1.OverrideDefault.Border.ColorAngle = 45F;
            btnTrang1.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang1.OverrideDefault.Border.Rounding = 18;
            btnTrang1.OverrideDefault.Border.Width = 1;
            btnTrang1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTrang1.Size = new Size(36, 35);
            btnTrang1.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang1.StateCommon.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang1.StateCommon.Back.ColorAngle = 45F;
            btnTrang1.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang1.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang1.StateCommon.Border.ColorAngle = 45F;
            btnTrang1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang1.StateCommon.Border.Rounding = 18;
            btnTrang1.StateCommon.Border.Width = 1;
            btnTrang1.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTrang1.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTrang1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrang1.StatePressed.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang1.StatePressed.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrang1.StatePressed.Back.ColorAngle = 130F;
            btnTrang1.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnTrang1.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnTrang1.StatePressed.Border.ColorAngle = 130F;
            btnTrang1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang1.StatePressed.Border.Rounding = 18;
            btnTrang1.StatePressed.Border.Width = 1;
            btnTrang1.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang1.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrang1.StateTracking.Back.ColorAngle = 45F;
            btnTrang1.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang1.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnTrang1.StateTracking.Border.ColorAngle = 45F;
            btnTrang1.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang1.StateTracking.Border.Rounding = 18;
            btnTrang1.StateTracking.Border.Width = 1;
            btnTrang1.TabIndex = 11;
            btnTrang1.Values.Text = "1";
            btnTrang1.Click += btnTrang1_Click;
            // 
            // btnTrang2
            // 
            btnTrang2.Location = new Point(97, 3);
            btnTrang2.Name = "btnTrang2";
            btnTrang2.OverrideDefault.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang2.OverrideDefault.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang2.OverrideDefault.Back.ColorAngle = 45F;
            btnTrang2.OverrideDefault.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang2.OverrideDefault.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang2.OverrideDefault.Border.ColorAngle = 45F;
            btnTrang2.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang2.OverrideDefault.Border.Rounding = 18;
            btnTrang2.OverrideDefault.Border.Width = 1;
            btnTrang2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTrang2.Size = new Size(36, 35);
            btnTrang2.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang2.StateCommon.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang2.StateCommon.Back.ColorAngle = 45F;
            btnTrang2.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang2.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang2.StateCommon.Border.ColorAngle = 45F;
            btnTrang2.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang2.StateCommon.Border.Rounding = 18;
            btnTrang2.StateCommon.Border.Width = 1;
            btnTrang2.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTrang2.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTrang2.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrang2.StatePressed.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang2.StatePressed.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrang2.StatePressed.Back.ColorAngle = 130F;
            btnTrang2.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnTrang2.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnTrang2.StatePressed.Border.ColorAngle = 130F;
            btnTrang2.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang2.StatePressed.Border.Rounding = 18;
            btnTrang2.StatePressed.Border.Width = 1;
            btnTrang2.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang2.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrang2.StateTracking.Back.ColorAngle = 45F;
            btnTrang2.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang2.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnTrang2.StateTracking.Border.ColorAngle = 45F;
            btnTrang2.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang2.StateTracking.Border.Rounding = 18;
            btnTrang2.StateTracking.Border.Width = 1;
            btnTrang2.TabIndex = 12;
            btnTrang2.Values.Text = "2";
            btnTrang2.Visible = false;
            btnTrang2.Click += btnTrang2_Click;
            // 
            // btnTrang3
            // 
            btnTrang3.Location = new Point(139, 3);
            btnTrang3.Name = "btnTrang3";
            btnTrang3.OverrideDefault.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang3.OverrideDefault.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang3.OverrideDefault.Back.ColorAngle = 45F;
            btnTrang3.OverrideDefault.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang3.OverrideDefault.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang3.OverrideDefault.Border.ColorAngle = 45F;
            btnTrang3.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang3.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang3.OverrideDefault.Border.Rounding = 18;
            btnTrang3.OverrideDefault.Border.Width = 1;
            btnTrang3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTrang3.Size = new Size(39, 35);
            btnTrang3.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang3.StateCommon.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang3.StateCommon.Back.ColorAngle = 45F;
            btnTrang3.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrang3.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrang3.StateCommon.Border.ColorAngle = 45F;
            btnTrang3.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang3.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang3.StateCommon.Border.Rounding = 18;
            btnTrang3.StateCommon.Border.Width = 1;
            btnTrang3.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTrang3.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTrang3.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrang3.StatePressed.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang3.StatePressed.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrang3.StatePressed.Back.ColorAngle = 130F;
            btnTrang3.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnTrang3.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnTrang3.StatePressed.Border.ColorAngle = 130F;
            btnTrang3.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang3.StatePressed.Border.Rounding = 18;
            btnTrang3.StatePressed.Border.Width = 1;
            btnTrang3.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang3.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrang3.StateTracking.Back.ColorAngle = 45F;
            btnTrang3.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnTrang3.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnTrang3.StateTracking.Border.ColorAngle = 45F;
            btnTrang3.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrang3.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrang3.StateTracking.Border.Rounding = 18;
            btnTrang3.StateTracking.Border.Width = 1;
            btnTrang3.TabIndex = 13;
            btnTrang3.Values.Text = "3";
            btnTrang3.Visible = false;
            btnTrang3.Click += btnTrang3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(184, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 36);
            label3.TabIndex = 18;
            label3.Text = "...";
            label3.Visible = false;
            // 
            // btnTrangCuoi
            // 
            btnTrangCuoi.Location = new Point(229, 3);
            btnTrangCuoi.Name = "btnTrangCuoi";
            btnTrangCuoi.OverrideDefault.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrangCuoi.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnTrangCuoi.OverrideDefault.Back.ColorAngle = 45F;
            btnTrangCuoi.OverrideDefault.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrangCuoi.OverrideDefault.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrangCuoi.OverrideDefault.Border.ColorAngle = 45F;
            btnTrangCuoi.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrangCuoi.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrangCuoi.OverrideDefault.Border.Rounding = 18;
            btnTrangCuoi.OverrideDefault.Border.Width = 1;
            btnTrangCuoi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTrangCuoi.Size = new Size(40, 35);
            btnTrangCuoi.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTrangCuoi.StateCommon.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTrangCuoi.StateCommon.Back.ColorAngle = 45F;
            btnTrangCuoi.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTrangCuoi.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTrangCuoi.StateCommon.Border.ColorAngle = 45F;
            btnTrangCuoi.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrangCuoi.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrangCuoi.StateCommon.Border.Rounding = 18;
            btnTrangCuoi.StateCommon.Border.Width = 1;
            btnTrangCuoi.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTrangCuoi.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTrangCuoi.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrangCuoi.StatePressed.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrangCuoi.StatePressed.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrangCuoi.StatePressed.Back.ColorAngle = 130F;
            btnTrangCuoi.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnTrangCuoi.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnTrangCuoi.StatePressed.Border.ColorAngle = 130F;
            btnTrangCuoi.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrangCuoi.StatePressed.Border.Rounding = 18;
            btnTrangCuoi.StatePressed.Border.Width = 1;
            btnTrangCuoi.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTrangCuoi.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTrangCuoi.StateTracking.Back.ColorAngle = 45F;
            btnTrangCuoi.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnTrangCuoi.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnTrangCuoi.StateTracking.Border.ColorAngle = 45F;
            btnTrangCuoi.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTrangCuoi.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTrangCuoi.StateTracking.Border.Rounding = 18;
            btnTrangCuoi.StateTracking.Border.Width = 1;
            btnTrangCuoi.TabIndex = 19;
            btnTrangCuoi.Values.Text = "10";
            btnTrangCuoi.Visible = false;
            btnTrangCuoi.Click += btnTrangCuoi_Click;
            // 
            // btnTiepTucTrang
            // 
            btnTiepTucTrang.Enabled = false;
            btnTiepTucTrang.Location = new Point(275, 3);
            btnTiepTucTrang.Name = "btnTiepTucTrang";
            btnTiepTucTrang.OverrideDefault.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.OverrideDefault.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.OverrideDefault.Back.ColorAngle = 45F;
            btnTiepTucTrang.OverrideDefault.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.OverrideDefault.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.OverrideDefault.Border.ColorAngle = 45F;
            btnTiepTucTrang.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTiepTucTrang.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTiepTucTrang.OverrideDefault.Border.Rounding = 18;
            btnTiepTucTrang.OverrideDefault.Border.Width = 1;
            btnTiepTucTrang.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnTiepTucTrang.Size = new Size(42, 35);
            btnTiepTucTrang.StateCommon.Back.Color1 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.StateCommon.Back.Color2 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.StateCommon.Back.ColorAngle = 45F;
            btnTiepTucTrang.StateCommon.Border.Color1 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.StateCommon.Border.Color2 = Color.FromArgb(64, 64, 64);
            btnTiepTucTrang.StateCommon.Border.ColorAngle = 45F;
            btnTiepTucTrang.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTiepTucTrang.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTiepTucTrang.StateCommon.Border.Rounding = 18;
            btnTiepTucTrang.StateCommon.Border.Width = 1;
            btnTiepTucTrang.StateCommon.Content.ShortText.Color1 = Color.White;
            btnTiepTucTrang.StateCommon.Content.ShortText.Color2 = Color.White;
            btnTiepTucTrang.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTiepTucTrang.StatePressed.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTiepTucTrang.StatePressed.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTiepTucTrang.StatePressed.Back.ColorAngle = 130F;
            btnTiepTucTrang.StatePressed.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnTiepTucTrang.StatePressed.Border.Color2 = Color.FromArgb(6, 174, 244);
            btnTiepTucTrang.StatePressed.Border.ColorAngle = 130F;
            btnTiepTucTrang.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTiepTucTrang.StatePressed.Border.Rounding = 18;
            btnTiepTucTrang.StatePressed.Border.Width = 1;
            btnTiepTucTrang.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnTiepTucTrang.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnTiepTucTrang.StateTracking.Back.ColorAngle = 45F;
            btnTiepTucTrang.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnTiepTucTrang.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnTiepTucTrang.StateTracking.Border.ColorAngle = 45F;
            btnTiepTucTrang.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTiepTucTrang.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnTiepTucTrang.StateTracking.Border.Rounding = 18;
            btnTiepTucTrang.StateTracking.Border.Width = 1;
            btnTiepTucTrang.TabIndex = 20;
            btnTiepTucTrang.Values.Text = ">";
            btnTiepTucTrang.Click += btnTiepTucTrang_Click;
            // 
            // lbThongBaoSoTrang
            // 
            lbThongBaoSoTrang.AutoSize = true;
            lbThongBaoSoTrang.Dock = DockStyle.Left;
            lbThongBaoSoTrang.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbThongBaoSoTrang.Location = new Point(0, 0);
            lbThongBaoSoTrang.Name = "lbThongBaoSoTrang";
            lbThongBaoSoTrang.Size = new Size(326, 21);
            lbThongBaoSoTrang.TabIndex = 18;
            lbThongBaoSoTrang.Text = " Hiển thị từ 1 đến 10 trong tổng số 10 mục";
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AllowUserToResizeRows = false;
            dtgvAccount.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { cChon, cSTT, cMaCuaHang, cTenCuaHang, cMaKho, cTenKho, cEdit, cId });
            dtgvAccount.ContextMenuStrip = ctmsAcc;
            dtgvAccount.Dock = DockStyle.Fill;
            dtgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvAccount.Location = new Point(0, 0);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.RowTemplate.Height = 25;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(1334, 681);
            dtgvAccount.TabIndex = 15;
            dtgvAccount.CellClick += dtgvAccount_CellClick;
            dtgvAccount.CellContentClick += dtgvAccount_CellContentClick;
            dtgvAccount.CellDoubleClick += dtgvAccount_CellDoubleClick;
            // 
            // cChon
            // 
            cChon.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cChon.FillWeight = 50F;
            cChon.HeaderText = "Chọn";
            cChon.Name = "cChon";
            cChon.Width = 50;
            // 
            // cSTT
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cSTT.DefaultCellStyle = dataGridViewCellStyle2;
            cSTT.HeaderText = "STT";
            cSTT.Name = "cSTT";
            cSTT.ReadOnly = true;
            cSTT.Width = 51;
            // 
            // cMaCuaHang
            // 
            cMaCuaHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cMaCuaHang.HeaderText = "Mã Cửa Hàng";
            cMaCuaHang.Name = "cMaCuaHang";
            // 
            // cTenCuaHang
            // 
            cTenCuaHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cTenCuaHang.DefaultCellStyle = dataGridViewCellStyle3;
            cTenCuaHang.HeaderText = "Tên Cửa Hàng";
            cTenCuaHang.Name = "cTenCuaHang";
            // 
            // cMaKho
            // 
            cMaKho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cMaKho.HeaderText = "Mã Kho";
            cMaKho.Name = "cMaKho";
            // 
            // cTenKho
            // 
            cTenKho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cTenKho.HeaderText = "Tên Kho";
            cTenKho.Name = "cTenKho";
            // 
            // cEdit
            // 
            cEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cEdit.HeaderText = "Sửa";
            cEdit.Name = "cEdit";
            cEdit.Resizable = DataGridViewTriState.True;
            cEdit.Width = 120;
            // 
            // cId
            // 
            cId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cId.HeaderText = "cId";
            cId.Name = "cId";
            cId.ReadOnly = true;
            cId.Visible = false;
            // 
            // ctmsAcc
            // 
            ctmsAcc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ctmsAcc.Items.AddRange(new ToolStripItem[] { selectedToolStripMenuItem, deselectAllToolStripMenuItem });
            ctmsAcc.Name = "contextMenuStrip1";
            ctmsAcc.Size = new Size(134, 48);
            // 
            // selectedToolStripMenuItem
            // 
            selectedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectAllToolStripMenuItem, selectAllHighlightedToolStripMenuItem });
            selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            selectedToolStripMenuItem.Size = new Size(133, 22);
            selectedToolStripMenuItem.Text = "Selected";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(184, 22);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // selectAllHighlightedToolStripMenuItem
            // 
            selectAllHighlightedToolStripMenuItem.Name = "selectAllHighlightedToolStripMenuItem";
            selectAllHighlightedToolStripMenuItem.Size = new Size(184, 22);
            selectAllHighlightedToolStripMenuItem.Text = "Select all highlighted";
            selectAllHighlightedToolStripMenuItem.Click += selectAllHighlightedToolStripMenuItem_Click;
            // 
            // deselectAllToolStripMenuItem
            // 
            deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            deselectAllToolStripMenuItem.Size = new Size(133, 22);
            deselectAllToolStripMenuItem.Text = "Deselect all";
            deselectAllToolStripMenuItem.Click += deselectAllToolStripMenuItem_Click;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(0, 0);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(100, 23);
            kryptonTextBox1.TabIndex = 0;
            // 
            // ChiNhanhUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1334, 768);
            Name = "ChiNhanhUserControl";
            Size = new Size(1334, 768);
            Load += ChiNhanhUserControl_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pDatagridView.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ctmsAcc.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pDatagridView;
        private Panel panel1;
        private PlaceholderTextBox txtSearch;
        private Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private DataGridView dtgvAccount;
        private ContextMenuStrip ctmsAcc;
        private ToolStripMenuItem selectedToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem selectAllHighlightedToolStripMenuItem;
        private ToolStripMenuItem deselectAllToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Panel panel3;
        private Label label1;
        private ComboBox cbbCuonTrang;
        private Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnQuayLaiTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTrang1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTrang2;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTrang3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTiepTucTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTrangCuoi;
        private Label lbThongBaoSoTrang;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private DataGridViewCheckBoxColumn cChon;
        private DataGridViewTextBoxColumn cSTT;
        private DataGridViewTextBoxColumn cMaCuaHang;
        private DataGridViewTextBoxColumn cTenCuaHang;
        private DataGridViewTextBoxColumn cMaKho;
        private DataGridViewTextBoxColumn cTenKho;
        private DataGridViewImageColumn cEdit;
        private DataGridViewTextBoxColumn cId;
    }
}
