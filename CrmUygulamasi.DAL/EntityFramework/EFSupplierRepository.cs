using CrmUygulamasi.DAL.Abstract;
using CrmUygulamasi.DAL.Repositories;
using CrmUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.DAL.EntityFramework
{
    public class EFSupplierRepository : GenericRepository<Supplier>, ISupplierDal
    {

    }
}
