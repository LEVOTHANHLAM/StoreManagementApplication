using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosManager.Forms.UserControls.Kho
{
    public partial class XtraUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        protected internal XtraUserControl1()
        {
            InitializeComponent();
        }
        //ImageCollection storing images for items
        private DevExpress.Utils.ImageCollection imageCollection1;

        //image combo box editor created at runtime
        DevExpress.XtraEditors.ImageComboBoxEdit rtImageComboBox;

        private void Form1_Load(object sender, EventArgs e)
        {
            rtImageComboBox = CreateImageComboBoxEdit(new Rectangle(220, 10, 120, 20), this);
            AddItems(rtImageComboBox, imageCollection1);
            //select the last item
            rtImageComboBox.SelectedIndex = rtImageComboBox.Properties.Items.Count - 1;
        }

        //create the editor
        private ImageComboBoxEdit CreateImageComboBoxEdit(Rectangle bounds, Control container)
        {
            ImageComboBoxEdit editor = new ImageComboBoxEdit();
            editor.Bounds = bounds;
            container.Controls.Add(editor);
            editor.SelectedIndexChanged += new EventHandler(imageComboBoxEdit_SelectedIndexChanged);
            return editor;
        }

        //add items
        private void AddItems(ImageComboBoxEdit editor, ImageCollection imgList)
        {
            for (int i = 0; i < 7; i++)
                editor.Properties.Items.Add(new ImageComboBoxItem("Item " + (i + 1).ToString(), i, i));
            editor.Properties.SmallImages = imgList;
        }

        //display information on the selected item
        void imageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageComboBoxEdit editor = sender as ImageComboBoxEdit;
            this.Text = "SelectedIndexChanged: index " + editor.SelectedIndex.ToString() +
                " / value " + editor.EditValue.ToString() + " / display text " + editor.Text;
        }

        private void filterEditorControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
