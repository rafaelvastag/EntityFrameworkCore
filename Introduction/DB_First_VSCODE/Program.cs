using System;

namespace DB_First_VSCODE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProductContext())
            {
                var products = db.Products;
                foreach (var item in products)
                {
                    Console
                        .WriteLine(item.Name + "\t" + item.Price.ToString("c"));
                }
            }
            Console.ReadLine();
        }
    }
}
