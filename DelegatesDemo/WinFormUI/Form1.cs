using DemoLibrary;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();
        public Form1()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Sereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Susu", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Stroberi", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberi", Price = 8.84M });

        }

        private void messageBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);

            MessageBox.Show($"The total is {total:C2}");

        }

        private void textBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal((subTotal) => subTotalTextBox.Text = $"{subTotal:C2}",
                (products, subTotal) => subTotal - (products.Count * 2),
                (message) => { });

            totalTextBox.Text = $"{total:C2}";
        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }

        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"The subtotal is {subTotal:C2}");
        }

        private decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subTotal)
        {
            return subTotal - products.Count;
        }

    }
}
