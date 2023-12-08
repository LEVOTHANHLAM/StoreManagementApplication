using System.ComponentModel;

namespace PosManager.Forms.UI
{
    partial class Frmketnoican
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
            this.components = new Container();
            this.cbcheck = new CheckBox();
            this.pncauhinh = new Panel();
            this.label1 = new Label();
            this.comboBox1 = new ComboBox();
            this.checkBox1 = new CheckBox();
            this.cobtencom = new ComboBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label8 = new Label();
            this.btketnoi = new Button();
            this.label7 = new Label();
            this.txttimeout = new TextBox();
            this.label10 = new Label();
            this.cobflow = new ComboBox();
            this.cobtocdo = new ComboBox();
            this.cobstop = new ComboBox();
            this.cobdata = new ComboBox();
            this.cobprity = new ComboBox();
            this.button1 = new Button();
            //this.serialPort1 = new SerialPort(this.components);
            this.btsend = new Button();
            this.txtnoidung = new TextBox();
            this.textBox1 = new TextBox();
            this.button2 = new Button();
            //this.serialPort2 = new SerialPort(this.components);
            this.pncauhinh.SuspendLayout();
            base.SuspendLayout();
            this.cbcheck.AutoSize = true;
            this.cbcheck.Location = new Point(1404, 18);
            this.cbcheck.Margin = new Padding(4);
            this.cbcheck.Name = "cbcheck";
            this.cbcheck.Size = new Size(97, 23);
            this.cbcheck.TabIndex = 42;
            this.cbcheck.Text = "Gửi 1 số đt";
            this.cbcheck.UseVisualStyleBackColor = true;
            this.pncauhinh.BorderStyle = BorderStyle.FixedSingle;
            this.pncauhinh.Controls.Add(this.label1);
            this.pncauhinh.Controls.Add(this.comboBox1);
            this.pncauhinh.Controls.Add(this.checkBox1);
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
            this.pncauhinh.Location = new Point(10, 5);
            this.pncauhinh.Margin = new Padding(4);
            this.pncauhinh.Name = "pncauhinh";
            this.pncauhinh.Size = new Size(388, 431);
            this.pncauhinh.TabIndex = 37;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(4, 333);
            this.label1.Margin = new Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(113, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chọn loại cân";
            this.comboBox1.BackColor = Color.FromArgb(255, 192, 128);
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "Cân CAS ER-PLUS",
                "Cân Liên Tục"
            });
            this.comboBox1.Location = new Point(154, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(226, 27);
            this.comboBox1.TabIndex = 20;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(154, 298);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(104, 23);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Sử dụng cân";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.cobtencom.FormattingEnabled = true;
            this.cobtencom.Location = new Point(154, 12);
            this.cobtencom.Margin = new Padding(4);
            this.cobtencom.Name = "cobtencom";
            this.cobtencom.Size = new Size(226, 27);
            this.cobtencom.TabIndex = 10;
            this.cobtencom.SelectedIndexChanged += this.cobtencom_SelectedIndexChanged;
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
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.Location = new Point(-2, 222);
            this.label7.Margin = new Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(106, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Flow control";
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
            this.cobtocdo.SelectedIndexChanged += this.cobtocdo_SelectedIndexChanged;
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
            this.cobstop.SelectedIndexChanged += this.cobstop_SelectedIndexChanged;
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
            this.cobdata.SelectedIndexChanged += this.cobdata_SelectedIndexChanged;
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
            this.cobprity.SelectedIndexChanged += this.cobprity_SelectedIndexChanged;
            this.button1.BackColor = Color.White;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button1.Location = new Point(1372, 258);
            this.button1.Margin = new Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new Size(177, 111);
            this.button1.TabIndex = 35;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.btsend.BackColor = Color.White;
            this.btsend.FlatStyle = FlatStyle.Flat;
            this.btsend.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btsend.Location = new Point(1374, 72);
            this.btsend.Margin = new Padding(4);
            this.btsend.Name = "btsend";
            this.btsend.Size = new Size(176, 111);
            this.btsend.TabIndex = 32;
            this.btsend.Text = "Gửi Tin Nhắn";
            this.btsend.UseVisualStyleBackColor = false;
            this.txtnoidung.Location = new Point(406, 5);
            this.txtnoidung.Margin = new Padding(4);
            this.txtnoidung.Multiline = true;
            this.txtnoidung.Name = "txtnoidung";
            this.txtnoidung.Size = new Size(614, 159);
            this.txtnoidung.TabIndex = 43;
            this.txtnoidung.Text = "0";
            this.txtnoidung.TextChanged += this.txtnoidung_TextChanged;
            this.textBox1.Location = new Point(406, 182);
            this.textBox1.Margin = new Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(614, 119);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "0";
            this.button2.BackColor = Color.White;
            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.Font = new Font("Times New Roman", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.button2.Location = new Point(626, 379);
            this.button2.Margin = new Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new Size(226, 57);
            this.button2.TabIndex = 45;
            this.button2.Text = "Kiểm tra cân";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += this.button2_Click;
            base.AutoScaleDimensions = new SizeF(9f, 19f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(222, 232, 244);
            base.ClientSize = new Size(1033, 438);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.txtnoidung);
            base.Controls.Add(this.cbcheck);
            base.Controls.Add(this.pncauhinh);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.btsend);
            this.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(4);
          //  base.MaximizeBox = false;
           // base.MinimizeBox = false;
            base.Name = "Frmketnoican";
            //base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Frmketnoican";
            //base.FormClosing += this.Frmketnoican_FormClosing;
            base.Load += this.Frmketnoican_Load;
            this.pncauhinh.ResumeLayout(false);
            this.pncauhinh.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        // Token: 0x040008E1 RID: 2273
        private CheckBox cbcheck;

        // Token: 0x040008E2 RID: 2274
        private Panel pncauhinh;

        // Token: 0x040008E3 RID: 2275
        private ComboBox cobtencom;

        // Token: 0x040008E4 RID: 2276
        private Label label4;

        // Token: 0x040008E5 RID: 2277
        private Label label3;

        // Token: 0x040008E6 RID: 2278
        private Label label6;

        // Token: 0x040008E7 RID: 2279
        private Label label5;

        // Token: 0x040008E8 RID: 2280
        private Label label8;

        // Token: 0x040008E9 RID: 2281
        private Button btketnoi;

        // Token: 0x040008EA RID: 2282
        private Label label7;

        // Token: 0x040008EB RID: 2283
        private TextBox txttimeout;

        // Token: 0x040008EC RID: 2284
        private Label label10;

        // Token: 0x040008ED RID: 2285
        private ComboBox cobflow;

        // Token: 0x040008EE RID: 2286
        private ComboBox cobtocdo;

        // Token: 0x040008EF RID: 2287
        private ComboBox cobstop;

        // Token: 0x040008F0 RID: 2288
        private ComboBox cobdata;

        // Token: 0x040008F1 RID: 2289
        private ComboBox cobprity;

        // Token: 0x040008F2 RID: 2290
        private Button button1;

        // Token: 0x040008F3 RID: 2291
       // private SerialPort serialPort1;

        // Token: 0x040008F4 RID: 2292
        private Button btsend;

        // Token: 0x040008F5 RID: 2293
        private TextBox txtnoidung;

        // Token: 0x040008F6 RID: 2294
        private TextBox textBox1;

        // Token: 0x040008F7 RID: 2295
        private CheckBox checkBox1;

        // Token: 0x040008F8 RID: 2296
        private Button button2;

        // Token: 0x040008F9 RID: 2297
       // private SerialPort serialPort2;

        // Token: 0x040008FA RID: 2298
        private Label label1;

        // Token: 0x040008FB RID: 2299
        private ComboBox comboBox1;
    }
}
