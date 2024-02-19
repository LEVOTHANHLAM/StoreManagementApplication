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
            btnAddKhachHang = new PictureBox();
            txtSearchTenKhachHang = new PlaceholderTextBox();
            panel1 = new Panel();
            pDatagridView = new Panel();
            panel7 = new Panel();
            PanelProducts = new FlowLayoutPanel();
            panel6 = new Panel();
            panel10 = new Panel();
            panel8 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel9 = new Panel();
            label1 = new Label();
            label3 = new Label();
            btnThanhToan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            PanelOrders = new Panel();
            panel3 = new Panel();
            kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddKhachHang).BeginInit();
            panel1.SuspendLayout();
            pDatagridView.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchSanPham
            // 
            txtSearchSanPham.Dock = DockStyle.Fill;
            txtSearchSanPham.ForeColor = Color.Gray;
            txtSearchSanPham.Location = new Point(0, 0);
            txtSearchSanPham.Name = "txtSearchSanPham";
            txtSearchSanPham.PlaceholderColor = Color.Gray;
            txtSearchSanPham.PlaceholderText = "Tìm Kiếm Sản Phẩm";
            txtSearchSanPham.Size = new Size(828, 36);
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pDatagridView);
            splitContainer1.Size = new Size(1353, 754);
            splitContainer1.SplitterDistance = 40;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1353, 40);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAddKhachHang);
            panel4.Controls.Add(txtSearchTenKhachHang);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(834, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 40);
            panel4.TabIndex = 1;
            // 
            // btnAddKhachHang
            // 
            btnAddKhachHang.Dock = DockStyle.Right;
            btnAddKhachHang.Image = (Image)resources.GetObject("btnAddKhachHang.Image");
            btnAddKhachHang.Location = new Point(486, 0);
            btnAddKhachHang.Name = "btnAddKhachHang";
            btnAddKhachHang.Size = new Size(33, 40);
            btnAddKhachHang.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddKhachHang.TabIndex = 12;
            btnAddKhachHang.TabStop = false;
            // 
            // txtSearchTenKhachHang
            // 
            txtSearchTenKhachHang.Dock = DockStyle.Fill;
            txtSearchTenKhachHang.ForeColor = Color.Gray;
            txtSearchTenKhachHang.Location = new Point(0, 0);
            txtSearchTenKhachHang.Name = "txtSearchTenKhachHang";
            txtSearchTenKhachHang.PlaceholderColor = Color.Gray;
            txtSearchTenKhachHang.PlaceholderText = "Tìm Kiếm Khách Hàng";
            txtSearchTenKhachHang.Size = new Size(519, 36);
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
            // panel1
            // 
            panel1.Controls.Add(txtSearchSanPham);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 40);
            panel1.TabIndex = 0;
            // 
            // pDatagridView
            // 
            pDatagridView.Controls.Add(panel7);
            pDatagridView.Controls.Add(panel6);
            pDatagridView.Controls.Add(panel3);
            pDatagridView.Dock = DockStyle.Fill;
            pDatagridView.Location = new Point(0, 0);
            pDatagridView.Name = "pDatagridView";
            pDatagridView.Size = new Size(1353, 710);
            pDatagridView.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.Controls.Add(PanelProducts);
            panel7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(834, 710);
            panel7.TabIndex = 17;
            // 
            // PanelProducts
            // 
            PanelProducts.AutoSize = true;
            PanelProducts.Dock = DockStyle.Top;
            PanelProducts.Location = new Point(0, 0);
            PanelProducts.MinimumSize = new Size(500, 0);
            PanelProducts.Name = "PanelProducts";
            PanelProducts.Size = new Size(834, 0);
            PanelProducts.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(PanelOrders);
            panel6.Location = new Point(834, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(519, 710);
            panel6.TabIndex = 16;
            // 
            // panel10
            // 
            panel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(panel8);
            panel10.Controls.Add(panel5);
            panel10.Controls.Add(panel9);
            panel10.Controls.Add(btnThanhToan);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 554);
            panel10.Name = "panel10";
            panel10.Size = new Size(519, 156);
            panel10.TabIndex = 89;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(519, 37);
            panel8.TabIndex = 91;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Cursor = Cursors.SizeAll;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(118, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(401, 37);
            label5.TabIndex = 86;
            label5.Text = "500.000";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 85;
            label6.Text = "Tổng Tiền :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightPink;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 42);
            panel5.Name = "panel5";
            panel5.Size = new Size(519, 34);
            panel5.TabIndex = 90;
            // 
            // label2
            // 
            label2.BackColor = Color.LightPink;
            label2.Cursor = Cursors.SizeAll;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(119, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(400, 34);
            label2.TabIndex = 86;
            label2.Text = "-500.000";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightPink;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 85;
            label4.Text = "Tiền Giảm :";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Aquamarine;
            panel9.Controls.Add(label1);
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 76);
            panel9.Name = "panel9";
            panel9.Size = new Size(519, 36);
            panel9.TabIndex = 89;
            // 
            // label1
            // 
            label1.BackColor = Color.Aquamarine;
            label1.Cursor = Cursors.SizeAll;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(125, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 36);
            label1.TabIndex = 86;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 85;
            label3.Text = "Thành tiền :";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Dock = DockStyle.Bottom;
            btnThanhToan.Location = new Point(0, 112);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnThanhToan.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnThanhToan.OverrideDefault.Back.ColorAngle = 45F;
            btnThanhToan.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnThanhToan.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnThanhToan.OverrideDefault.Border.ColorAngle = 45F;
            btnThanhToan.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnThanhToan.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnThanhToan.OverrideDefault.Border.Rounding = 18;
            btnThanhToan.OverrideDefault.Border.Width = 1;
            btnThanhToan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnThanhToan.Size = new Size(519, 44);
            btnThanhToan.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnThanhToan.StateCommon.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnThanhToan.StateCommon.Back.ColorAngle = 45F;
            btnThanhToan.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnThanhToan.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnThanhToan.StateCommon.Border.ColorAngle = 45F;
            btnThanhToan.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnThanhToan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnThanhToan.StateCommon.Border.Rounding = 18;
            btnThanhToan.StateCommon.Border.Width = 1;
            btnThanhToan.StateCommon.Content.ShortText.Color1 = Color.White;
            btnThanhToan.StateCommon.Content.ShortText.Color2 = Color.White;
            btnThanhToan.StateCommon.Content.ShortText.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.StatePressed.Back.Color1 = Color.FromArgb(21, 146, 197);
            btnThanhToan.StatePressed.Back.Color2 = Color.FromArgb(22, 122, 206);
            btnThanhToan.StatePressed.Back.ColorAngle = 130F;
            btnThanhToan.StatePressed.Border.Color1 = Color.FromArgb(21, 146, 197);
            btnThanhToan.StatePressed.Border.Color2 = Color.FromArgb(22, 122, 206);
            btnThanhToan.StatePressed.Border.ColorAngle = 130F;
            btnThanhToan.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnThanhToan.StatePressed.Border.Rounding = 18;
            btnThanhToan.StatePressed.Border.Width = 1;
            btnThanhToan.StateTracking.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnThanhToan.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnThanhToan.StateTracking.Back.ColorAngle = 45F;
            btnThanhToan.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnThanhToan.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnThanhToan.StateTracking.Border.ColorAngle = 45F;
            btnThanhToan.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            btnThanhToan.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnThanhToan.StateTracking.Border.Rounding = 18;
            btnThanhToan.StateTracking.Border.Width = 1;
            btnThanhToan.TabIndex = 88;
            btnThanhToan.Values.Text = "Thanh Toán";
            btnThanhToan.Click += btnThanhToan_Click_1;
            // 
            // PanelOrders
            // 
            PanelOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelOrders.BackColor = Color.Transparent;
            PanelOrders.Dock = DockStyle.Top;
            PanelOrders.Location = new Point(0, 0);
            PanelOrders.Name = "PanelOrders";
            PanelOrders.Size = new Size(519, 551);
            PanelOrders.TabIndex = 88;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1353, 710);
            panel3.TabIndex = 0;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(0, 0);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(100, 23);
            kryptonTextBox1.TabIndex = 0;
            // 
            // POSUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            MinimumSize = new Size(1353, 754);
            Name = "POSUserControl";
            Size = new Size(1353, 754);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pDatagridView.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pDatagridView;
        private PlaceholderTextBox txtSearchSanPham;
        private Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Panel panel3;
        private PlaceholderTextBox txtSearchTenKhachHang;
        private PictureBox btnAddKhachHang;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Panel panel1;
        private FlowLayoutPanel PanelProducts;
        private Panel PanelOrders;
        private Panel panel10;
        private Panel panel8;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Label label2;
        private Label label4;
        private Panel panel9;
        private Label label1;
        private Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThanhToan;
    }
}
