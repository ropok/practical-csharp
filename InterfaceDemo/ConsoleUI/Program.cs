using DemoLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} download");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Jaler",
                LastName = "Maji",
                City = "Wonosari",
                EmailAddress = "jmw@gmail.com",
                PhoneNumber = "1349-9293"
            };
        }

        private static List<IProductModel> AddSampleData()
        {

            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Hello Wourld" });
            output.Add(new PhysicalProductModel { Title = "Boys" });
            output.Add(new PhysicalProductModel { Title = "Ledis and jentelmen" });
            output.Add(new DigitalProductModel { Title = "Vlog jalerse" });
            output.Add(new CourseProductModel { Title = "Bekerja di Finlandia" });

            return output;

        }
    }
}
