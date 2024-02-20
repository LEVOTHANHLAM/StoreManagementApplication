namespace PosManager.Forms.UserControls.Post
{
    partial class OrderItemComponent
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
            panel6 = new Panel();
            guna2Panel1 = new Panel();
            LabelQuantity = new Label();
            ButtonAdd = new Button();
            ButtonMinus = new Button();
            LabelName = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel6.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // LabelSubtotal
            // 
            LabelSubtotal.Dock = DockStyle.Right;
            LabelSubtotal.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSubtotal.ForeColor = Color.Black;
            LabelSubtotal.Location = new Point(145, 64);
            LabelSubtotal.Name = "LabelSubtotal";
            LabelSubtotal.Size = new Size(255, 44);
            LabelSubtotal.TabIndex = 3;
            LabelSubtotal.Text = "4.000.000";
            LabelSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            panel6.Controls.Add(guna2Panel1);
            panel6.Controls.Add(ButtonAdd);
            panel6.Controls.Add(ButtonMinus);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(282, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(118, 38);
            panel6.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.Control;
            guna2Panel1.Controls.Add(LabelQuantity);
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(39, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(42, 38);
            guna2Panel1.TabIndex = 2;
            // 
            // LabelQuantity
            // 
            LabelQuantity.BackColor = Color.Transparent;
            LabelQuantity.Dock = DockStyle.Fill;
            LabelQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelQuantity.Location = new Point(0, 0);
            LabelQuantity.Name = "LabelQuantity";
            LabelQuantity.Size = new Size(42, 38);
            LabelQuantity.TabIndex = 0;
            LabelQuantity.Text = "3";
            LabelQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Dock = DockStyle.Right;
            ButtonAdd.FlatStyle = FlatStyle.Flat;
            ButtonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAdd.ForeColor = Color.Black;
            ButtonAdd.Location = new Point(81, 0);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(37, 38);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "+";
            ButtonAdd.DoubleClick += ButtonAdd_Click;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.Dock = DockStyle.Left;
            ButtonMinus.FlatStyle = FlatStyle.Flat;
            ButtonMinus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMinus.ForeColor = Color.Black;
            ButtonMinus.Location = new Point(0, 0);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(39, 38);
            ButtonMinus.TabIndex = 0;
            ButtonMinus.Text = "-";
            ButtonMinus.DoubleClick += ButtonMinus_Click;
            ButtonMinus.Click += ButtonMinus_Click;
            // 
            // LabelName
            // 
            LabelName.Dock = DockStyle.Fill;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelName.Location = new Point(0, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(282, 38);
            LabelName.TabIndex = 5;
            LabelName.Text = "Tên Sản Phẩm";
            LabelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.icons8_delete_22;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 26);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 0);
            label1.Name = "label1";
            label1.Size = new Size(378, 26);
            label1.TabIndex = 7;
            label1.Text = "     Mã Sản phẩm";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(LabelName);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 38);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 41);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(0, 21);
            label3.Name = "label3";
            label3.Size = new Size(255, 20);
            label3.TabIndex = 5;
            label3.Text = "-1000.000";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 21);
            label2.TabIndex = 4;
            label2.Text = "5.000.000";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrderItemComponent
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
            MaximumSize = new Size(400, 108);
            MinimumSize = new Size(400, 108);
            Name = "OrderItemComponent";
            Size = new Size(400, 108);
            panel6.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LabelSubtotal;
        private Panel panel6;
        private Button ButtonAdd;
        private Button ButtonMinus;
        private Label LabelName;
        // private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Panel guna2Panel1;
        private Label LabelQuantity;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
    }
}
