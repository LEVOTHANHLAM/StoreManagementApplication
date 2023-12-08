using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmnhomkhachhang
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
            this.textBox1 = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.label3 = new Label();
            this.dataGridView1 = new DataGridView();
            this.Chon = new DataGridViewButtonColumn();
            this.Manhom = new DataGridViewTextBoxColumn();
            this.tennhom = new DataGridViewTextBoxColumn();
            this.Ghichu = new DataGridViewTextBoxColumn();
            this.xoa = new DataGridViewButtonColumn();
            this.button1 = new Button();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.textBox1.Font = new Font("Times New Roman", 14f);
            this.textBox1.Location = new Point(154, 9);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(607, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += this.textBox1_KeyDown;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(137, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhóm đơn vị:";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new Size(142, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhóm đơn vị:";
            this.textBox2.Font = new Font("Times New Roman", 14f);
            this.textBox2.Location = new Point(154, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(607, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += this.textBox2_KeyDown;
            this.textBox3.Font = new Font("Times New Roman", 14f);
            this.textBox3.Location = new Point(154, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(607, 29);
            this.textBox3.TabIndex = 2;
            this.textBox3.KeyDown += this.textBox3_KeyDown;
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new Size(73, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi chú:";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.Chon,
                this.Manhom,
                this.tennhom,
                this.Ghichu,
                this.xoa
            });
            this.dataGridView1.Location = new Point(17, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.Size = new Size(834, 385);
            this.dataGridView1.TabIndex = 5;
            //this.dataGridView1.CellClick += this.dataGridView1_CellClick;
         //   this.dataGridView1.MouseDoubleClick += this.dataGridView1_MouseDoubleClick;
            this.Chon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            this.Chon.DefaultCellStyle = dataGridViewCellStyle;
            this.Chon.FlatStyle = FlatStyle.Popup;
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.ReadOnly = true;
            this.Chon.Resizable = DataGridViewTriState.True;
            this.Chon.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Chon.Text = "Chọn";
            this.Chon.UseColumnTextForButtonValue = true;
            this.Chon.Width = 50;
            this.Manhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Manhom.DataPropertyName = "manhom";
            this.Manhom.HeaderText = "Mã nhóm";
            this.Manhom.Name = "Manhom";
            this.Manhom.ReadOnly = true;
            this.Manhom.Width = 150;
            this.tennhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.tennhom.DataPropertyName = "tennhom";
            this.tennhom.HeaderText = "Tên nhóm đơn vị";
            this.tennhom.Name = "tennhom";
            this.tennhom.ReadOnly = true;
            this.tennhom.Width = 400;
            this.Ghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ghichu.DataPropertyName = "ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            this.Ghichu.ReadOnly = true;
            this.Ghichu.Width = 188;
            this.xoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.xoa.FlatStyle = FlatStyle.Flat;
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 40;
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(768, 9);
            this.button1.Name = "button1";
            this.button1.Size = new Size(83, 91);
            this.button1.TabIndex = 6;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(222, 232, 244);
            base.ClientSize = new Size(857, 493);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.dataGridView1);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
          //  base.MinimizeBox = false;
            base.Name = "Frmnhomkhachhang";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Nhóm đơn vị";
          //  base.Load += this.Frmnhomkhachhang_Load;
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x04000E6B RID: 3691
        public static string nhomkhachhang = string.Empty;

        // Token: 0x04000E6C RID: 3692
        public static string madonvi = string.Empty;

        // Token: 0x04000E6D RID: 3693
        public static string tendonvi = string.Empty;

        // Token: 0x04000E6E RID: 3694
        public static int index = 0;

        // Token: 0x04000E70 RID: 3696
        private TextBox textBox1;

        // Token: 0x04000E71 RID: 3697
        private Label label1;

        // Token: 0x04000E72 RID: 3698
        private Label label2;

        // Token: 0x04000E73 RID: 3699
        private TextBox textBox2;

        // Token: 0x04000E74 RID: 3700
        private TextBox textBox3;

        // Token: 0x04000E75 RID: 3701
        private Label label3;

        // Token: 0x04000E76 RID: 3702
        private DataGridView dataGridView1;

        // Token: 0x04000E77 RID: 3703
        private Button button1;

        // Token: 0x04000E78 RID: 3704
        private DataGridViewButtonColumn Chon;

        // Token: 0x04000E79 RID: 3705
        private DataGridViewTextBoxColumn Manhom;

        // Token: 0x04000E7A RID: 3706
        private DataGridViewTextBoxColumn tennhom;

        // Token: 0x04000E7B RID: 3707
        private DataGridViewTextBoxColumn Ghichu;

        // Token: 0x04000E7C RID: 3708
        private DataGridViewButtonColumn xoa;
    }
}
