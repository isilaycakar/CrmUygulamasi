using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.DAL.Repositories;
using CrmUygulamasi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.DAL.EntityFramework
{
    public class EFPostRepository : GenericRepository<Blog>, IPostDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context = new CrmContext())
            {
                return context.Posts.Include(x => x.Category).ToList();
            }
        }
    }
}
