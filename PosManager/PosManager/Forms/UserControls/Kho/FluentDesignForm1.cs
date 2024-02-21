using DevExpress.XtraBars.Navigation;
using System;

namespace PosManager.Forms.UserControls.Kho
{
    public partial class FluentDesignForm1 : DevExpress.XtraEditors.XtraUserControl
    {
        public static string GenerateRandomCode(Random random, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] code = new char[length];
            for (int i = 0; i < length; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }
            return new string(code);
        }
        public FluentDesignForm1()
        {
            InitializeComponent();
            Random random = new Random();
            List<Product> products = new List<Product>();
            // Tạo các sản phẩm ngẫu nhiên
            for (int i = 0; i < 100; i++)
            {
                // Tạo một sản phẩm mới
                Product product = new Product();

                // Sinh mã sản phẩm ngẫu nhiên
                product.id = random.Next(100000, 999999).ToString();

                // Sinh mã code ngẫu nhiên (độ dài 24 ký tự)
                product.code = GenerateRandomCode(random, 24);

                // Sinh tên sản phẩm ngẫu nhiên
                product.name = "Product " + (i + 1);

                // Thêm sản phẩm vào danh sách
                products.Add(product);
            }

            accordionControl1.Elements.Clear();
            //List<Product> products = new List<Product> { new Product { id = "211221", code = "351625312765353115342615", name = "asadasdsadasdasd" } };
            foreach (var control in CreateProduct(products))
            {
                accordionControl1.Elements.Add(control);
            }

        }
        private List<AccordionControlElement> CreateProduct(List<Product> products)
        {
            List<AccordionControlElement> accordionControlElements = new List<AccordionControlElement>();
            foreach (var product in products)
            {
                ///
                DevExpress.XtraEditors.TextEdit text = new DevExpress.XtraEditors.TextEdit();
                text.Enabled = false;
                text.Location = new Point(374, 45);
                text.MenuManager = fluentFormDefaultManager1;
                text.Name = "textEdit1";
                text.Size = new Size(117, 20);
                text.TabIndex = 2;
                text.Visible = false;
                ///
                AccordionControlElement accordionControlElement = new AccordionControlElement();
                accordionControlElement.Name = product.id;
                accordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                accordionControlElement.Text = $" {product.code}  -  {product.name}";
                accordionControlElement.Click += accordionControlElement_Click;
                //
                //accordionControlElement.Controls.Add(text);
                accordionControlElements.Add(accordionControlElement);
            }
            return accordionControlElements;
        }

        private void accordionControlElement_Click(object? sender, EventArgs e)
        {
            AccordionControlElement accordionControlElement = (AccordionControlElement)sender;
            string name = accordionControlElement.Text.Split("  -  ").FirstOrDefault();
            string id = accordionControlElement.Name;
            var code = accordionControlElement.Text.Split("  -  ").Last();
            List<string> list = new List<string>();
            list.Add(name);
            list.Add(id);
            list.Add(code);

            UserControl1 control1 = new UserControl1(name, id, code, list);
            control1.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(control1);




            // throw new NotImplementedException();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }
        public class Product
        {
            public string id { get; set; }
            public string name { get; set; }
            public string code { get; set; }

        }
    }
}
