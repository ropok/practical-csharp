namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(random.Next(5, 11));
            //    //SimpleMethod(random);
            //    Console.WriteLine(random.NextDouble() * 100);
            //}

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Jal"},
                new PersonModel{FirstName = "Ler"},
                new PersonModel{FirstName = "Sek"},
                new PersonModel{FirstName = "Kar"},
                new PersonModel{FirstName = "Maj"},
                new PersonModel{FirstName = "Ji"},
                new PersonModel{FirstName = "Ija"},
                new PersonModel{FirstName = "Rel"},
                new PersonModel{FirstName = "Rak"},
                new PersonModel{FirstName = "Sek"},
            };

            var sortedPeople = people.OrderBy(x => random.Next());


            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}
