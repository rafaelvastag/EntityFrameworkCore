using ModBasic.Context;
using System;

namespace ModBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerContext() )
            {
                var products = db.Products;
                foreach (var item in products)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price.ToString("c"));
                }
            }
            Console.ReadLine();
        }
    }
}
