namespace PosManager.Forms.UserControls.SanPham
{
    partial class ItemProduct
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
            panel1 = new Panel();
            lbMaSanPham = new Label();
            lbDonViTinh = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            btnChiTiet = new Button();
            panel5 = new Panel();
            btnXoa = new Button();
            panel4 = new Panel();
            btnTonKho = new Button();
            panel3 = new Panel();
            lbTenSanPham = new Label();
            picQRCode = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbMaSanPham);
            panel1.Controls.Add(lbDonViTinh);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 25);
            panel1.TabIndex = 0;
            // 
            // lbMaSanPham
            // 
            lbMaSanPham.Dock = DockStyle.Fill;
            lbMaSanPham.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaSanPham.ForeColor = Color.Black;
            lbMaSanPham.Location = new Point(0, 0);
            lbMaSanPham.Name = "lbMaSanPham";
            lbMaSanPham.Padding = new Padding(5);
            lbMaSanPham.Size = new Size(313, 25);
            lbMaSanPham.TabIndex = 6;
            lbMaSanPham.Text = "21321424214";
            lbMaSanPham.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDonViTinh
            // 
            lbDonViTinh.Dock = DockStyle.Right;
            lbDonViTinh.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDonViTinh.ForeColor = Color.Black;
            lbDonViTinh.Location = new Point(313, 0);
            lbDonViTinh.Name = "lbDonViTinh";
            lbDonViTinh.Padding = new Padding(5);
            lbDonViTinh.Size = new Size(77, 25);
            lbDonViTinh.TabIndex = 5;
            lbDonViTinh.Text = "Lon";
            lbDonViTinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(5, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 33);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnChiTiet);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(114, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(7, 3, 7, 3);
            panel6.Size = new Size(162, 33);
            panel6.TabIndex = 2;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.DodgerBlue;
            btnChiTiet.BackgroundImageLayout = ImageLayout.Zoom;
            btnChiTiet.Dock = DockStyle.Fill;
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChiTiet.ForeColor = Color.White;
            btnChiTiet.Image = Properties.Resources.icons8_update_15;
            btnChiTiet.ImageAlign = ContentAlignment.MiddleLeft;
            btnChiTiet.Location = new Point(7, 3);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(148, 27);
            btnChiTiet.TabIndex = 2;
            btnChiTiet.Text = "Chi Tiết";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnXoa);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(276, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(7, 3, 0, 3);
            panel5.Size = new Size(114, 33);
            panel5.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.PaleVioletRed;
            btnXoa.BackgroundImageLayout = ImageLayout.Zoom;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = Properties.Resources.icons8_delete_15;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(7, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 27);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTonKho);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 3, 7, 3);
            panel4.Size = new Size(114, 33);
            panel4.TabIndex = 0;
            // 
            // btnTonKho
            // 
            btnTonKho.BackColor = Color.ForestGreen;
            btnTonKho.BackgroundImageLayout = ImageLayout.Zoom;
            btnTonKho.Dock = DockStyle.Fill;
            btnTonKho.FlatStyle = FlatStyle.Flat;
            btnTonKho.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTonKho.ForeColor = Color.White;
            btnTonKho.Image = Properties.Resources.icons8_inventory_15;
            btnTonKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnTonKho.Location = new Point(0, 3);
            btnTonKho.Name = "btnTonKho";
            btnTonKho.Size = new Size(107, 27);
            btnTonKho.TabIndex = 1;
            btnTonKho.Text = "Tồn Kho";
            btnTonKho.UseVisualStyleBackColor = false;
            btnTonKho.Click += btnTonKho_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbTenSanPham);
            panel3.Controls.Add(picQRCode);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 45);
            panel3.TabIndex = 2;
            // 
            // lbTenSanPham
            // 
            lbTenSanPham.Dock = DockStyle.Fill;
            lbTenSanPham.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenSanPham.ForeColor = Color.Black;
            lbTenSanPham.Location = new Point(52, 0);
            lbTenSanPham.Name = "lbTenSanPham";
            lbTenSanPham.Padding = new Padding(5);
            lbTenSanPham.Size = new Size(338, 45);
            lbTenSanPham.TabIndex = 4;
            lbTenSanPham.Text = "Teen San Pham";
            lbTenSanPham.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picQRCode
            // 
            picQRCode.Dock = DockStyle.Left;
            picQRCode.Location = new Point(0, 0);
            picQRCode.Name = "picQRCode";
            picQRCode.Size = new Size(52, 45);
            picQRCode.TabIndex = 0;
            picQRCode.TabStop = false;
            // 
            // ItemProduct
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "ItemProduct";
            Padding = new Padding(5);
            Size = new Size(400, 113);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox picQRCode;
        public Label lbTenSanPham;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnTonKho;
        private Button btnChiTiet;
        private Button btnXoa;
        public Label lbMaSanPham;
        public Label lbDonViTinh;
    }
}
