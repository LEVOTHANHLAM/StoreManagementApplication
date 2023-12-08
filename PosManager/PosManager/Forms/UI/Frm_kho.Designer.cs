using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frm_kho
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Button();
            this.label1 = new Label();
            this.txttenkho = new TextBox();
            this.txtmakho = new TextBox();
            this.label2 = new Label();
            this.dataGridView1 = new DataGridView();
            this.MAKHO = new DataGridViewTextBoxColumn();
            this.tenkho = new DataGridViewTextBoxColumn();
            this.xoa = new DataGridViewButtonColumn();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            base.SuspendLayout();
            this.button1.Location = new Point(391, 13);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "THÊM KHO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new Size(76, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên kho:";
            this.txttenkho.Location = new Point(95, 52);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.Size = new Size(290, 29);
            this.txttenkho.TabIndex = 1;
            this.txtmakho.Location = new Point(95, 14);
            this.txtmakho.MaxLength = 3;
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.Size = new Size(290, 29);
            this.txtmakho.TabIndex = 0;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new Size(71, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã kho:";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.MAKHO,
                this.tenkho,
                this.xoa
            });
            this.dataGridView1.Location = new Point(16, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new Size(450, 318);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += this.dataGridView1_CellClick;
            this.MAKHO.DataPropertyName = "MAKHO";
            this.MAKHO.HeaderText = "Mã Kho";
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.ReadOnly = true;
            this.tenkho.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tenkho.DataPropertyName = "TENKHO";
            this.tenkho.HeaderText = "Tên Kho";
            this.tenkho.Name = "tenkho";
            this.tenkho.ReadOnly = true;
            this.xoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "x";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 45;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(473, 422);
            base.Controls.Add(this.dataGridView1);
            base.Controls.Add(this.txtmakho);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.txttenkho);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button1);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(5);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Frm_kho";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Tạo kho";
            base.Load += this.Frm_kho_Load;
            ((ISupportInitialize)this.dataGridView1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        #endregion
        // Token: 0x040005D1 RID: 1489
        private Button button1;

        // Token: 0x040005D2 RID: 1490
        private Label label1;

        // Token: 0x040005D3 RID: 1491
        private TextBox txttenkho;

        // Token: 0x040005D4 RID: 1492
        private TextBox txtmakho;

        // Token: 0x040005D5 RID: 1493
        private Label label2;

        // Token: 0x040005D6 RID: 1494
        private DataGridView dataGridView1;

        // Token: 0x040005D7 RID: 1495
        private DataGridViewTextBoxColumn MAKHO;

        // Token: 0x040005D8 RID: 1496
        private DataGridViewTextBoxColumn tenkho;

        // Token: 0x040005D9 RID: 1497
        private DataGridViewButtonColumn xoa;
    }
}