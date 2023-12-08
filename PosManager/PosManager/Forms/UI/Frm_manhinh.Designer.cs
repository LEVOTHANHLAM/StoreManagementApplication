using System.ComponentModel;
using System.IO.Ports;

namespace PosManager.Forms.UI
{
    partial class Frm_manhinh
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
            this.components = new Container();
            this.button2 = new Button();
            this.cobtencom = new ComboBox();
            this.btsend = new Button();
            this.serialPort1 = new SerialPort(this.components);
            this.label4 = new Label();
            this.label3 = new Label();
            this.button1 = new Button();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label8 = new Label();
            this.btketnoi = new Button();
            this.txttimeout = new TextBox();
            this.label10 = new Label();
            this.cbcheck = new CheckBox();
            this.pncauhinh = new Panel();
            this.button3 = new Button();
            this.txt2 = new TextBox();
            this.label2 = new Label();
            this.txt1 = new TextBox();
            this.label1 = new Label();
            this.label7 = new Label();
            this.cobflow = new ComboBox();
            this.cobtocdo = new ComboBox();
            this.cobstop = new ComboBox();
            this.cobdata = new ComboBox();
            this.cobprity = new ComboBox();
            this.serialPort2 = new SerialPort(this.components);
            this.pncauhinh.SuspendLayout();
            base.SuspendLayout();
            this.button2.BackColor = Color.White;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(398, 81);
            this.button2.Margin = new Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new Size(226, 57);
            this.button2.TabIndex = 52;
            this.button2.Text = "Test màn hình";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            this.cobtencom.FormattingEnabled = true;
            this.cobtencom.Location = new Point(154, 12);
            this.cobtencom.Margin = new Padding(4);
            this.cobtencom.Name = "cobtencom";
            this.cobtencom.Size = new Size(226, 27);
            this.cobtencom.TabIndex = 10;
            this.btsend.BackColor = Color.White;
            this.btsend.FlatStyle = FlatStyle.Flat;
            this.btsend.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btsend.Location = new Point(1373, 69);
            this.btsend.Margin = new Padding(4);
            this.btsend.Name = "btsend";
            this.btsend.Size = new Size(176, 111);
            this.btsend.TabIndex = 46;
            this.btsend.Text = "Gửi Tin Nhắn";
            this.btsend.UseVisualStyleBackColor = false;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(-2, 15);
            this.label4.Margin = new Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(99, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cổng COM";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(-2, 49);
            this.label3.Margin = new Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(66, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tốc độ";
            this.button1.BackColor = Color.White;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(1371, 255);
            this.button1.Margin = new Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new Size(177, 111);
            this.button1.TabIndex = 47;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.Location = new Point(-2, 96);
            this.label6.Margin = new Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new Size(68, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data bit";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.Location = new Point(-2, 135);
            this.label5.Margin = new Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(77, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity bit";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.Location = new Point(-2, 178);
            this.label8.Margin = new Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(70, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Stop bit";
            this.btketnoi.BackColor = Color.White;
            this.btketnoi.FlatStyle = FlatStyle.Flat;
            this.btketnoi.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btketnoi.Location = new Point(154, 373);
            this.btketnoi.Margin = new Padding(4);
            this.btketnoi.Name = "btketnoi";
            this.btketnoi.Size = new Size(226, 57);
            this.btketnoi.TabIndex = 18;
            this.btketnoi.Text = "Kết Nối";
            this.btketnoi.UseVisualStyleBackColor = false;
            this.btketnoi.Click += this.btketnoi_Click;
            this.txttimeout.Location = new Point(154, 264);
            this.txttimeout.Margin = new Padding(4);
            this.txttimeout.Name = "txttimeout";
            this.txttimeout.Size = new Size(226, 26);
            this.txttimeout.TabIndex = 16;
            this.txttimeout.Text = "0";
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.Location = new Point(-2, 267);
            this.label10.Margin = new Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new Size(76, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Time out";
            this.cbcheck.AutoSize = true;
            this.cbcheck.Location = new Point(1403, 15);
            this.cbcheck.Margin = new Padding(4);
            this.cbcheck.Name = "cbcheck";
            this.cbcheck.Size = new Size(97, 23);
            this.cbcheck.TabIndex = 49;
            this.cbcheck.Text = "Gửi 1 số đt";
            this.cbcheck.UseVisualStyleBackColor = true;
            this.pncauhinh.BorderStyle = BorderStyle.FixedSingle;
            this.pncauhinh.Controls.Add(this.txt2);
            this.pncauhinh.Controls.Add(this.label2);
            this.pncauhinh.Controls.Add(this.txt1);
            this.pncauhinh.Controls.Add(this.label1);
            this.pncauhinh.Controls.Add(this.cobtencom);
            this.pncauhinh.Controls.Add(this.label4);
            this.pncauhinh.Controls.Add(this.label3);
            this.pncauhinh.Controls.Add(this.label6);
            this.pncauhinh.Controls.Add(this.label5);
            this.pncauhinh.Controls.Add(this.label8);
            this.pncauhinh.Controls.Add(this.btketnoi);
            this.pncauhinh.Controls.Add(this.label7);
            this.pncauhinh.Controls.Add(this.txttimeout);
            this.pncauhinh.Controls.Add(this.label10);
            this.pncauhinh.Controls.Add(this.cobflow);
            this.pncauhinh.Controls.Add(this.cobtocdo);
            this.pncauhinh.Controls.Add(this.cobstop);
            this.pncauhinh.Controls.Add(this.cobdata);
            this.pncauhinh.Controls.Add(this.cobprity);
            this.pncauhinh.Location = new Point(9, 2);
            this.pncauhinh.Margin = new Padding(4);
            this.pncauhinh.Name = "pncauhinh";
            this.pncauhinh.Size = new Size(388, 431);
            this.pncauhinh.TabIndex = 48;
            this.button3.BackColor = Color.White;
            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button3.Location = new Point(398, 2);
            this.button3.Margin = new Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new Size(226, 57);
            this.button3.TabIndex = 23;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += this.button3_Click;
            this.txt2.Location = new Point(154, 332);
            this.txt2.Margin = new Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new Size(226, 26);
            this.txt2.TabIndex = 22;
            this.txt2.Text = "0";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(-2, 335);
            this.label2.Margin = new Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(65, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dòng 2";
            this.txt1.Location = new Point(154, 298);
            this.txt1.Margin = new Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new Size(226, 26);
            this.txt1.TabIndex = 20;
            this.txt1.Text = "0";
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(-2, 301);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(65, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dòng 1";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(-2, 222);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(106, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Flow control";
            this.cobflow.FormattingEnabled = true;
            this.cobflow.Items.AddRange(new object[]
            {
                "No",
                "XON/XOFF",
                "Hardware"
            });
            this.cobflow.Location = new Point(154, 220);
            this.cobflow.Margin = new Padding(4);
            this.cobflow.Name = "cobflow";
            this.cobflow.Size = new Size(226, 27);
            this.cobflow.TabIndex = 13;
            this.cobflow.Text = "No";
            this.cobtocdo.FormattingEnabled = true;
            this.cobtocdo.Items.AddRange(new object[]
            {
                "1200",
                "2400",
                "4800",
                "9600",
                "19200",
                "38400",
                "115200"
            });
            this.cobtocdo.Location = new Point(154, 47);
            this.cobtocdo.Margin = new Padding(4);
            this.cobtocdo.Name = "cobtocdo";
            this.cobtocdo.Size = new Size(226, 27);
            this.cobtocdo.TabIndex = 10;
            this.cobtocdo.Text = "115200";
            this.cobstop.FormattingEnabled = true;
            this.cobstop.Items.AddRange(new object[]
            {
                "1",
                "1.5",
                "2"
            });
            this.cobstop.Location = new Point(154, 174);
            this.cobstop.Margin = new Padding(4);
            this.cobstop.Name = "cobstop";
            this.cobstop.Size = new Size(226, 27);
            this.cobstop.TabIndex = 12;
            this.cobstop.Text = "1";
            this.cobdata.FormattingEnabled = true;
            this.cobdata.Items.AddRange(new object[]
            {
                "5",
                "6",
                "7",
                "8"
            });
            this.cobdata.Location = new Point(154, 89);
            this.cobdata.Margin = new Padding(4);
            this.cobdata.Name = "cobdata";
            this.cobdata.Size = new Size(226, 27);
            this.cobdata.TabIndex = 10;
            this.cobdata.Text = "8";
            this.cobprity.FormattingEnabled = true;
            this.cobprity.Items.AddRange(new object[]
            {
                "None",
                "Odd",
                "Even",
                "Mark",
                "Space"
            });
            this.cobprity.Location = new Point(154, 131);
            this.cobprity.Margin = new Padding(4);
            this.cobprity.Name = "cobprity";
            this.cobprity.Size = new Size(226, 27);
            this.cobprity.TabIndex = 11;
            this.cobprity.Text = "None";
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(633, 449);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.btsend);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.cbcheck);
            base.Controls.Add(this.pncauhinh);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
            base.Name = "Frm_manhinh";
            this.Text = "Frm_manhinh";
            base.FormClosed += this.Frm_manhinh_FormClosed;
            base.Load += this.Frm_manhinh_Load;
            this.pncauhinh.ResumeLayout(false);
            this.pncauhinh.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        private Button button2;

        // Token: 0x040010D7 RID: 4311
        private ComboBox cobtencom;

        // Token: 0x040010D8 RID: 4312
        private Button btsend;

        // Token: 0x040010D9 RID: 4313
        private SerialPort serialPort1;

        // Token: 0x040010DA RID: 4314
        private Label label4;

        // Token: 0x040010DB RID: 4315
        private Label label3;

        // Token: 0x040010DC RID: 4316
        private Button button1;

        // Token: 0x040010DD RID: 4317
        private Label label6;

        // Token: 0x040010DE RID: 4318
        private Label label5;

        // Token: 0x040010DF RID: 4319
        private Label label8;

        // Token: 0x040010E0 RID: 4320
        private Button btketnoi;

        // Token: 0x040010E1 RID: 4321
        private TextBox txttimeout;

        // Token: 0x040010E2 RID: 4322
        private Label label10;

        // Token: 0x040010E3 RID: 4323
        private CheckBox cbcheck;

        // Token: 0x040010E4 RID: 4324
        private Panel pncauhinh;

        // Token: 0x040010E5 RID: 4325
        private Label label7;

        // Token: 0x040010E6 RID: 4326
        private ComboBox cobflow;

        // Token: 0x040010E7 RID: 4327
        private ComboBox cobtocdo;

        // Token: 0x040010E8 RID: 4328
        private ComboBox cobstop;

        // Token: 0x040010E9 RID: 4329
        private ComboBox cobdata;

        // Token: 0x040010EA RID: 4330
        private ComboBox cobprity;

        // Token: 0x040010EB RID: 4331
        private SerialPort serialPort2;

        // Token: 0x040010EC RID: 4332
        private TextBox txt2;

        // Token: 0x040010ED RID: 4333
        private Label label2;

        // Token: 0x040010EE RID: 4334
        private TextBox txt1;

        // Token: 0x040010EF RID: 4335
        private Label label1;

        // Token: 0x040010F0 RID: 4336
        private Button button3;
    }
}