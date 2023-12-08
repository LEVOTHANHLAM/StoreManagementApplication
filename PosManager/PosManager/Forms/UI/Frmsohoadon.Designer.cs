using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmsohoadon
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
            this.label1 = new Label();
            this.txtshdtu = new TextBox();
            this.txtshdden = new TextBox();
            this.label2 = new Label();
            this.button1 = new Button();
            this.dgvsohoadon = new DataGridView();
            this.STT = new DataGridViewTextBoxColumn();
            this.sohoadon = new DataGridViewTextBoxColumn();
            this.daxuat = new DataGridViewCheckBoxColumn();
            this.Ngayxuat = new DataGridViewTextBoxColumn();
            this.HUY = new DataGridViewCheckBoxColumn();
            this.Ngayhuy = new DataGridViewTextBoxColumn();
            this.groupBox1 = new GroupBox();
            this.txttim = new TextBox();
            this.radioButton4 = new RadioButton();
            this.radioButton3 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.radioButton1 = new RadioButton();
            this.button2 = new Button();
            ((ISupportInitialize)this.dgvsohoadon).BeginInit();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn từ:";
            this.txtshdtu.Location = new Point(119, 10);
            this.txtshdtu.Name = "txtshdtu";
            this.txtshdtu.Size = new Size(136, 26);
            this.txtshdtu.TabIndex = 0;
            this.txtshdden.Location = new Point(119, 42);
            this.txtshdden.Name = "txtshdden";
            this.txtshdden.Size = new Size(136, 26);
            this.txtshdden.TabIndex = 1;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new Size(108, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số hóa đơn đến:";
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(17, 74);
            this.button1.Name = "button1";
            this.button1.Size = new Size(238, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "THÊM HÓA ĐƠN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.dgvsohoadon.AllowUserToAddRows = false;
            this.dgvsohoadon.AllowUserToDeleteRows = false;
            this.dgvsohoadon.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvsohoadon.BackgroundColor = Color.White;
            this.dgvsohoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsohoadon.Columns.AddRange(new DataGridViewColumn[]
            {
                this.STT,
                this.sohoadon,
                this.daxuat,
                this.Ngayxuat,
                this.HUY,
                this.Ngayhuy
            });
            this.dgvsohoadon.Location = new Point(275, 10);
            this.dgvsohoadon.Name = "dgvsohoadon";
            this.dgvsohoadon.ReadOnly = true;
            this.dgvsohoadon.RowHeadersWidth = 4;
            this.dgvsohoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvsohoadon.Size = new Size(944, 469);
            this.dgvsohoadon.TabIndex = 6;
            this.dgvsohoadon.RowPrePaint += this.dgvsohoadon_RowPrePaint;
            this.STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            this.sohoadon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.sohoadon.DataPropertyName = "sohoadon";
            this.sohoadon.HeaderText = "Số Hóa Đơn";
            this.sohoadon.Name = "sohoadon";
            this.sohoadon.ReadOnly = true;
            this.sohoadon.Width = 120;
            this.daxuat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.daxuat.DataPropertyName = "daxuat";
            this.daxuat.HeaderText = "Đã Xuất";
            this.daxuat.Name = "daxuat";
            this.daxuat.ReadOnly = true;
            this.daxuat.Resizable = DataGridViewTriState.True;
            this.daxuat.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Ngayxuat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ngayxuat.DataPropertyName = "ngayxuat";
            this.Ngayxuat.HeaderText = "Ngày Xuất";
            this.Ngayxuat.Name = "Ngayxuat";
            this.Ngayxuat.ReadOnly = true;
            this.HUY.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.HUY.DataPropertyName = "huy";
            this.HUY.HeaderText = "Hủy";
            this.HUY.Name = "HUY";
            this.HUY.ReadOnly = true;
            this.HUY.Resizable = DataGridViewTriState.True;
            this.HUY.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Ngayhuy.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Ngayhuy.DataPropertyName = "ngayhuy";
            this.Ngayhuy.HeaderText = "Ngày Hủy";
            this.Ngayhuy.Name = "Ngayhuy";
            this.Ngayhuy.ReadOnly = true;
            this.groupBox1.Controls.Add(this.txttim);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(238, 257);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.txttim.ForeColor = Color.FromArgb(192, 64, 0);
            this.txttim.Location = new Point(5, 17);
            this.txttim.Name = "txttim";
            this.txttim.Size = new Size(215, 29);
            this.txttim.TabIndex = 5;
            this.txttim.Text = "Tìm số hóa đơn";
            this.txttim.TextChanged += this.txttim_TextChanged;
            this.txttim.MouseDown += this.txttim_MouseDown;
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new Point(6, 185);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new Size(132, 26);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Hóa đơn hủy";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += this.radioButton4_CheckedChanged;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new Point(6, 138);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new Size(183, 26);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hóa đơn chưa xuất";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += this.radioButton3_CheckedChanged;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new Point(6, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(163, 26);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hóa đơn đã xuất";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += this.radioButton2_CheckedChanged;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new Point(6, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(152, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tất cả hóa đơn";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += this.radioButton1_CheckedChanged;
            this.button2.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(11, 411);
            this.button2.Name = "button2";
            this.button2.Size = new Size(238, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "HỦY HÓA ĐƠN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(0, 192, 192);
            base.ClientSize = new Size(1231, 482);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.dgvsohoadon);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.txtshdden);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.txtshdtu);
            base.Controls.Add(this.label1);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.FromArgb(0, 0, 192);
            base.Margin = new Padding(4);
         //   base.MaximizeBox = false;
           // base.MinimizeBox = false;
            base.Name = "Frmsohoadon";
          //  base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Frmsohoadon";
          //  base.WindowState = FormWindowState.Maximized;
            base.Load += this.Frmsohoadon_Load;
            ((ISupportInitialize)this.dgvsohoadon).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private Label label1;

        // Token: 0x04000C61 RID: 3169
        private TextBox txtshdtu;

        // Token: 0x04000C62 RID: 3170
        private TextBox txtshdden;

        // Token: 0x04000C63 RID: 3171
        private Label label2;

        // Token: 0x04000C64 RID: 3172
        private Button button1;

        // Token: 0x04000C65 RID: 3173
        private DataGridView dgvsohoadon;

        // Token: 0x04000C66 RID: 3174
        private DataGridViewTextBoxColumn STT;

        // Token: 0x04000C67 RID: 3175
        private DataGridViewTextBoxColumn sohoadon;

        // Token: 0x04000C68 RID: 3176
        private DataGridViewCheckBoxColumn daxuat;

        // Token: 0x04000C69 RID: 3177
        private DataGridViewTextBoxColumn Ngayxuat;

        // Token: 0x04000C6A RID: 3178
        private DataGridViewCheckBoxColumn HUY;

        // Token: 0x04000C6B RID: 3179
        private DataGridViewTextBoxColumn Ngayhuy;

        // Token: 0x04000C6C RID: 3180
        private GroupBox groupBox1;

        // Token: 0x04000C6D RID: 3181
        private RadioButton radioButton4;

        // Token: 0x04000C6E RID: 3182
        private RadioButton radioButton3;

        // Token: 0x04000C6F RID: 3183
        private RadioButton radioButton2;

        // Token: 0x04000C70 RID: 3184
        private RadioButton radioButton1;

        // Token: 0x04000C71 RID: 3185
        private TextBox txttim;

        // Token: 0x04000C72 RID: 3186
        private Button button2;
    }
}
