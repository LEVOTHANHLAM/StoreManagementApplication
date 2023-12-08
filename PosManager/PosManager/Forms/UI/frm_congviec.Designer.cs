using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class frm_congviec
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
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            this.txt_manguoitao = new TextBox();
            this.txt_nguoithuchien = new TextBox();
            this.txt_noidung = new TextBox();
            this.txt_tennguoitao = new TextBox();
            this.textBox2 = new TextBox();
            this.txt_songay = new TextBox();
            this.cob_locnhanvien = new ComboBox();
            this.dgv_congviec = new DataGridView();
            this.MACONGVIEC = new DataGridViewTextBoxColumn();
            this.nguoitao = new DataGridViewTextBoxColumn();
            this.nguoithuchien = new DataGridViewTextBoxColumn();
            this.Ngaytao = new DataGridViewTextBoxColumn();
            this.denngay = new DataGridViewTextBoxColumn();
            this.noidung = new DataGridViewTextBoxColumn();
            this.Nhanviec = new DataGridViewTextBoxColumn();
            this.ghichu = new DataGridViewTextBoxColumn();
            this.MANGUOITAO = new DataGridViewTextBoxColumn();
            this.MANGUOITHUCHIEN = new DataGridViewTextBoxColumn();
            this.button1 = new Button();
            this.bt_yeucau = new Button();
            this.bt_thuchien = new Button();
            this.button2 = new Button();
            ((ISupportInitialize)this.dgv_congviec).BeginInit();
            base.SuspendLayout();
            this.txt_manguoitao.BackColor = Color.White;
            this.txt_manguoitao.Font = new Font("Times New Roman", 14f);
            this.txt_manguoitao.Location = new Point(3, 3);
            this.txt_manguoitao.Name = "txt_manguoitao";
            this.txt_manguoitao.Size = new Size(145, 29);
            this.txt_manguoitao.TabIndex = 0;
            this.txt_manguoitao.Tag = "Mã nv tạo";
            this.txt_manguoitao.Text = "Mã nv tạo";
            this.txt_manguoitao.TextChanged += this.txt_manguoitao_TextChanged;
            this.txt_manguoitao.Enter += this.txt_manguoitao_Enter;
            this.txt_manguoitao.KeyDown += this.txt_manguoitao_KeyDown;
            this.txt_manguoitao.Leave += this.txt_manguoitao_Leave;
            this.txt_nguoithuchien.BackColor = Color.White;
            this.txt_nguoithuchien.Font = new Font("Times New Roman", 14f);
            this.txt_nguoithuchien.Location = new Point(3, 36);
            this.txt_nguoithuchien.Name = "txt_nguoithuchien";
            this.txt_nguoithuchien.ReadOnly = true;
            this.txt_nguoithuchien.Size = new Size(345, 29);
            this.txt_nguoithuchien.TabIndex = 1;
            this.txt_nguoithuchien.Tag = "";
            this.txt_nguoithuchien.Text = "Người thực hiện công việc";
            this.txt_nguoithuchien.MouseDoubleClick += this.txt_nguoithuchien_MouseDoubleClick;
            this.txt_noidung.BackColor = Color.White;
            this.txt_noidung.Font = new Font("Times New Roman", 14f);
            this.txt_noidung.Location = new Point(354, 3);
            this.txt_noidung.MaxLength = 320;
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new Size(554, 97);
            this.txt_noidung.TabIndex = 20;
            this.txt_noidung.Tag = "Nội dung công việc";
            this.txt_noidung.Text = "Nội dung công việc";
            this.txt_noidung.Enter += this.txt_noidung_Enter;
            this.txt_noidung.Leave += this.txt_noidung_Leave;
            this.txt_tennguoitao.BackColor = Color.White;
            this.txt_tennguoitao.Font = new Font("Times New Roman", 14f);
            this.txt_tennguoitao.Location = new Point(135, 3);
            this.txt_tennguoitao.Name = "txt_tennguoitao";
            this.txt_tennguoitao.ReadOnly = true;
            this.txt_tennguoitao.Size = new Size(213, 29);
            this.txt_tennguoitao.TabIndex = 21;
            this.txt_tennguoitao.Tag = "Tên người tạo công việc";
            this.txt_tennguoitao.Text = "Tên người tạo công việc";
            this.textBox2.BackColor = Color.White;
            this.textBox2.Font = new Font("Times New Roman", 14f);
            this.textBox2.Location = new Point(3, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(213, 29);
            this.textBox2.TabIndex = 21;
            this.textBox2.Tag = "";
            this.textBox2.Text = "Số ngày cần thực hiện";
            this.txt_songay.BackColor = Color.White;
            this.txt_songay.Font = new Font("Times New Roman", 14f);
            this.txt_songay.Location = new Point(213, 71);
            this.txt_songay.Name = "txt_songay";
            this.txt_songay.Size = new Size(135, 29);
            this.txt_songay.TabIndex = 22;
            this.txt_songay.Tag = "1";
            this.txt_songay.Text = "1";
            this.txt_songay.TextAlign = HorizontalAlignment.Center;
            this.txt_songay.KeyDown += this.txt_songay_KeyDown;
            this.cob_locnhanvien.BackColor = Color.White;
            this.cob_locnhanvien.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cob_locnhanvien.FlatStyle = FlatStyle.Popup;
            this.cob_locnhanvien.FormattingEnabled = true;
            this.cob_locnhanvien.Location = new Point(3, 136);
            this.cob_locnhanvien.Name = "cob_locnhanvien";
            this.cob_locnhanvien.Size = new Size(345, 29);
            this.cob_locnhanvien.TabIndex = 23;
            this.cob_locnhanvien.SelectedIndexChanged += this.cob_locnhanvien_SelectedIndexChanged;
            this.dgv_congviec.AllowUserToAddRows = false;
            this.dgv_congviec.AllowUserToDeleteRows = false;
            this.dgv_congviec.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgv_congviec.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgv_congviec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgv_congviec.ColumnHeadersHeight = 34;
            this.dgv_congviec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_congviec.Columns.AddRange(new DataGridViewColumn[]
            {
                this.MACONGVIEC,
                this.nguoitao,
                this.nguoithuchien,
                this.Ngaytao,
                this.denngay,
                this.noidung,
                this.Nhanviec,
                this.ghichu,
                this.MANGUOITAO,
                this.MANGUOITHUCHIEN
            });
            this.dgv_congviec.Location = new Point(3, 172);
            this.dgv_congviec.Name = "dgv_congviec";
            this.dgv_congviec.ReadOnly = true;
            this.dgv_congviec.RowHeadersVisible = false;
            this.dgv_congviec.RowTemplate.Height = 44;
            this.dgv_congviec.Size = new Size(1020, 251);
            this.dgv_congviec.TabIndex = 24;
            this.dgv_congviec.CellEndEdit += this.dgv_congviec_CellEndEdit;
            this.dgv_congviec.MouseClick += this.dgv_congviec_MouseClick;
            this.MACONGVIEC.DataPropertyName = "MACONGVIEC";
            this.MACONGVIEC.HeaderText = "MA CONG VIEC";
            this.MACONGVIEC.Name = "MACONGVIEC";
            this.MACONGVIEC.ReadOnly = true;
            this.MACONGVIEC.Visible = false;
            this.nguoitao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nguoitao.DataPropertyName = "NGUOITAO";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.nguoitao.DefaultCellStyle = dataGridViewCellStyle2;
            this.nguoitao.HeaderText = "Người tạo";
            this.nguoitao.Name = "nguoitao";
            this.nguoitao.ReadOnly = true;
            this.nguoitao.Width = 150;
            this.nguoithuchien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.nguoithuchien.DataPropertyName = "NGUOITHUCHIEN";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.nguoithuchien.DefaultCellStyle = dataGridViewCellStyle3;
            this.nguoithuchien.HeaderText = "Người thực hiện";
            this.nguoithuchien.Name = "nguoithuchien";
            this.nguoithuchien.ReadOnly = true;
            this.nguoithuchien.Width = 150;
            this.Ngaytao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ngaytao.DataPropertyName = "NGAYTAO";
            this.Ngaytao.HeaderText = "Ngày tạo";
            this.Ngaytao.Name = "Ngaytao";
            this.Ngaytao.ReadOnly = true;
            this.Ngaytao.Width = 139;
            this.denngay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.denngay.DataPropertyName = "DENNGAY";
            this.denngay.HeaderText = "Đến ngày";
            this.denngay.Name = "denngay";
            this.denngay.ReadOnly = true;
            this.denngay.Width = 110;
            this.noidung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.noidung.DataPropertyName = "NOIDUNG";
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.noidung.DefaultCellStyle = dataGridViewCellStyle4;
            this.noidung.HeaderText = "Nội dung";
            this.noidung.MinimumWidth = 250;
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            this.Nhanviec.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Nhanviec.DataPropertyName = "NHANVIEC";
            this.Nhanviec.HeaderText = "Xử lý";
            this.Nhanviec.Name = "Nhanviec";
            this.Nhanviec.ReadOnly = true;
            this.ghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu.DataPropertyName = "GHICHU";
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            this.ghichu.DefaultCellStyle = dataGridViewCellStyle5;
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 200;
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            this.MANGUOITAO.DataPropertyName = "MANGUOITAO";
            this.MANGUOITAO.HeaderText = "MANGUOITAO";
            this.MANGUOITAO.Name = "MANGUOITAO";
            this.MANGUOITAO.ReadOnly = true;
            this.MANGUOITAO.Visible = false;
            this.MANGUOITHUCHIEN.DataPropertyName = "MANGUOITHUCHIEN";
            this.MANGUOITHUCHIEN.HeaderText = "MA NGUOI THUC HIEN";
            this.MANGUOITHUCHIEN.Name = "MANGUOITHUCHIEN";
            this.MANGUOITHUCHIEN.ReadOnly = true;
            this.MANGUOITHUCHIEN.Visible = false;
            this.button1.BackColor = Color.Red;
            this.button1.Font = new Font("Times New Roman", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(914, 2);
            this.button1.Name = "button1";
            this.button1.Size = new Size(109, 99);
            this.button1.TabIndex = 25;
            this.button1.Text = "LƯU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            this.bt_yeucau.Location = new Point(354, 118);
            this.bt_yeucau.Name = "bt_yeucau";
            this.bt_yeucau.Size = new Size(163, 47);
            this.bt_yeucau.TabIndex = 26;
            this.bt_yeucau.Text = "Xem yêu cầu";
            this.bt_yeucau.UseVisualStyleBackColor = true;
            this.bt_yeucau.Click += this.bt_yeucau_Click;
            this.bt_thuchien.Location = new Point(611, 117);
            this.bt_thuchien.Name = "bt_thuchien";
            this.bt_thuchien.Size = new Size(163, 47);
            this.bt_thuchien.TabIndex = 27;
            this.bt_thuchien.Text = "Xem thực hiện";
            this.bt_thuchien.UseVisualStyleBackColor = true;
            this.bt_thuchien.Click += this.bt_thuchien_Click;
            this.button2.Location = new Point(949, 117);
            this.button2.Name = "button2";
            this.button2.Size = new Size(74, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1024, 422);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.bt_thuchien);
            base.Controls.Add(this.bt_yeucau);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.dgv_congviec);
            base.Controls.Add(this.cob_locnhanvien);
            base.Controls.Add(this.txt_songay);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.txt_tennguoitao);
            base.Controls.Add(this.txt_noidung);
            base.Controls.Add(this.txt_nguoithuchien);
            base.Controls.Add(this.txt_manguoitao);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
          //  base.MaximizeBox = false;
       //     base.MinimizeBox = false;
            base.Name = "frm_congviec";
        //    base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Công việc hàng ngày";
            base.Load += this.frm_congviec_Load;
            ((ISupportInitialize)this.dgv_congviec).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x040008A9 RID: 2217
        private TextBox txt_manguoitao;

        // Token: 0x040008AA RID: 2218
        private TextBox txt_nguoithuchien;

        // Token: 0x040008AB RID: 2219
        private TextBox txt_noidung;

        // Token: 0x040008AC RID: 2220
        private TextBox txt_tennguoitao;

        // Token: 0x040008AD RID: 2221
        private TextBox textBox2;

        // Token: 0x040008AE RID: 2222
        private TextBox txt_songay;

        // Token: 0x040008AF RID: 2223
        private ComboBox cob_locnhanvien;

        // Token: 0x040008B0 RID: 2224
        private DataGridView dgv_congviec;

        // Token: 0x040008B1 RID: 2225
        private Button button1;

        // Token: 0x040008B2 RID: 2226
        private Button bt_yeucau;

        // Token: 0x040008B3 RID: 2227
        private Button bt_thuchien;

        // Token: 0x040008B4 RID: 2228
        private DataGridViewTextBoxColumn MACONGVIEC;

        // Token: 0x040008B5 RID: 2229
        private DataGridViewTextBoxColumn nguoitao;

        // Token: 0x040008B6 RID: 2230
        private DataGridViewTextBoxColumn nguoithuchien;

        // Token: 0x040008B7 RID: 2231
        private DataGridViewTextBoxColumn Ngaytao;

        // Token: 0x040008B8 RID: 2232
        private DataGridViewTextBoxColumn denngay;

        // Token: 0x040008B9 RID: 2233
        private DataGridViewTextBoxColumn noidung;

        // Token: 0x040008BA RID: 2234
        private DataGridViewTextBoxColumn Nhanviec;

        // Token: 0x040008BB RID: 2235
        private DataGridViewTextBoxColumn ghichu;

        // Token: 0x040008BC RID: 2236
        private DataGridViewTextBoxColumn MANGUOITAO;

        // Token: 0x040008BD RID: 2237
        private DataGridViewTextBoxColumn MANGUOITHUCHIEN;

        // Token: 0x040008BE RID: 2238
        private Button button2;
    }
}
