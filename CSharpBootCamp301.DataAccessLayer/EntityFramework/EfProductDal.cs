using CSharpBootCamp301.DataAccessLayer.Abstract;
using CSharpBootCamp301.DataAccessLayer.Context;
using CSharpBootCamp301.DataAccessLayer.Repositories;
using CSharpBootCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootCamp301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new CampContext();
            var values = context.Products.Select(x=>new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock,
                ProductPrice = x.ProductPrice,
                ProductDecription = x.ProductDecription,
                CategoryName = x.Category.CategoryName,

            }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
