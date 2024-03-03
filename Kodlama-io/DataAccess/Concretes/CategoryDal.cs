using Kodlama_io.DataAccess.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>();

            Category category1 = new Category { CategroyId = 2, CategoryName = "Programlama" };
            _categories.Add(category1); 
           
        }
        public void Add(Category category)
        {
           _categories=new List<Category>();    
        }

        public void Delete(Category category)
        {
           _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories; 
        }

        public void Update(Category category)
        {
            Category existCategroy = _categories.Find(x => x.CategroyId == category.CategroyId);
            if (existCategroy != null) 
            { 
                return;
                existCategroy.CategoryName = category.CategoryName;
            }
        }
    }
}
