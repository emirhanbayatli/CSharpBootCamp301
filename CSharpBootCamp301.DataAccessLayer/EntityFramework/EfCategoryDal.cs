using CSharpBootCamp301.DataAccessLayer.Abstract;
using CSharpBootCamp301.DataAccessLayer.Repositories;
using CSharpBootCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootCamp301.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal :GenericRepository<Category>,ICategoryDal
    {
    }
}
