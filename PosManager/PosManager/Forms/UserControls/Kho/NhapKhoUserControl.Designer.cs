using PosManager.Helper.CustomControls;

namespace PosManager.Forms.UserControls.Kho
{
    partial class NhapKhoUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            txtSearch = new PlaceholderTextBox();
            dtgvAccount = new DataGridView();
            ctmsAcc = new ContextMenuStrip(components);
            selectedToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            selectAllHighlightedToolStripMenuItem = new ToolStripMenuItem();
            deselectAllToolStripMenuItem = new ToolStripMenuItem();
            kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            panel1 = new Panel();
            cSTT = new DataGridViewTextBoxColumn();
            cMaHangHoa = new DataGridViewTextBoxColumn();
            cTenHangHoa = new DataGridViewTextBoxColumn();
            cMaKho = new DataGridViewTextBoxColumn();
            cTenKho = new DataGridViewTextBoxColumn();
            cSoLuongTon = new DataGridViewTextBoxColumn();
            cMaDonViHangHoa = new DataGridViewTextBoxColumn();
            cTenDonViHangHoa = new DataGridViewTextBoxColumn();
            cId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            ctmsAcc.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(txtSearch);
            splitContainer1.Size = new Size(935, 594);
            splitContainer1.SplitterDistance = 542;
            splitContainer1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(0, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderColor = Color.Gray;
            txtSearch.PlaceholderText = "Tìm Kiếm";
            txtSearch.Size = new Size(542, 36);
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
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AllowUserToResizeRows = false;
            dtgvAccount.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { cSTT, cMaHangHoa, cTenHangHoa, cMaKho, cTenKho, cSoLuongTon, cMaDonViHangHoa, cTenDonViHangHoa, cId });
            dtgvAccount.ContextMenuStrip = ctmsAcc;
            dtgvAccount.Dock = DockStyle.Fill;
            dtgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvAccount.Location = new Point(0, 0);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.RowTemplate.Height = 25;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(542, 558);
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
            // panel1
            // 
            panel1.Controls.Add(dtgvAccount);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 558);
            panel1.TabIndex = 0;
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
            // cMaHangHoa
            // 
            cMaHangHoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cMaHangHoa.HeaderText = "Mã";
            cMaHangHoa.Name = "cMaHangHoa";
            // 
            // cTenHangHoa
            // 
            cTenHangHoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cTenHangHoa.HeaderText = "Tên ";
            cTenHangHoa.Name = "cTenHangHoa";
            // 
            // cMaKho
            // 
            cMaKho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cMaKho.HeaderText = "Mã Kho";
            cMaKho.Name = "cMaKho";
            cMaKho.Resizable = DataGridViewTriState.True;
            cMaKho.SortMode = DataGridViewColumnSortMode.NotSortable;
            cMaKho.Visible = false;
            // 
            // cTenKho
            // 
            cTenKho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cTenKho.DefaultCellStyle = dataGridViewCellStyle3;
            cTenKho.HeaderText = "Kho";
            cTenKho.Name = "cTenKho";
            // 
            // cSoLuongTon
            // 
            cSoLuongTon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cSoLuongTon.HeaderText = "SL";
            cSoLuongTon.Name = "cSoLuongTon";
            // 
            // cMaDonViHangHoa
            // 
            cMaDonViHangHoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cMaDonViHangHoa.HeaderText = "Mã Đơn Vị Hàng Hoá";
            cMaDonViHangHoa.Name = "cMaDonViHangHoa";
            cMaDonViHangHoa.Visible = false;
            // 
            // cTenDonViHangHoa
            // 
            cTenDonViHangHoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cTenDonViHangHoa.FillWeight = 170F;
            cTenDonViHangHoa.HeaderText = "Đơn Vị Hàng Hoá";
            cTenDonViHangHoa.Name = "cTenDonViHangHoa";
            // 
            // cId
            // 
            cId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cId.HeaderText = "cId";
            cId.Name = "cId";
            cId.ReadOnly = true;
            cId.Visible = false;
            // 
            // TonKhoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "TonKhoUserControl";
            Size = new Size(935, 594);
            Load += ChiNhanhUserControl_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ctmsAcc.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PlaceholderTextBox txtSearch;
        private DataGridView dtgvAccount;
        private ContextMenuStrip ctmsAcc;
        private ToolStripMenuItem selectedToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem selectAllHighlightedToolStripMenuItem;
        private ToolStripMenuItem deselectAllToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Panel panel1;
        private DataGridViewTextBoxColumn cSTT;
        private DataGridViewTextBoxColumn cMaHangHoa;
        private DataGridViewTextBoxColumn cTenHangHoa;
        private DataGridViewTextBoxColumn cMaKho;
        private DataGridViewTextBoxColumn cTenKho;
        private DataGridViewTextBoxColumn cSoLuongTon;
        private DataGridViewTextBoxColumn cMaDonViHangHoa;
        private DataGridViewTextBoxColumn cTenDonViHangHoa;
        private DataGridViewTextBoxColumn cId;
    }
}
