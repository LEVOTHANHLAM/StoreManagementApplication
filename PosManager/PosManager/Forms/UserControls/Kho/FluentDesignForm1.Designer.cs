namespace PosManager.Forms.UserControls.Kho
{
    partial class FluentDesignForm1
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
            components = new System.ComponentModel.Container();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label1 = new Label();
            cbbMaKho = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(907, 0);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BackColor = Color.White;
            accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionControl1.Dock = DockStyle.Fill;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1, accordionControlElement2 });
            accordionControl1.Location = new Point(0, 0);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            accordionControl1.Size = new Size(519, 547);
            accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement1.Text = "Element1";
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement2.Text = "Element2";
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(accordionControl1);
            fluentDesignFormContainer1.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Location = new Point(0, 0);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new Size(519, 547);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(fluentDesignFormContainer1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(907, 547);
            splitContainer1.SplitterDistance = 519;
            splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbbMaKho);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 31);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 29;
            label1.Text = "Mã Kho :";
            // 
            // cbbMaKho
            // 
            cbbMaKho.DisplayMember = "DisplayText";
            cbbMaKho.Dock = DockStyle.Right;
            cbbMaKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaKho.FlatStyle = FlatStyle.Flat;
            cbbMaKho.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaKho.FormattingEnabled = true;
            cbbMaKho.Items.AddRange(new object[] { "Admin", "Nhân Viên" });
            cbbMaKho.Location = new Point(80, 0);
            cbbMaKho.Name = "cbbMaKho";
            cbbMaKho.Size = new Size(304, 27);
            cbbMaKho.TabIndex = 30;
            cbbMaKho.ValueMember = "Value";
            // 
            // FluentDesignForm1
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(fluentDesignFormControl1);
            Name = "FluentDesignForm1";
            Size = new Size(907, 547);
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            fluentDesignFormContainer1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private SplitContainer splitContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private Panel panel1;
        private Label label1;
        private ComboBox cbbMaKho;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
    }
}