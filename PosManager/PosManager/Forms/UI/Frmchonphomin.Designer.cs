using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmchonphomin
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
            this.btin1 = new Button();
            this.btin2 = new Button();
            this.button1 = new Button();
            base.SuspendLayout();
            this.btin1.BackColor = Color.FromArgb(222, 242, 244);
            this.btin1.BackgroundImageLayout = ImageLayout.Stretch;
            this.btin1.FlatAppearance.BorderColor = Color.Silver;
            this.btin1.FlatAppearance.BorderSize = 2;
            this.btin1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.btin1.FlatStyle = FlatStyle.Flat;
            this.btin1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btin1.ForeColor = Color.Black;
            this.btin1.Location = new Point(1, 2);
            this.btin1.Name = "btin1";
            this.btin1.Size = new Size(320, 143);
            this.btin1.TabIndex = 0;
            this.btin1.Text = "Máy in 1";
            this.btin1.UseVisualStyleBackColor = false;
            this.btin1.Click += this.btin1_Click;
            this.btin2.BackColor = Color.FromArgb(222, 242, 244);
            this.btin2.BackgroundImageLayout = ImageLayout.Stretch;
            this.btin2.FlatAppearance.BorderColor = Color.Silver;
            this.btin2.FlatAppearance.BorderSize = 2;
            this.btin2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.btin2.FlatStyle = FlatStyle.Flat;
            this.btin2.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btin2.ForeColor = Color.Black;
            this.btin2.Location = new Point(1, 151);
            this.btin2.Name = "btin2";
            this.btin2.Size = new Size(320, 150);
            this.btin2.TabIndex = 1;
            this.btin2.Text = "Máy in 2";
            this.btin2.UseVisualStyleBackColor = false;
            this.btin2.Click += this.btin2_Click;
            this.button1.BackColor = Color.Blue;
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(1, 308);
            this.button1.Name = "button1";
            this.button1.Size = new Size(320, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "QUAY LẠI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += this.button1_Click;
            base.AutoScaleDimensions = new SizeF(9f, 18f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(230, 222, 244);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            base.ClientSize = new Size(322, 304);
           // base.ControlBox = false;
            base.Controls.Add(this.button1);
            base.Controls.Add(this.btin2);
            base.Controls.Add(this.btin1);
            this.Font = new Font("Arial", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ForeColor = Color.White;
           // base.KeyPreview = true;
            base.Margin = new Padding(4);
            base.Name = "Frmchonphomin";
          //  base.StartPosition = FormStartPosition.CenterScreen;
           // base.TopMost = true;
            base.Load += this.Frmchonphomin_Load;
            base.KeyDown += this.Frmchonphomin_KeyDown;
            base.ResumeLayout(false);
        }

        #endregion
        // Token: 0x04000668 RID: 1640
        public static string boqua = string.Empty;

        // Token: 0x04000669 RID: 1641
      //  private IContainer components = null;

        // Token: 0x0400066A RID: 1642
        private Button btin1;

        // Token: 0x0400066B RID: 1643
        private Button btin2;

        // Token: 0x0400066C RID: 1644
        private Button button1;
    }
}
