namespace PosManager.Forms.UserControls.Kho
{
    partial class ItemControlProductImportKho
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
            LabelSubtotal = new Label();
            panel1 = new Panel();
            labelMaSanPham = new Label();
            btnDelete = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            dateHSD = new DateTimePicker();
            cbbTenDonViTinh = new ComboBox();
            label2 = new Label();
            panel4 = new Panel();
            LabelName = new Label();
            label5 = new Label();
            txtSoLuong = new NumericUpDown();
            panel2 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // LabelSubtotal
            // 
            LabelSubtotal.Dock = DockStyle.Fill;
            LabelSubtotal.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSubtotal.ForeColor = Color.Black;
            LabelSubtotal.Location = new Point(52, 0);
            LabelSubtotal.Name = "LabelSubtotal";
            LabelSubtotal.Size = new Size(338, 22);
            LabelSubtotal.TabIndex = 3;
            LabelSubtotal.Text = "4.000.000";
            LabelSubtotal.TextAlign = ContentAlignment.MiddleRight;
            LabelSubtotal.Click += LabelSubtotal_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelMaSanPham);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 22);
            panel1.TabIndex = 7;
            // 
            // labelMaSanPham
            // 
            labelMaSanPham.Dock = DockStyle.Fill;
            labelMaSanPham.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaSanPham.Location = new Point(22, 0);
            labelMaSanPham.Name = "labelMaSanPham";
            labelMaSanPham.Size = new Size(368, 22);
            labelMaSanPham.TabIndex = 9;
            labelMaSanPham.Text = "     Mã Sản phẩm";
            labelMaSanPham.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Left;
            btnDelete.Image = Properties.Resources.icons8_delete_22;
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(22, 22);
            btnDelete.SizeMode = PictureBoxSizeMode.AutoSize;
            btnDelete.TabIndex = 7;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dateHSD);
            panel3.Controls.Add(cbbTenDonViTinh);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(5, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 24);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(255, 0);
            label3.Name = "label3";
            label3.Size = new Size(31, 24);
            label3.TabIndex = 11;
            label3.Text = "HSD:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateHSD
            // 
            dateHSD.CalendarFont = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateHSD.CustomFormat = "dd/mm/yyyy";
            dateHSD.Dock = DockStyle.Right;
            dateHSD.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateHSD.Format = DateTimePickerFormat.Custom;
            dateHSD.Location = new Point(286, 0);
            dateHSD.Name = "dateHSD";
            dateHSD.Size = new Size(104, 21);
            dateHSD.TabIndex = 32;
            dateHSD.Tag = "22/02/2024";
            // 
            // cbbTenDonViTinh
            // 
            cbbTenDonViTinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbTenDonViTinh.DisplayMember = "DisplayText";
            cbbTenDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenDonViTinh.FlatStyle = FlatStyle.Flat;
            cbbTenDonViTinh.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTenDonViTinh.ForeColor = Color.Black;
            cbbTenDonViTinh.FormattingEnabled = true;
            cbbTenDonViTinh.Location = new Point(44, 1);
            cbbTenDonViTinh.Name = "cbbTenDonViTinh";
            cbbTenDonViTinh.Size = new Size(205, 22);
            cbbTenDonViTinh.TabIndex = 31;
            cbbTenDonViTinh.ValueMember = "Value";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(390, 16);
            label2.TabIndex = 10;
            label2.Text = "---------------------------------------------------------------------------------------------------";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.Controls.Add(LabelName);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtSoLuong);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(5, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 24);
            panel4.TabIndex = 11;
            // 
            // LabelName
            // 
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelName.Location = new Point(1, 2);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(248, 23);
            LabelName.TabIndex = 15;
            LabelName.Text = "Tên Sản Phẩm";
            LabelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(255, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 24);
            label5.TabIndex = 14;
            label5.Text = "SL:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Right;
            txtSoLuong.Location = new Point(286, 0);
            txtSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(104, 22);
            txtSoLuong.TabIndex = 13;
            txtSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.Controls.Add(LabelSubtotal);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 22);
            panel2.TabIndex = 12;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 22);
            label6.TabIndex = 15;
            label6.Text = "Đơn Giá:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(5, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 16);
            panel5.TabIndex = 13;
            // 
            // ItemControlProductImportKho
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "ItemControlProductImportKho";
            Padding = new Padding(5);
            Size = new Size(400, 115);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Label LabelSubtotal;
        private Panel panel1;
        private Panel panel3;
        public ComboBox cbbTenDonViTinh;
        public Label labelMaSanPham;
        private PictureBox btnDelete;
        public DateTimePicker dateHSD;
        private Label label2;
        private Label label3;
        private Panel panel4;
        public Label LabelName;
        private Label label5;
        public NumericUpDown txtSoLuong;
        private Panel panel2;
        private Label label6;
        private Panel panel5;
    }
}
