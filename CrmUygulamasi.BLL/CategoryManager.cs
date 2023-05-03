using CrmUygulamasi.BLL.Abstract;
using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.BLL
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void Create(Category category)
        {
            categoryDal.Create(category);
        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }

        public Category Get(int id)
        {
            return categoryDal.Get(id);
        }

        public List<Category> ListAll()
        {
            return categoryDal.ListAll();
        }
    }

    }
