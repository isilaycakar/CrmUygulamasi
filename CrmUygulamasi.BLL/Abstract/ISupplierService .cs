using CrmUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.BLL.Abstract
{
    public interface ISupplierService
    {
        void Create(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
        Supplier Get(int id);
        List<Supplier> ListAll();
    }
}
