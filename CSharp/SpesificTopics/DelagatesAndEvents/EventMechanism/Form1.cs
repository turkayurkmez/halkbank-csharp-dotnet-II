namespace EventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (e.Button == MouseButtons.Right)
            {

                button.BackColor = Color.Aqua;
            }
            else if (e.Button == MouseButtons.Left)
            {
                button.BackColor = Color.Blue;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            var product = new Product { Id = 1, Name = "Tişört" };
            productService.ProductCreated += ProductService_ProductCreated;

            productService.Add(product);
        }

        private void ProductService_ProductCreated(object sender, ProductCreatedEventArgs e)
        {
            MessageBox.Show($"{e.Product.Name} isimli ürün {e.User} tarafından {e.CreatedDate.ToString()} tarihinde eklendi");
        }
    }
}
