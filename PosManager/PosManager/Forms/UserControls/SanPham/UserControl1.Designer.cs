namespace PosManager.Forms.UserControls.SanPham
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            LabelSubtotal = new Label();
            btnThemHangHoa = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 25);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(5, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 33);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(LabelSubtotal);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(5, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 45);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 45);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LabelSubtotal
            // 
            LabelSubtotal.Dock = DockStyle.Fill;
            LabelSubtotal.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSubtotal.ForeColor = Color.Black;
            LabelSubtotal.Location = new Point(52, 0);
            LabelSubtotal.Name = "LabelSubtotal";
            LabelSubtotal.Padding = new Padding(5);
            LabelSubtotal.Size = new Size(338, 45);
            LabelSubtotal.TabIndex = 4;
            LabelSubtotal.Text = "Teen San Pham";
            LabelSubtotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThemHangHoa
            // 
            btnThemHangHoa.BackColor = Color.ForestGreen;
            btnThemHangHoa.BackgroundImageLayout = ImageLayout.Zoom;
            btnThemHangHoa.Dock = DockStyle.Fill;
            btnThemHangHoa.FlatStyle = FlatStyle.Flat;
            btnThemHangHoa.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemHangHoa.ForeColor = Color.White;
            btnThemHangHoa.Image = Properties.Resources.icons8_inventory_15;
            btnThemHangHoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemHangHoa.Location = new Point(0, 3);
            btnThemHangHoa.Name = "btnThemHangHoa";
            btnThemHangHoa.Size = new Size(107, 27);
            btnThemHangHoa.TabIndex = 1;
            btnThemHangHoa.Text = "Tồn Kho";
            btnThemHangHoa.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnThemHangHoa);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 3, 7, 3);
            panel4.Size = new Size(114, 33);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(276, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(7, 3, 0, 3);
            panel5.Size = new Size(114, 33);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(114, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(7, 3, 7, 3);
            panel6.Size = new Size(162, 33);
            panel6.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_update_15;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(7, 3);
            button1.Name = "button1";
            button1.Size = new Size(148, 27);
            button1.TabIndex = 2;
            button1.Text = "Chi Tiết";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_delete_15;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(7, 3);
            button2.Name = "button2";
            button2.Size = new Size(107, 27);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(313, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(77, 25);
            label1.TabIndex = 5;
            label1.Text = "Lon";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(313, 25);
            label2.TabIndex = 6;
            label2.Text = "21321424214";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "UserControl1";
            Padding = new Padding(5);
            Size = new Size(400, 113);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        public Label LabelSubtotal;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnThemHangHoa;
        private Button button1;
        private Button button2;
        public Label label2;
        public Label label1;
    }
}
