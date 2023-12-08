using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class FrmGuitinnhan
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
            this.button1 = new Button();
            this.textBox1 = new TextBox();
            this.dataGridView1 = new DataGridView();
            this.button2 = new Button();
            this.button3 = new Button();
            this.tt = new DataGridViewTextBoxColumn();
            this.TEN = new DataGridViewTextBoxColumn();
            this.SDT = new DataGridViewTextBoxColumn();
            this.DIACHI = new DataGridViewTextBoxColumn();
            this.chon = new DataGridViewCheckBoxColumn();
            this.textBox2 = new TextBox();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(755, 30);
            this.button1.Name = "button1";
            this.button1.Size = new Size(158, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gửi tin nhắn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.textBox1.Font = new Font("Times New Roman", 14f);
            this.textBox1.Location = new Point(2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(750, 120);
            this.textBox1.TabIndex = 2;
            this.textBox1.Tag = "Nhập nội dung tin nhắn ( không dấu)";
            this.textBox1.Text = "Nhập nội dung tin nhắn ( không dấu)";
            this.textBox1.Enter += this.textBox1_Enter;
            this.textBox1.Leave += this.textBox1_Leave;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
            this.dataGridView1.BackgroundColor = Color.FromArgb(222, 232, 244);
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.tt,
                this.TEN,
                this.SDT,
                this.DIACHI,
                this.chon
            });
            this.dataGridView1.Location = new Point(2, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new Size(911, 338);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            this.dataGridView1.CellMouseClick += this.dataGridView1_CellMouseClick;
            this.dataGridView1.Click += this.dataGridView1_Click;
            this.button2.Font = new Font("Times New Roman", 12f);
            this.button2.Location = new Point(755, 85);
            this.button2.Name = "button2";
            this.button2.Size = new Size(158, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Chọn hết";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.button3.Font = new Font("Times New Roman", 12f);
            this.button3.Location = new Point(837, 85);
            this.button3.Name = "button3";
            this.button3.Size = new Size(76, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Bỏ chọn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += this.button3_Click;
            this.tt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tt.DefaultCellStyle = dataGridViewCellStyle;
            this.tt.HeaderText = "TT";
            this.tt.Name = "tt";
            this.tt.Width = 50;
            this.TEN.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.TEN.DataPropertyName = "TENDONVI";
            this.TEN.HeaderText = "Khách Hàng";
            this.TEN.Name = "TEN";
            this.TEN.Width = 300;
            this.SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.Width = 200;
            this.DIACHI.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 300;
            this.chon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.chon.DataPropertyName = "chon";
            this.chon.FlatStyle = FlatStyle.System;
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            this.chon.TrueValue = "";
            this.chon.Width = 45;
            this.textBox2.Location = new Point(755, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(158, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "+84";
            this.textBox2.KeyDown += this.textBox2_KeyDown;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(918, 468);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.dataGridView1);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
         //   base.MinimizeBox = false;
            base.Name = "FrmGuitinnhan";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gửi tin nhắn đến khách hàng";
            base.Load += this.FrmGuitinnhan_Load;
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private Button button1;

        // Token: 0x04000859 RID: 2137
        private TextBox textBox1;

        // Token: 0x0400085A RID: 2138
        private DataGridView dataGridView1;

        // Token: 0x0400085B RID: 2139
        private Button button2;

        // Token: 0x0400085C RID: 2140
        private Button button3;

        // Token: 0x0400085D RID: 2141
        private DataGridViewTextBoxColumn tt;

        // Token: 0x0400085E RID: 2142
        private DataGridViewTextBoxColumn TEN;

        // Token: 0x0400085F RID: 2143
        private DataGridViewTextBoxColumn SDT;

        // Token: 0x04000860 RID: 2144
        private DataGridViewTextBoxColumn DIACHI;

        // Token: 0x04000861 RID: 2145
        private DataGridViewCheckBoxColumn chon;

        // Token: 0x04000862 RID: 2146
        private TextBox textBox2;
    }
}
