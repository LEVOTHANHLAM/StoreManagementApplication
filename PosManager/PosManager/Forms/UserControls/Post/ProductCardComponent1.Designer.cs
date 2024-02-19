namespace PosManager.Forms.UserControls.Post
{
    partial class ProductCardComponent1
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
            guna2Panel1 = new Panel();
            LabelDonViTinh = new Label();
            btnAddProduct = new Button();
            LabelName = new Label();
            LabelPrice = new Label();
            PictureProductImage = new PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProductImage).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(LabelDonViTinh);
            guna2Panel1.Controls.Add(btnAddProduct);
            guna2Panel1.Controls.Add(LabelName);
            guna2Panel1.Controls.Add(LabelPrice);
            guna2Panel1.Controls.Add(PictureProductImage);
            guna2Panel1.Location = new Point(6, 6);
            guna2Panel1.Margin = new Padding(4, 3, 4, 3);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(314, 166);
            guna2Panel1.TabIndex = 0;
            // 
            // LabelDonViTinh
            // 
            LabelDonViTinh.AutoSize = true;
            LabelDonViTinh.Dock = DockStyle.Right;
            LabelDonViTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDonViTinh.ForeColor = Color.RoyalBlue;
            LabelDonViTinh.Location = new Point(278, 0);
            LabelDonViTinh.Margin = new Padding(4, 0, 4, 0);
            LabelDonViTinh.Name = "LabelDonViTinh";
            LabelDonViTinh.Size = new Size(36, 21);
            LabelDonViTinh.TabIndex = 5;
            LabelDonViTinh.Text = "Lốc";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduct.ForeColor = Color.DimGray;
            btnAddProduct.Location = new Point(10, 108);
            btnAddProduct.Margin = new Padding(4, 3, 4, 3);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(290, 42);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add This Product";
            btnAddProduct.DoubleClick += ButtonAddProduct_Click;
            btnAddProduct.Click += ButtonAddProduct_Click;
            // 
            // LabelName
            // 
            LabelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelName.Location = new Point(100, 21);
            LabelName.Margin = new Padding(4, 0, 4, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(191, 56);
            LabelName.TabIndex = 3;
            LabelName.Text = "WcFloathhhhhhhhhh hhh";
            LabelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelPrice
            // 
            LabelPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelPrice.AutoSize = true;
            LabelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPrice.ForeColor = Color.Maroon;
            LabelPrice.Location = new Point(100, 79);
            LabelPrice.Margin = new Padding(4, 0, 4, 0);
            LabelPrice.Name = "LabelPrice";
            LabelPrice.Size = new Size(91, 21);
            LabelPrice.TabIndex = 2;
            LabelPrice.Text = "200.25PHP";
            // 
            // PictureProductImage
            // 
            PictureProductImage.Location = new Point(10, 21);
            PictureProductImage.Margin = new Padding(4, 3, 4, 3);
            PictureProductImage.Name = "PictureProductImage";
            PictureProductImage.Size = new Size(82, 77);
            PictureProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            PictureProductImage.TabIndex = 1;
            PictureProductImage.TabStop = false;
            // 
            // ProductCardComponent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Margin = new Padding(0);
            Name = "ProductCardComponent1";
            Size = new Size(324, 159);
            Load += ProductCardComponent1_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel guna2Panel1;
        private PictureBox PictureProductImage;
        private Label LabelName;
        private Label LabelPrice;
        private Button btnAddProduct;
        private Label LabelDonViTinh;
    }
}
