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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            this.employeeDal = employeeDal;
        }

        public void Create(Employee employee)
        {
            employeeDal.Create(employee);
        }

        public void Delete(Employee employee)
        {
            employeeDal.Delete(employee);
        }

        public Employee Get(int id)
        {
            return employeeDal.Get(id);
        }

        public List<Employee> ListAll()
        {
            return employeeDal.ListAll();
        }

        public void Update(Employee employee)
        {
            employeeDal.Update(employee);
        }
    }
}
