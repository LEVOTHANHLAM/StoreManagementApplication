using System.ComponentModel;
using System.Drawing.Printing;

namespace PosManager.Forms.UI
{
    partial class Frm_canhbaokho
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.button2 = new Button();
            this.button1 = new Button();
            this.dgvchitiethanghoa = new DataGridView();
            this.printDocument1 = new PrintDocument();
            this.TT = new DataGridViewTextBoxColumn();
            this.MAHANG = new DataGridViewTextBoxColumn();
            this.tenhang = new DataGridViewTextBoxColumn();
            this.dvt = new DataGridViewTextBoxColumn();
            this.soluong = new DataGridViewTextBoxColumn();
            this.sl_ton = new DataGridViewTextBoxColumn();
            this.cl = new DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)this.dgvchitiethanghoa).BeginInit();
            base.SuspendLayout();
            this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvchitiethanghoa, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Font = new Font("Times New Roman", 14f);
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new Size(1008, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1000, 44);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += this.panel1_Paint;
            this.button2.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(162, 1);
            this.button2.Name = "button2";
            this.button2.Size = new Size(144, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "In ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new Size(144, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.dgvchitiethanghoa.AllowUserToAddRows = false;
            this.dgvchitiethanghoa.AllowUserToDeleteRows = false;
            this.dgvchitiethanghoa.BackgroundColor = Color.White;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = SystemColors.Control;
            dataGridViewCellStyle.Font = new Font("Times New Roman", 14f);
            dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.dgvchitiethanghoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgvchitiethanghoa.ColumnHeadersHeight = 27;
            this.dgvchitiethanghoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvchitiethanghoa.Columns.AddRange(new DataGridViewColumn[]
            {
                this.TT,
                this.MAHANG,
                this.tenhang,
                this.dvt,
                this.soluong,
                this.sl_ton,
                this.cl
            });
            this.dgvchitiethanghoa.Dock = DockStyle.Fill;
            this.dgvchitiethanghoa.Location = new Point(4, 55);
            this.dgvchitiethanghoa.Name = "dgvchitiethanghoa";
            this.dgvchitiethanghoa.ReadOnly = true;
            this.dgvchitiethanghoa.RowHeadersVisible = false;
            this.dgvchitiethanghoa.Size = new Size(1000, 384);
            this.dgvchitiethanghoa.TabIndex = 1;
            this.printDocument1.PrintPage += this.printDocument1_PrintPage;
            this.TT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TT.HeaderText = "TT";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            this.TT.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.TT.Width = 50;
            this.MAHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.MAHANG.HeaderText = "Mã hàng";
            this.MAHANG.Name = "MAHANG";
            this.MAHANG.ReadOnly = true;
            this.MAHANG.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.MAHANG.Width = 150;
            this.tenhang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.tenhang.DefaultCellStyle = dataGridViewCellStyle2;
            this.tenhang.HeaderText = "Tên hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            this.tenhang.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dvt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dvt.HeaderText = "Đvt";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dvt.Width = 80;
            this.soluong.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.soluong.DefaultCellStyle = dataGridViewCellStyle3;
            this.soluong.HeaderText = "Tồn tối thiểu";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.soluong.Width = 111;
            this.sl_ton.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.sl_ton.DefaultCellStyle = dataGridViewCellStyle4;
            this.sl_ton.HeaderText = "Tồn hiện tại";
            this.sl_ton.Name = "sl_ton";
            this.sl_ton.ReadOnly = true;
            this.sl_ton.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.sl_ton.Width = 104;
            this.cl.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.cl.DefaultCellStyle = dataGridViewCellStyle5;
            this.cl.HeaderText = "Còn thiếu";
            this.cl.Name = "cl";
            this.cl.ReadOnly = true;
            this.cl.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.cl.Width = 88;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(1008, 443);
            base.Controls.Add(this.tableLayoutPanel1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
            base.Name = "Frm_canhbaokho";
         //   base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Frm_canhbaokho";
            base.Load += this.Frm_canhbaokho_Load;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((ISupportInitialize)this.dgvchitiethanghoa).EndInit();
            base.ResumeLayout(false);
        }


        #endregion
        private TableLayoutPanel tableLayoutPanel1;

        // Token: 0x040008C6 RID: 2246
        private Panel panel1;

        // Token: 0x040008C7 RID: 2247
        private DataGridView dgvchitiethanghoa;

        // Token: 0x040008C8 RID: 2248
        private Button button2;

        // Token: 0x040008C9 RID: 2249
        private Button button1;

        // Token: 0x040008CA RID: 2250
        private PrintDocument printDocument1;

        // Token: 0x040008CB RID: 2251
        private DataGridViewTextBoxColumn TT;

        // Token: 0x040008CC RID: 2252
        private DataGridViewTextBoxColumn MAHANG;

        // Token: 0x040008CD RID: 2253
        private DataGridViewTextBoxColumn tenhang;

        // Token: 0x040008CE RID: 2254
        private DataGridViewTextBoxColumn dvt;

        // Token: 0x040008CF RID: 2255
        private DataGridViewTextBoxColumn soluong;

        // Token: 0x040008D0 RID: 2256
        private DataGridViewTextBoxColumn sl_ton;

        // Token: 0x040008D1 RID: 2257
        private DataGridViewTextBoxColumn cl;
    }
}
