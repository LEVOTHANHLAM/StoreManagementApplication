namespace Krypton_toolKitDemo
{
    partial class fPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhanQuyen));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            dtgvAccount = new DataGridView();
            cTen = new DataGridViewTextBoxColumn();
            cView = new DataGridViewCheckBoxColumn();
            cCreate = new DataGridViewCheckBoxColumn();
            cUpdate = new DataGridViewCheckBoxColumn();
            cDelete = new DataGridViewCheckBoxColumn();
            cIdUser = new DataGridViewTextBoxColumn();
            cFunctionId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image");
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed");
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking");
            kryptonPalette1.ButtonSpecs.FormMax.Image = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image");
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed");
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking");
            kryptonPalette1.ButtonSpecs.FormMin.Image = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image");
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed");
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking");
            kryptonPalette1.ButtonSpecs.FormRestore.Image = (Image)resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.Image");
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.White;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // dtgvAccount
            // 
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.AllowUserToDeleteRows = false;
            dtgvAccount.AllowUserToResizeRows = false;
            dtgvAccount.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Columns.AddRange(new DataGridViewColumn[] { cTen, cView, cCreate, cUpdate, cDelete, cIdUser, cFunctionId });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvAccount.Dock = DockStyle.Fill;
            dtgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgvAccount.Location = new Point(0, 0);
            dtgvAccount.Margin = new Padding(2, 2, 2, 2);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersVisible = false;
            dtgvAccount.RowTemplate.Height = 25;
            dtgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAccount.Size = new Size(866, 432);
            dtgvAccount.TabIndex = 16;
            dtgvAccount.CellContentClick += dtgvAccount_CellContentClick;
            // 
            // cTen
            // 
            cTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cTen.DefaultCellStyle = dataGridViewCellStyle2;
            cTen.FillWeight = 300F;
            cTen.HeaderText = "Tên";
            cTen.Name = "cTen";
            // 
            // cView
            // 
            cView.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cView.HeaderText = "Xem";
            cView.Name = "cView";
            cView.Resizable = DataGridViewTriState.True;
            cView.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cCreate
            // 
            cCreate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cCreate.HeaderText = "Thêm";
            cCreate.Name = "cCreate";
            cCreate.ReadOnly = true;
            cCreate.Resizable = DataGridViewTriState.True;
            cCreate.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cUpdate
            // 
            cUpdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cUpdate.HeaderText = "Sửa";
            cUpdate.Name = "cUpdate";
            cUpdate.ReadOnly = true;
            cUpdate.Resizable = DataGridViewTriState.True;
            cUpdate.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cDelete
            // 
            cDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cDelete.HeaderText = "Xoá";
            cDelete.Name = "cDelete";
            cDelete.ReadOnly = true;
            cDelete.Resizable = DataGridViewTriState.True;
            cDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cIdUser
            // 
            cIdUser.HeaderText = "cIdUser";
            cIdUser.Name = "cIdUser";
            cIdUser.ReadOnly = true;
            cIdUser.Visible = false;
            // 
            // cFunctionId
            // 
            cFunctionId.HeaderText = "cFunctionId";
            cFunctionId.Name = "cFunctionId";
            cFunctionId.ReadOnly = true;
            cFunctionId.Visible = false;
            // 
            // fPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 432);
            Controls.Add(dtgvAccount);
            Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(882, 471);
            MinimumSize = new Size(882, 471);
            Name = "fPhanQuyen";
            Palette = kryptonPalette1;
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private DataGridView dtgvAccount;
        private DataGridViewTextBoxColumn cTen;
        private DataGridViewCheckBoxColumn cView;
        private DataGridViewCheckBoxColumn cCreate;
        private DataGridViewCheckBoxColumn cUpdate;
        private DataGridViewCheckBoxColumn cDelete;
        private DataGridViewTextBoxColumn cIdUser;
        private DataGridViewTextBoxColumn cFunctionId;
    }
}

