namespace PosManager.Forms.UserControls.Kho
{
    partial class UserControl1
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
            numericUpDown1 = new NumericUpDown();
            LabelName = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            cbbMaKho = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // LabelSubtotal
            // 
            LabelSubtotal.Dock = DockStyle.Bottom;
            LabelSubtotal.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSubtotal.ForeColor = Color.Black;
            LabelSubtotal.Location = new Point(5, 74);
            LabelSubtotal.Name = "LabelSubtotal";
            LabelSubtotal.Size = new Size(384, 29);
            LabelSubtotal.TabIndex = 3;
            LabelSubtotal.Text = "4.000.000";
            LabelSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Right;
            numericUpDown1.Location = new Point(303, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(83, 22);
            numericUpDown1.TabIndex = 0;
            // 
            // LabelName
            // 
            LabelName.Dock = DockStyle.Fill;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelName.Location = new Point(0, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(386, 23);
            LabelName.TabIndex = 5;
            LabelName.Text = "Tên Sản Phẩm";
            LabelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 22);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 0);
            label1.Name = "label1";
            label1.Size = new Size(362, 22);
            label1.TabIndex = 9;
            label1.Text = "     Mã Sản phẩm";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.icons8_delete_22;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(LabelName);
            panel2.Location = new Point(3, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 23);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(cbbMaKho);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(5, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 24);
            panel3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Right;
            dateTimePicker1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(184, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 21);
            dateTimePicker1.TabIndex = 32;
            // 
            // cbbMaKho
            // 
            cbbMaKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbMaKho.DisplayMember = "DisplayText";
            cbbMaKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaKho.FlatStyle = FlatStyle.Flat;
            cbbMaKho.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaKho.FormattingEnabled = true;
            cbbMaKho.Items.AddRange(new object[] { "Admin", "Nhân Viên" });
            cbbMaKho.Location = new Point(3, 1);
            cbbMaKho.Name = "cbbMaKho";
            cbbMaKho.Size = new Size(175, 22);
            cbbMaKho.TabIndex = 31;
            cbbMaKho.ValueMember = "Value";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(LabelSubtotal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "UserControl1";
            Padding = new Padding(5);
            Size = new Size(394, 108);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LabelSubtotal;
        private Label LabelName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbbMaKho;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
    }
}
