using CrmUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.BLL.Abstract
{
    public interface IPostService
    {
        void Create(Blog post);
        void Update(Blog post);
        void Delete(Blog post);
        Blog Get(int id);
        List<Blog> ListAll();
    }
}
