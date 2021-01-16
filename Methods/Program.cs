using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 20;
            product1.Note = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Note = "İzmir Karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Note);
                Console.WriteLine("-----------------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            var x = 5 < 7 ? 6:9;
            Console.WriteLine(x);

           

        }
    }
}
