using PosManager.Helper.CustomControls;

namespace PosManager.Forms.UserControls.KhachHang
{
    partial class NhaCungCapUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCapUserControl));
            txtSearch = new PlaceholderTextBox();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            pDatagridView = new Panel();
            dtgvAccount = new DataGridView();
            ctmsAcc = new ContextMenuStrip(components);
            selectedToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            selectAllHighlightedToolStripMenuItem = new ToolStripMenuItem();
            deselectAllToolStripMenuItem = new ToolStripMenuItem();
            kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            cChon = new DataGridViewCheckBoxColumn();
            cSTT = new DataGridViewTextBoxColumn();
            cId = new DataGridViewTextBoxColumn();
            cTen = new DataGridViewTextBoxColumn();
            cDiaChi = new DataGridViewTextBoxColumn();
            cSoDienThoai = new DataGridViewTextBoxColumn();
            cDate = new DataGridViewTextBoxColumn();
            cEdit = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pDatagridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            ctmsAcc.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(9, 8);
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
            splitContainer1.SplitterDistance = 57;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(574, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 57);
            panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(494, 11);
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
            btnDelete.Size = new Size(191, 35);
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
            btnDelete.StatePressed.Back.Color1 = Color.FromArgb(21, 146, 197);
            btnDelete.StatePressed.Back.Color2 = Color.FromArgb(22, 122, 206);
            btnDelete.StatePressed.Back.ColorAngle = 130F;
            btnDelete.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnDelete.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnDelete.StatePressed.Border.ColorAngle = 130F;
            btnDelete.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StatePressed.Border.Rounding = 18;
            btnDelete.StatePressed.Border.Width = 1;
            btnDelete.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnDelete.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnDelete.StateTracking.Back.ColorAngle = 45F;
            btnDelete.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnDelete.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnDelete.StateTracking.Border.ColorAngle = 45F;
            btnDelete.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDelete.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnDelete.StateTracking.Border.Rounding = 18;
            btnDelete.StateTracking.Border.Width = 1;
            btnDelete.TabIndex = 10;
            btnDelete.Values.Text = "Xoá";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(263, 11);
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
            btnExport.Size = new Size(191, 35);
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
            btnExport.Values.Text = "Xuất File";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 11);
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
            btnAdd.Size = new Size(191, 35);
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
            btnAdd.Values.Text = " Thêm Nhà Cung Cấp";
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 57);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(435, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSearch.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSearch.OverrideDefault.Back.ColorAngle = 45F;
            btnSearch.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSearch.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSearch.OverrideDefault.Border.ColorAngle = 45F;
            btnSearch.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSearch.OverrideDefault.Border.Rounding = 18;
            btnSearch.OverrideDefault.Border.Width = 1;
            btnSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSearch.Size = new Size(133, 35);
            btnSearch.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSearch.StateCommon.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSearch.StateCommon.Back.ColorAngle = 45F;
            btnSearch.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSearch.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSearch.StateCommon.Border.ColorAngle = 45F;
            btnSearch.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSearch.StateCommon.Border.Rounding = 18;
            btnSearch.StateCommon.Border.Width = 1;
            btnSearch.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSearch.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSearch.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.StatePressed.Back.Color1 = Color.FromArgb(21, 146, 197);
            btnSearch.StatePressed.Back.Color2 = Color.FromArgb(22, 122, 206);
            btnSearch.StatePressed.Back.ColorAngle = 130F;
            btnSearch.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnSearch.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnSearch.StatePressed.Border.ColorAngle = 130F;
            btnSearch.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StatePressed.Border.Rounding = 18;
            btnSearch.StatePressed.Border.Width = 1;
            btnSearch.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSearch.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSearch.StateTracking.Back.ColorAngle = 45F;
            btnSearch.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSearch.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSearch.StateTracking.Border.ColorAngle = 45F;
            btnSearch.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSearch.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSearch.StateTracking.Border.Rounding = 18;
            btnSearch.StateTracking.Border.Width = 1;
            btnSearch.TabIndex = 7;
            btnSearch.Values.Text = "Tìm Kiếm";
            // 
            // pDatagridView
            // 
            pDatagridView.Controls.Add(dtgvAccount);
            pDatagridView.Dock = DockStyle.Fill;
            pDatagridView.Location = new Point(0, 0);
            pDatagridView.Name = "pDatagridView";
            pDatagridView.Size = new Size(1334, 707);
            pDatagridView.TabIndex = 0;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AllowUserToResizeRows = false;
            dtgvAccount.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { cChon, cSTT, cId, cTen, cDiaChi, cSoDienThoai, cDate, cEdit });
            dtgvAccount.ContextMenuStrip = ctmsAcc;
            dtgvAccount.Dock = DockStyle.Fill;
            dtgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvAccount.Location = new Point(0, 0);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.RowTemplate.Height = 25;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(1334, 707);
            dtgvAccount.TabIndex = 15;
            dtgvAccount.CellClick += dtgvAccount_CellClick;
            dtgvAccount.CellContentClick += dtgvAccount_CellContentClick;
            dtgvAccount.CellDoubleClick += dtgvAccount_CellDoubleClick;
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
            // cChon
            // 
            cChon.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cChon.FillWeight = 50F;
            cChon.HeaderText = "Chọn";
            cChon.Name = "cChon";
            cChon.Width = 39;
            // 
            // cSTT
            // 
            cSTT.HeaderText = "STT";
            cSTT.Name = "cSTT";
            cSTT.ReadOnly = true;
            cSTT.Width = 51;
            // 
            // cId
            // 
            cId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cId.HeaderText = "Mã Nhà Cung Cấp";
            cId.Name = "cId";
            cId.ReadOnly = true;
            // 
            // cTen
            // 
            cTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cTen.HeaderText = "Tên";
            cTen.Name = "cTen";
            // 
            // cDiaChi
            // 
            cDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cDiaChi.HeaderText = "Địa Chỉ ";
            cDiaChi.Name = "cDiaChi";
            cDiaChi.ReadOnly = true;
            // 
            // cSoDienThoai
            // 
            cSoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cSoDienThoai.HeaderText = "Số Điện Thoại";
            cSoDienThoai.Name = "cSoDienThoai";
            cSoDienThoai.ReadOnly = true;
            // 
            // cDate
            // 
            cDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cDate.HeaderText = "Ngày Tạo";
            cDate.Name = "cDate";
            cDate.ReadOnly = true;
            cDate.Width = 120;
            // 
            // cEdit
            // 
            cEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cEdit.HeaderText = "Sửa";
            cEdit.Name = "cEdit";
            cEdit.Resizable = DataGridViewTriState.True;
            cEdit.Width = 120;
            // 
            // NhaCungCapUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1334, 768);
            Name = "NhaCungCapUserControl";
            Size = new Size(1334, 768);
            Load += ChiNhanhUserControl_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pDatagridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ctmsAcc.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pDatagridView;
        private Panel panel1;
        private PlaceholderTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
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
        private DataGridViewCheckBoxColumn cChon;
        private DataGridViewTextBoxColumn cSTT;
        private DataGridViewTextBoxColumn cId;
        private DataGridViewTextBoxColumn cTen;
        private DataGridViewTextBoxColumn cDiaChi;
        private DataGridViewTextBoxColumn cSoDienThoai;
        private DataGridViewTextBoxColumn cDate;
        private DataGridViewImageColumn cEdit;
    }
}
