namespace PosManager.Forms.UI
{
    partial class Frmyesno
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
            this.button1 = new Button();
            this.button2 = new Button();
            this.textBox1 = new TextBox();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 14.5f);
            this.label1.Location = new Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(332, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẠN CÓ MUỐN THÊM MỚI KHÔNG?";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.button1.Font = new Font("Times New Roman", 20f);
            this.button1.Location = new Point(48, 83);
            this.button1.Name = "button1";
            this.button1.Size = new Size(142, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Có";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            this.button2.Font = new Font("Times New Roman", 20f);
            this.button2.Location = new Point(241, 83);
            this.button2.Name = "button2";
            this.button2.Size = new Size(137, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Không";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += this.button2_Click;
            this.textBox1.BackColor = Color.PaleTurquoise;
            this.textBox1.BorderStyle = BorderStyle.None;
            this.textBox1.Location = new Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(417, 63);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            base.AutoScaleDimensions = new SizeF(10f, 21f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.PaleTurquoise;
            base.ClientSize = new Size(422, 147);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label1);
            this.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
        //    base.KeyPreview = true;
            base.Margin = new Padding(5);
          //  base.MaximizeBox = false;
            this.MaximumSize = new Size(438, 186);
          //  base.MinimizeBox = false;
            this.MinimumSize = new Size(438, 186);
            base.Name = "Frmyesno";
           // base.StartPosition = FormStartPosition.CenterScreen;
          //  base.TopMost = true;
            base.Load += this.Frmyesno_Load;
            base.KeyDown += this.Frmyesno_KeyDown;
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private Label label1;

        // Token: 0x04000E52 RID: 3666
        private Button button1;

        // Token: 0x04000E53 RID: 3667
        private Button button2;

        // Token: 0x04000E54 RID: 3668
        private TextBox textBox1;
    }
}
