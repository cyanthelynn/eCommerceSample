using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class EfProductDal : IProductDal
    {
        List<Product> _products;
        public EfProductDal()
        {
            _products = new List<Product> {
            
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Hat", UnitPrice = 100, UnitsInStock = 20 },
            new Product { ProductId = 2, CategoryId = 2, ProductName = "Mouse", UnitPrice = 200, UnitsInStock = 12 },
            new Product { ProductId = 3, CategoryId = 2, ProductName = "Keyboard", UnitPrice = 450, UnitsInStock = 2 },
            new Product { ProductId = 4, CategoryId = 1, ProductName = "Shirt", UnitPrice = 100, UnitsInStock = 30 }


            };


        }
        public void Add(Product product)
        {
            _products.Add(product);

        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }

            //}
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

              _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return  _products.Where(p => p.CategoryId == CategoryId).ToList();


        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {

           Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
