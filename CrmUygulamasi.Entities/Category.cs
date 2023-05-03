using CrmUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.Entities
{
    public class Category: EntityBase
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public virtual List<Blog> Posts { get; set; }
    }
}
