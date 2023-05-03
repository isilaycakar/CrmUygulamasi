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
    public class PostManager : IPostService
    {
        IPostDal postDal;

        public PostManager(IPostDal postDal)
        {
            this.postDal = postDal;
        }

        public void Create(Blog post)
        {
            postDal.Create(post);
        }

        public void Delete(Blog post)
        {
            postDal.Delete(post);
        }
        public void Update(Blog post)
        {
            postDal.Update(post);
        }

        public Blog Get(int id)
        {
            return postDal.Get(id);
        }

        public List<Blog> ListAll()
        {
            return postDal.ListAll();
        }

        public List<Blog> GetPostListWithCategory()
        {
            return postDal.GetListWithCategory();
        }

    }
}
