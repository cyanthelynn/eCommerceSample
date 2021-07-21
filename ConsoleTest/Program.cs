using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new DataAccess.Concrete.EntityFramework.EfProductDal());
            foreach (var product in productManager.GetByUnitPrice (10,200))
            {
                Console.WriteLine(product.ProductName);
            }
           
        }
    }
}
