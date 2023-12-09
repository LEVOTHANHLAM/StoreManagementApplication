using PosManager.Helper.CustomControls;

namespace PosManager.Forms.UserControls.Post
{
    partial class POSUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSUserControl));
            txtSearchSanPham = new PlaceholderTextBox();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            panel4 = new Panel();
            txtSearchTenKhachHang = new PlaceholderTextBox();
            btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            pDatagridView = new Panel();
            dtgvAccount = new DataGridView();
            cSTT = new DataGridViewTextBoxColumn();
            cMa = new DataGridViewTextBoxColumn();
            cTen = new DataGridViewTextBoxColumn();
            cDVT = new DataGridViewTextBoxColumn();
            cSoLuong = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDomainUpDownColumn();
            cThanhTien = new DataGridViewTextBoxColumn();
            cEdit = new DataGridViewImageColumn();
            cId = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            btnAddKhachHang = new PictureBox();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            pDatagridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddKhachHang).BeginInit();
            SuspendLayout();
            // 
            // txtSearchSanPham
            // 
            txtSearchSanPham.ForeColor = Color.Gray;
            txtSearchSanPham.Location = new Point(3, 3);
            txtSearchSanPham.Name = "txtSearchSanPham";
            txtSearchSanPham.PlaceholderColor = Color.Gray;
            txtSearchSanPham.PlaceholderText = "Tìm Kiếm Sản Phẩm";
            txtSearchSanPham.Size = new Size(283, 36);
            txtSearchSanPham.StateCommon.Back.Color1 = Color.White;
            txtSearchSanPham.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtSearchSanPham.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtSearchSanPham.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearchSanPham.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearchSanPham.StateCommon.Border.Rounding = 18;
            txtSearchSanPham.StateCommon.Content.Color1 = Color.Black;
            txtSearchSanPham.StateCommon.Content.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSearchSanPham.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearchSanPham.TabIndex = 3;
            txtSearchSanPham.Text = "Tìm Kiếm Sản Phẩm";
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
            splitContainer1.SplitterDistance = 197;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(296, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 197);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAddKhachHang);
            panel4.Controls.Add(txtSearchTenKhachHang);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(755, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 197);
            panel4.TabIndex = 12;
            // 
            // txtSearchTenKhachHang
            // 
            txtSearchTenKhachHang.ForeColor = Color.Gray;
            txtSearchTenKhachHang.Location = new Point(3, 5);
            txtSearchTenKhachHang.Name = "txtSearchTenKhachHang";
            txtSearchTenKhachHang.PlaceholderColor = Color.Gray;
            txtSearchTenKhachHang.PlaceholderText = "Tìm Kiếm Khách Hàng";
            txtSearchTenKhachHang.Size = new Size(235, 36);
            txtSearchTenKhachHang.StateCommon.Back.Color1 = Color.White;
            txtSearchTenKhachHang.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtSearchTenKhachHang.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            txtSearchTenKhachHang.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSearchTenKhachHang.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSearchTenKhachHang.StateCommon.Border.Rounding = 18;
            txtSearchTenKhachHang.StateCommon.Content.Color1 = Color.Black;
            txtSearchTenKhachHang.StateCommon.Content.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSearchTenKhachHang.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSearchTenKhachHang.TabIndex = 11;
            txtSearchTenKhachHang.Text = "Tìm Kiếm Khách Hàng";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(808, 41);
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
            btnExport.Location = new Point(576, 41);
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
            btnAdd.Location = new Point(339, 41);
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
            btnAdd.Values.Text = " Thêm Kho";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearchSanPham);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 197);
            panel1.TabIndex = 1;
            // 
            // pDatagridView
            // 
            pDatagridView.Controls.Add(dtgvAccount);
            pDatagridView.Controls.Add(panel3);
            pDatagridView.Dock = DockStyle.Fill;
            pDatagridView.Location = new Point(0, 0);
            pDatagridView.Name = "pDatagridView";
            pDatagridView.Size = new Size(1334, 567);
            pDatagridView.TabIndex = 0;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AllowUserToResizeRows = false;
            dtgvAccount.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { cSTT, cMa, cTen, cDVT, cSoLuong, cThanhTien, cEdit, cId });
            dtgvAccount.Dock = DockStyle.Fill;
            dtgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvAccount.Location = new Point(0, 0);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.RowTemplate.Height = 25;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(1334, 426);
            dtgvAccount.TabIndex = 15;
            // 
            // cSTT
            // 
            cSTT.HeaderText = "STT";
            cSTT.Name = "cSTT";
            cSTT.ReadOnly = true;
            cSTT.Width = 51;
            // 
            // cMa
            // 
            cMa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cMa.HeaderText = "Mã";
            cMa.Name = "cMa";
            cMa.ReadOnly = true;
            // 
            // cTen
            // 
            cTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cTen.HeaderText = "Tên Sản Phẩm";
            cTen.Name = "cTen";
            cTen.ReadOnly = true;
            // 
            // cDVT
            // 
            cDVT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cDVT.HeaderText = "Đơn Vị Tính";
            cDVT.Name = "cDVT";
            // 
            // cSoLuong
            // 
            cSoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cSoLuong.HeaderText = "Số Lượng";
            cSoLuong.Name = "cSoLuong";
            cSoLuong.Resizable = DataGridViewTriState.True;
            cSoLuong.SortMode = DataGridViewColumnSortMode.Automatic;
            cSoLuong.Width = 232;
            // 
            // cThanhTien
            // 
            cThanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cThanhTien.HeaderText = "Thành Tiền";
            cThanhTien.Name = "cThanhTien";
            cThanhTien.ReadOnly = true;
            // 
            // cEdit
            // 
            cEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cEdit.HeaderText = "Xoá";
            cEdit.Name = "cEdit";
            cEdit.Resizable = DataGridViewTriState.True;
            cEdit.Width = 120;
            // 
            // cId
            // 
            cId.HeaderText = "cId";
            cId.Name = "cId";
            cId.ReadOnly = true;
            cId.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnExport);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(1334, 141);
            panel3.TabIndex = 0;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(0, 0);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(100, 23);
            kryptonTextBox1.TabIndex = 0;
            // 
            // btnAddKhachHang
            // 
            btnAddKhachHang.Image = (Image)resources.GetObject("btnAddKhachHang.Image");
            btnAddKhachHang.Location = new Point(244, 7);
            btnAddKhachHang.Name = "btnAddKhachHang";
            btnAddKhachHang.Size = new Size(33, 34);
            btnAddKhachHang.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddKhachHang.TabIndex = 12;
            btnAddKhachHang.TabStop = false;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(755, 197);
            panel5.TabIndex = 13;
            // 
            // POSUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1334, 768);
            Name = "POSUserControl";
            Size = new Size(1334, 768);
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
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAddKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pDatagridView;
        private Panel panel1;
        private PlaceholderTextBox txtSearchSanPham;
        private Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private DataGridView dtgvAccount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Panel panel3;
        private DataGridViewTextBoxColumn cSTT;
        private DataGridViewTextBoxColumn cMa;
        private DataGridViewTextBoxColumn cTen;
        private DataGridViewTextBoxColumn cDVT;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDomainUpDownColumn cSoLuong;
        private DataGridViewTextBoxColumn cThanhTien;
        private DataGridViewImageColumn cEdit;
        private DataGridViewTextBoxColumn cId;
        private Panel panel4;
        private PlaceholderTextBox txtSearchTenKhachHang;
        private PictureBox btnAddKhachHang;
        private Panel panel5;
    }
}
