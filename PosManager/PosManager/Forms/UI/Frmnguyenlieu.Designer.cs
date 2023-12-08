using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmnguyenlieu
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
            this.panel1 = new Panel();
            this.btluu = new Button();
            this.txttenncc = new TextBox();
            this.txtmancc = new TextBox();
            this.txtdg = new TextBox();
            this.txtdvt = new TextBox();
            this.txtten = new TextBox();
            this.txtma = new TextBox();
            this.dgvnl = new DataGridView();
            this.xoa = new DataGridViewButtonColumn();
            this.MA = new DataGridViewTextBoxColumn();
            this.ten = new DataGridViewTextBoxColumn();
            this.dvt = new DataGridViewTextBoxColumn();
            this.ncc = new DataGridViewTextBoxColumn();
            this.GHICHU = new DataGridViewTextBoxColumn();
            this.textBox1 = new TextBox();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dgvnl).BeginInit();
            base.SuspendLayout();
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btluu);
            this.panel1.Controls.Add(this.txttenncc);
            this.panel1.Controls.Add(this.txtmancc);
            this.panel1.Controls.Add(this.txtdg);
            this.panel1.Controls.Add(this.txtdvt);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Location = new Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(858, 99);
            this.panel1.TabIndex = 0;
            this.btluu.Font = new Font("Times New Roman", 17f);
            this.btluu.Location = new Point(732, 3);
            this.btluu.Name = "btluu";
            this.btluu.Size = new Size(123, 93);
            this.btluu.TabIndex = 6;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += this.btluu_Click;
            this.txttenncc.BackColor = Color.White;
            this.txttenncc.Font = new Font("Times New Roman", 14f);
            this.txttenncc.Location = new Point(330, 65);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.ReadOnly = true;
            this.txttenncc.Size = new Size(325, 29);
            this.txttenncc.TabIndex = 5;
            this.txttenncc.Tag = "Tên nhà cung cấp";
            this.txttenncc.Text = "Tên nhà cung cấp";
            this.txtmancc.Font = new Font("Times New Roman", 14f);
            this.txtmancc.Location = new Point(155, 65);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new Size(172, 29);
            this.txtmancc.TabIndex = 4;
            this.txtmancc.Tag = "Mã nhà cung cấp";
            this.txtmancc.Text = "Mã nhà cung cấp";
            this.txtmancc.TextChanged += this.txtmancc_TextChanged;
            this.txtmancc.Enter += this.txtmancc_Enter;
            this.txtmancc.KeyDown += this.txtmancc_KeyDown;
            this.txtmancc.Leave += this.txtmancc_Leave;
            this.txtdg.Font = new Font("Times New Roman", 14f);
            this.txtdg.Location = new Point(330, 34);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new Size(325, 29);
            this.txtdg.TabIndex = 3;
            this.txtdg.Tag = "Ghi chú";
            this.txtdg.Text = "Ghi chú";
            this.txtdg.Enter += this.txtdg_Enter;
            this.txtdg.KeyDown += this.txtdg_KeyDown;
            this.txtdg.Leave += this.txtdg_Leave;
            this.txtdvt.Font = new Font("Times New Roman", 14f);
            this.txtdvt.Location = new Point(155, 34);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new Size(172, 29);
            this.txtdvt.TabIndex = 2;
            this.txtdvt.Tag = "Đơn vị tính";
            this.txtdvt.Text = "Đơn vị tính";
            this.txtdvt.Enter += this.txtdvt_Enter;
            this.txtdvt.KeyDown += this.txtdvt_KeyDown;
            this.txtdvt.Leave += this.txtdvt_Leave;
            this.txtten.Font = new Font("Times New Roman", 14f);
            this.txtten.Location = new Point(330, 3);
            this.txtten.Name = "txtten";
            this.txtten.Size = new Size(325, 29);
            this.txtten.TabIndex = 1;
            this.txtten.Tag = "Tên nguyên liệu";
            this.txtten.Text = "Tên nguyên liệu";
            this.txtten.Enter += this.txtten_Enter;
            this.txtten.KeyDown += this.txtten_KeyDown;
            this.txtten.Leave += this.txtten_Leave;
            this.txtma.Font = new Font("Times New Roman", 14f);
            this.txtma.Location = new Point(155, 3);
            this.txtma.Name = "txtma";
            this.txtma.Size = new Size(172, 29);
            this.txtma.TabIndex = 0;
            this.txtma.Tag = "Mã nguyên liệu";
            this.txtma.Text = "Mã nguyên liệu";
            this.txtma.Enter += this.txtma_Enter;
            this.txtma.KeyDown += this.txtma_KeyDown;
            this.txtma.Leave += this.txtma_Leave;
            this.dgvnl.AllowUserToAddRows = false;
            this.dgvnl.AllowUserToDeleteRows = false;
            this.dgvnl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvnl.BackgroundColor = Color.LightBlue;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvnl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvnl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnl.Columns.AddRange(new DataGridViewColumn[]
            {
                this.xoa,
                this.MA,
                this.ten,
                this.dvt,
                this.ncc,
                this.GHICHU
            });
            this.dgvnl.Location = new Point(1, 104);
            this.dgvnl.Name = "dgvnl";
            this.dgvnl.ReadOnly = true;
            this.dgvnl.RowHeadersVisible = false;
            this.dgvnl.RowTemplate.Height = 27;
            this.dgvnl.Size = new Size(858, 451);
            this.dgvnl.TabIndex = 1;
            this.dgvnl.MouseClick += this.dgvnl_MouseClick;
            this.xoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.xoa.FlatStyle = FlatStyle.System;
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Resizable = DataGridViewTriState.True;
            this.xoa.SortMode = DataGridViewColumnSortMode.Automatic;
            this.xoa.Text = "xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 40;
            this.MA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MA.DataPropertyName = "MAHANGHOA";
            this.MA.HeaderText = "Mã nguyên liệu";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Width = 150;
            this.ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ten.DataPropertyName = "TENHANGHOA";
            this.ten.HeaderText = "Tên nguyên liệu";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 200;
            this.dvt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dvt.DataPropertyName = "DONVITINH";
            this.dvt.HeaderText = "ĐVT";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 80;
            this.ncc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.ncc.DataPropertyName = "TENDONVI";
            this.ncc.HeaderText = "Tên nhà cung cấp";
            this.ncc.Name = "ncc";
            this.ncc.ReadOnly = true;
            this.ncc.Width = 300;
            this.GHICHU.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.GHICHU.Width = 101;
            this.textBox1.BackColor = Color.WhiteSmoke;
            this.textBox1.Font = new Font("Times New Roman", 12f);
            this.textBox1.ForeColor = Color.Red;
            this.textBox1.Location = new Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(146, 91);
            this.textBox1.TabIndex = 7;
            this.textBox1.Tag = "";
            this.textBox1.Text = "* Mã có thể bỏ trống\r\n* Tên nguyên liệu và đơn vị tính bắt buộc nhập";
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(860, 554);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.dgvnl);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
           // base.MinimizeBox = false;
            base.Name = "Frmnguyenlieu";
         //   base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "NHẬP TÊN NGUYÊN LIỆU";
            base.Load += this.Frmnguyenlieu_Load;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)this.dgvnl).EndInit();
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x040011E5 RID: 4581
        private Panel panel1;

        // Token: 0x040011E6 RID: 4582
        private TextBox txttenncc;

        // Token: 0x040011E7 RID: 4583
        private TextBox txtmancc;

        // Token: 0x040011E8 RID: 4584
        private TextBox txtdg;

        // Token: 0x040011E9 RID: 4585
        private TextBox txtdvt;

        // Token: 0x040011EA RID: 4586
        private TextBox txtten;

        // Token: 0x040011EB RID: 4587
        private TextBox txtma;

        // Token: 0x040011EC RID: 4588
        private Button btluu;

        // Token: 0x040011ED RID: 4589
        private DataGridView dgvnl;

        // Token: 0x040011EE RID: 4590
        private DataGridViewButtonColumn xoa;

        // Token: 0x040011EF RID: 4591
        private DataGridViewTextBoxColumn MA;

        // Token: 0x040011F0 RID: 4592
        private DataGridViewTextBoxColumn ten;

        // Token: 0x040011F1 RID: 4593
        private DataGridViewTextBoxColumn dvt;

        // Token: 0x040011F2 RID: 4594
        private DataGridViewTextBoxColumn ncc;

        // Token: 0x040011F3 RID: 4595
        private DataGridViewTextBoxColumn GHICHU;

        // Token: 0x040011F4 RID: 4596
        private TextBox textBox1;
    }
}
