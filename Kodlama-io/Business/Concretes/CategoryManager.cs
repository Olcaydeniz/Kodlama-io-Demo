using Kodlama_io.Business.Abstracts;
using Kodlama_io.DataAccess.Abstracts;
using Kodlama_io.DataAccess.Concretes;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _category;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _category = categoryDal;
        }

        public void Add(Category category)
        {
            _category.Add(category);
        }

        public void Delete(Category category)
        {
         _category.Delete(category);    
        }

        public List<Category> GetAll()
        {
           return _category.GetAll();
        }


        public void Update(Category category)
        {
            _category.Update(category);
        }
    }
}
