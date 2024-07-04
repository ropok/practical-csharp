namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(MentionDiscount mentionDiscount,
            Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal,
            Action<string> alertMessageDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionDiscount(subTotal);

            alertMessageDiscounting("We are applying your discount.");

            return calculateDiscountedTotal(Items, subTotal);
        }
    }
}
