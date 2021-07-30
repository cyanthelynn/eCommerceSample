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
            // GetByUnitPriceTest();
            //CategoryGetAllTest();
            DtoTest();
        }


        private static void CategoryGetAllTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void GetByUnitPriceTest()
        {
            ProductManager productManager = new ProductManager(new DataAccess.Concrete.EntityFramework.EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(10, 200).Data)
            {
                Console.WriteLine(product.ProductName);
            }

        }
        private static void DtoTest()
        {
            ProductManager productManager1 = new ProductManager(new DataAccess.Concrete.EntityFramework.EfProductDal());
            var result = productManager1.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName + " / " + product.UnitsInStock);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }




    }
}

	
	

	

       
        


