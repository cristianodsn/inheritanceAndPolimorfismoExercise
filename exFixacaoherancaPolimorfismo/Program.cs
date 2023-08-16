using System;
using System.Globalization;
using System.Collections.Generic;
using exFixacaoherancaPolimorfismo.Entities;

namespace exFixacaoherancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of product: ");
            int quantity = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Common, used or imported(C/ U/ I)? ");
                char type = char.Parse(Console.ReadLine().ToUpper());

                if (type == 'C')
                {
                    Product p = new Product(name, price);
                    products.Add(p);
                }
                else if (type == 'U')
                {
                    Console.Write("Enter the date product (dd/mm/yyyy): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Product p = new UsedProduct(name, price, date);
                    products.Add(p);
                }
                else
                {
                    Console.Write("Customsfee: ");
                    double custamsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product p = new ImportedProduct(name, price, custamsfee);
                    products.Add(p);
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}
