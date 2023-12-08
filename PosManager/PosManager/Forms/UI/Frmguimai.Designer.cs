using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmguimai
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
            this.components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            this.button1 = new Button();
            this.dgvchitiethanghoa = new DataGridView();
            this.TT = new DataGridViewTextBoxColumn();
            this.MAHANG = new DataGridViewTextBoxColumn();
            this.tenhang = new DataGridViewTextBoxColumn();
            this.dvt = new DataGridViewTextBoxColumn();
            this.SOLUONG = new DataGridViewTextBoxColumn();
            this.dongia = new DataGridViewTextBoxColumn();
            this.Thanhtien = new DataGridViewTextBoxColumn();
           // this.timer1 = new Timer(this.components);
            this.dgvhoadon = new DataGridView();
            this.stthd = new DataGridViewTextBoxColumn();
            this.SOHOADON = new DataGridViewTextBoxColumn();
            this.KH = new DataGridViewTextBoxColumn();
            this.TONGCONG = new DataGridViewTextBoxColumn();
            this.GIAMTIEN = new DataGridViewTextBoxColumn();
            this.PHANTRAM = new DataGridViewTextBoxColumn();
            this.THANHTOAN = new DataGridViewTextBoxColumn();
            this.ht = new DataGridViewTextBoxColumn();
            this.ngayhd = new DataGridViewTextBoxColumn();
            this.dgvlailo = new DataGridView();
            this.ttll = new DataGridViewTextBoxColumn();
            this.mahangll = new DataGridViewTextBoxColumn();
            this.tenhangll = new DataGridViewTextBoxColumn();
            this.dvtll = new DataGridViewTextBoxColumn();
            this.LOAI = new DataGridViewTextBoxColumn();
            this.soluongll = new DataGridViewTextBoxColumn();
            this.dongiall = new DataGridViewTextBoxColumn();
            this.thanhtienll = new DataGridViewTextBoxColumn();
            this.GIAVON = new DataGridViewTextBoxColumn();
            this.LAILO = new DataGridViewTextBoxColumn();
            this.LOAI1 = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)this.dgvchitiethanghoa).BeginInit();
            ((ISupportInitialize)this.dgvhoadon).BeginInit();
            ((ISupportInitialize)this.dgvlailo).BeginInit();
            base.SuspendLayout();
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.FromArgb(0, 0, 192);
            this.button1.Location = new Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new Size(291, 123);
            this.button1.TabIndex = 0;
            this.button1.Text = "ĐANG GỬI MAIL\r\nPHẦN MỀM SẼ TỰ TẮT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.dgvchitiethanghoa.AllowUserToAddRows = false;
            this.dgvchitiethanghoa.AllowUserToDeleteRows = false;
            this.dgvchitiethanghoa.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvchitiethanghoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvchitiethanghoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiethanghoa.Columns.AddRange(new DataGridViewColumn[]
            {
                this.TT,
                this.MAHANG,
                this.tenhang,
                this.dvt,
                this.SOLUONG,
                this.dongia,
                this.Thanhtien
            });
            this.dgvchitiethanghoa.Location = new Point(108, 52);
            this.dgvchitiethanghoa.Name = "dgvchitiethanghoa";
            this.dgvchitiethanghoa.ReadOnly = true;
            this.dgvchitiethanghoa.RowHeadersWidth = 4;
            this.dgvchitiethanghoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvchitiethanghoa.Size = new Size(176, 61);
            this.dgvchitiethanghoa.TabIndex = 8;
            this.TT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.TT.DefaultCellStyle = dataGridViewCellStyle2;
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.Width = 60;
            this.MAHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAHANG.DataPropertyName = "mahanghoa";
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.Name = "MAHANG";
            this.MAHANG.ReadOnly = true;
            this.MAHANG.Width = 150;
            this.tenhang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tenhang.DataPropertyName = "tenhanghoa";
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            this.tenhang.Width = 300;
            this.dvt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dvt.DataPropertyName = "donvitinh";
            this.dvt.HeaderText = "Đơn Vị Tính";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 150;
            this.SOLUONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOLUONG.DataPropertyName = "tongsoluong";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            this.SOLUONG.DefaultCellStyle = dataGridViewCellStyle3;
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 120;
            this.dongia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dongia.DataPropertyName = "dongiaban";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.dongia.DefaultCellStyle = dataGridViewCellStyle4;
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            this.Thanhtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Thanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.Thanhtien.DefaultCellStyle = dataGridViewCellStyle5;
            this.Thanhtien.HeaderText = "Thành Tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.Width = 150;
          //  this.timer1.Tick += this.timer1_Tick;
            this.dgvhoadon.AllowUserToAddRows = false;
            this.dgvhoadon.AllowUserToDeleteRows = false;
            this.dgvhoadon.BackgroundColor = Color.White;
            this.dgvhoadon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            this.dgvhoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new DataGridViewColumn[]
            {
                this.stthd,
                this.SOHOADON,
                this.KH,
                this.TONGCONG,
                this.GIAMTIEN,
                this.PHANTRAM,
                this.THANHTOAN,
                this.ht,
                this.ngayhd
            });
            this.dgvhoadon.Location = new Point(44, 32);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.ReadOnly = true;
            this.dgvhoadon.RowHeadersWidth = 4;
            this.dgvhoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvhoadon.Size = new Size(214, 81);
            this.dgvhoadon.TabIndex = 9;
            this.stthd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.stthd.DefaultCellStyle = dataGridViewCellStyle7;
            this.stthd.HeaderText = "TT";
            this.stthd.Name = "stthd";
            this.stthd.ReadOnly = true;
            this.stthd.Width = 40;
            this.SOHOADON.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SOHOADON.DataPropertyName = "SOHOADON";
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.SOHOADON.DefaultCellStyle = dataGridViewCellStyle8;
            this.SOHOADON.HeaderText = "Số Hóa Đơn";
            this.SOHOADON.Name = "SOHOADON";
            this.SOHOADON.ReadOnly = true;
            this.KH.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.KH.DataPropertyName = "tendonvi";
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.KH.DefaultCellStyle = dataGridViewCellStyle9;
            this.KH.HeaderText = "Khách Hàng";
            this.KH.Name = "KH";
            this.KH.ReadOnly = true;
            this.KH.Width = 279;
            this.TONGCONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TONGCONG.DataPropertyName = "TONGCONG";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.TONGCONG.DefaultCellStyle = dataGridViewCellStyle10;
            this.TONGCONG.HeaderText = "Tổng Cộng";
            this.TONGCONG.Name = "TONGCONG";
            this.TONGCONG.ReadOnly = true;
            this.TONGCONG.Width = 120;
            this.GIAMTIEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.GIAMTIEN.DataPropertyName = "GIAMTIEN";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            this.GIAMTIEN.DefaultCellStyle = dataGridViewCellStyle11;
            this.GIAMTIEN.HeaderText = "+/- Tiền";
            this.GIAMTIEN.Name = "GIAMTIEN";
            this.GIAMTIEN.ReadOnly = true;
            this.GIAMTIEN.Width = 60;
            this.PHANTRAM.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.PHANTRAM.DataPropertyName = "TIENPHANTRAM";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            this.PHANTRAM.DefaultCellStyle = dataGridViewCellStyle12;
            this.PHANTRAM.HeaderText = "+/- %";
            this.PHANTRAM.Name = "PHANTRAM";
            this.PHANTRAM.ReadOnly = true;
            this.PHANTRAM.Width = 60;
            this.THANHTOAN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.THANHTOAN.DataPropertyName = "THANHTOAN";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N0";
            this.THANHTOAN.DefaultCellStyle = dataGridViewCellStyle13;
            this.THANHTOAN.HeaderText = "Thanh Toán";
            this.THANHTOAN.Name = "THANHTOAN";
            this.THANHTOAN.ReadOnly = true;
            this.THANHTOAN.Width = 120;
            this.ht.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ht.DataPropertyName = "ht";
            dataGridViewCellStyle14.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ht.DefaultCellStyle = dataGridViewCellStyle14;
            this.ht.HeaderText = "Hình Thức";
            this.ht.Name = "ht";
            this.ht.ReadOnly = true;
            this.ht.Width = 90;
            this.ngayhd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ngayhd.DataPropertyName = "NGAY";
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ngayhd.DefaultCellStyle = dataGridViewCellStyle15;
            this.ngayhd.HeaderText = "Ngày TT";
            this.ngayhd.Name = "ngayhd";
            this.ngayhd.ReadOnly = true;
            this.ngayhd.Width = 120;
            this.dgvlailo.AllowUserToAddRows = false;
            this.dgvlailo.AllowUserToDeleteRows = false;
            this.dgvlailo.BackgroundColor = Color.White;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle16.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            this.dgvlailo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvlailo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlailo.Columns.AddRange(new DataGridViewColumn[]
            {
                this.ttll,
                this.mahangll,
                this.tenhangll,
                this.dvtll,
                this.LOAI,
                this.soluongll,
                this.dongiall,
                this.thanhtienll,
                this.GIAVON,
                this.LAILO,
                this.LOAI1
            });
            this.dgvlailo.Location = new Point(36, 43);
            this.dgvlailo.Name = "dgvlailo";
            this.dgvlailo.ReadOnly = true;
            this.dgvlailo.RowHeadersWidth = 4;
            this.dgvlailo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvlailo.Size = new Size(66, 70);
            this.dgvlailo.TabIndex = 13;
            this.ttll.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ttll.DefaultCellStyle = dataGridViewCellStyle17;
            this.ttll.HeaderText = "TT";
            this.ttll.Name = "ttll";
            this.ttll.ReadOnly = true;
            this.ttll.Width = 50;
            this.mahangll.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.mahangll.DataPropertyName = "mahanghoa";
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.mahangll.DefaultCellStyle = dataGridViewCellStyle18;
            this.mahangll.HeaderText = "Mã Hàng";
            this.mahangll.Name = "mahangll";
            this.mahangll.ReadOnly = true;
            this.tenhangll.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tenhangll.DataPropertyName = "tenhanghoa";
            dataGridViewCellStyle19.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.tenhangll.DefaultCellStyle = dataGridViewCellStyle19;
            this.tenhangll.HeaderText = "Tên Hàng";
            this.tenhangll.Name = "tenhangll";
            this.tenhangll.ReadOnly = true;
            this.tenhangll.Width = 250;
            this.dvtll.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dvtll.DataPropertyName = "donvitinh";
            dataGridViewCellStyle20.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dvtll.DefaultCellStyle = dataGridViewCellStyle20;
            this.dvtll.HeaderText = "Đvt";
            this.dvtll.Name = "dvtll";
            this.dvtll.ReadOnly = true;
            this.LOAI.DataPropertyName = "LOAI";
            this.LOAI.HeaderText = "Loại";
            this.LOAI.Name = "LOAI";
            this.LOAI.ReadOnly = true;
            this.LOAI.Visible = false;
            this.soluongll.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soluongll.DataPropertyName = "tongsoluong";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "N2";
            this.soluongll.DefaultCellStyle = dataGridViewCellStyle21;
            this.soluongll.HeaderText = "Số Lượng";
            this.soluongll.Name = "soluongll";
            this.soluongll.ReadOnly = true;
            this.soluongll.Width = 110;
            this.dongiall.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dongiall.DataPropertyName = "dongiaban";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            this.dongiall.DefaultCellStyle = dataGridViewCellStyle22;
            this.dongiall.HeaderText = "Đơn Giá";
            this.dongiall.Name = "dongiall";
            this.dongiall.ReadOnly = true;
            this.thanhtienll.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.thanhtienll.DataPropertyName = "thanhtien";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N0";
            this.thanhtienll.DefaultCellStyle = dataGridViewCellStyle23;
            this.thanhtienll.HeaderText = "Thành Tiền";
            this.thanhtienll.Name = "thanhtienll";
            this.thanhtienll.ReadOnly = true;
            this.thanhtienll.Width = 120;
            this.GIAVON.DataPropertyName = "GIAVON";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N0";
            dataGridViewCellStyle24.NullValue = null;
            this.GIAVON.DefaultCellStyle = dataGridViewCellStyle24;
            this.GIAVON.HeaderText = "Giá Vốn";
            this.GIAVON.Name = "GIAVON";
            this.GIAVON.ReadOnly = true;
            this.LAILO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.LAILO.DataPropertyName = "LAILO";
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N0";
            this.LAILO.DefaultCellStyle = dataGridViewCellStyle25;
            this.LAILO.HeaderText = "Lợi Nhuận";
            this.LAILO.Name = "LAILO";
            this.LAILO.ReadOnly = true;
            this.LAILO.Width = 120;
            this.LOAI1.DataPropertyName = "LOAI";
            this.LOAI1.HeaderText = "LOẠI";
            this.LOAI1.Name = "LOAI1";
            this.LOAI1.ReadOnly = true;
            this.LOAI1.Visible = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(315, 160);
           // base.ControlBox = false;
            base.Controls.Add(this.button1);
            base.Controls.Add(this.dgvlailo);
            base.Controls.Add(this.dgvhoadon);
            base.Controls.Add(this.dgvchitiethanghoa);
            base.Name = "Frmguimai";
         //   base.StartPosition = FormStartPosition.CenterScreen;
            base.Load += this.Frmguimai_Load;
            ((ISupportInitialize)this.dgvchitiethanghoa).EndInit();
            ((ISupportInitialize)this.dgvhoadon).EndInit();
            ((ISupportInitialize)this.dgvlailo).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x040012E4 RID: 4836
        private Button button1;

        // Token: 0x040012E5 RID: 4837
        private DataGridView dgvchitiethanghoa;

        // Token: 0x040012E6 RID: 4838
        private DataGridViewTextBoxColumn TT;

        // Token: 0x040012E7 RID: 4839
        private DataGridViewTextBoxColumn MAHANG;

        // Token: 0x040012E8 RID: 4840
        private DataGridViewTextBoxColumn tenhang;

        // Token: 0x040012E9 RID: 4841
        private DataGridViewTextBoxColumn dvt;

        // Token: 0x040012EA RID: 4842
        private DataGridViewTextBoxColumn SOLUONG;

        // Token: 0x040012EB RID: 4843
        private DataGridViewTextBoxColumn dongia;

        // Token: 0x040012EC RID: 4844
        private DataGridViewTextBoxColumn Thanhtien;

        // Token: 0x040012ED RID: 4845
     //   private Timer timer1;

        // Token: 0x040012EE RID: 4846
        private DataGridView dgvhoadon;

        // Token: 0x040012EF RID: 4847
        private DataGridViewTextBoxColumn stthd;

        // Token: 0x040012F0 RID: 4848
        private DataGridViewTextBoxColumn SOHOADON;

        // Token: 0x040012F1 RID: 4849
        private DataGridViewTextBoxColumn KH;

        // Token: 0x040012F2 RID: 4850
        private DataGridViewTextBoxColumn TONGCONG;

        // Token: 0x040012F3 RID: 4851
        private DataGridViewTextBoxColumn GIAMTIEN;

        // Token: 0x040012F4 RID: 4852
        private DataGridViewTextBoxColumn PHANTRAM;

        // Token: 0x040012F5 RID: 4853
        private DataGridViewTextBoxColumn THANHTOAN;

        // Token: 0x040012F6 RID: 4854
        private DataGridViewTextBoxColumn ht;

        // Token: 0x040012F7 RID: 4855
        private DataGridViewTextBoxColumn ngayhd;

        // Token: 0x040012F8 RID: 4856
        private DataGridView dgvlailo;

        // Token: 0x040012F9 RID: 4857
        private DataGridViewTextBoxColumn ttll;

        // Token: 0x040012FA RID: 4858
        private DataGridViewTextBoxColumn mahangll;

        // Token: 0x040012FB RID: 4859
        private DataGridViewTextBoxColumn tenhangll;

        // Token: 0x040012FC RID: 4860
        private DataGridViewTextBoxColumn dvtll;

        // Token: 0x040012FD RID: 4861
        private DataGridViewTextBoxColumn LOAI;

        // Token: 0x040012FE RID: 4862
        private DataGridViewTextBoxColumn soluongll;

        // Token: 0x040012FF RID: 4863
        private DataGridViewTextBoxColumn dongiall;

        // Token: 0x04001300 RID: 4864
        private DataGridViewTextBoxColumn thanhtienll;

        // Token: 0x04001301 RID: 4865
        private DataGridViewTextBoxColumn GIAVON;

        // Token: 0x04001302 RID: 4866
        private DataGridViewTextBoxColumn LAILO;

        // Token: 0x04001303 RID: 4867
        private DataGridViewTextBoxColumn LOAI1;
    }
}
