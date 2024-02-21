namespace PosManager.Forms.UserControls.Kho
{
    partial class XtraUserControl1
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
            filterEditorControl1 = new DevExpress.DataAccess.UI.FilterEditorControl();
            filterControl1 = new DevExpress.XtraEditors.FilterControl();
            SuspendLayout();
            // 
            // filterEditorControl1
            // 
            filterEditorControl1.ActiveView = DevExpress.XtraFilterEditor.FilterEditorActiveView.Visual;
            filterEditorControl1.AppearanceEmptyValueColor = Color.Empty;
            filterEditorControl1.AppearanceFieldNameColor = Color.Empty;
            filterEditorControl1.AppearanceGroupOperatorColor = Color.Empty;
            filterEditorControl1.AppearanceOperatorColor = Color.Empty;
            filterEditorControl1.AppearanceValueColor = Color.Empty;
            filterEditorControl1.IsModified = false;
            filterEditorControl1.Location = new Point(0, 3);
            filterEditorControl1.Name = "filterEditorControl1";
            filterEditorControl1.NodeSeparatorHeight = 2;
            filterEditorControl1.Size = new Size(273, 186);
            filterEditorControl1.TabIndex = 0;
            filterEditorControl1.Text = "aaaaaaa";
            filterEditorControl1.UseMenuForOperandsAndOperators = false;
            filterEditorControl1.Click += filterEditorControl1_Click;
            // 
            // filterControl1
            // 
            filterControl1.Location = new Point(423, 102);
            filterControl1.Name = "filterControl1";
            filterControl1.NodeSeparatorHeight = 2;
            filterControl1.Size = new Size(200, 100);
            filterControl1.TabIndex = 1;
            filterControl1.Text = "filterControl1";
            // 
            // XtraUserControl1
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(filterControl1);
            Controls.Add(filterEditorControl1);
            Name = "XtraUserControl1";
            Size = new Size(739, 406);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.DataAccess.UI.FilterEditorControl filterEditorControl1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
    }
}
