using CrmUygulamasi.BLL;
using CrmUygulamasi.DAL.EntityFramework;
using CrmUygulamasi.Entities;
using CrmUygulamasi.UI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeeController : Controller
    {
        EmployeeManager employeeManager = new EmployeeManager(new EFEmployeeRepository());

        private readonly INotificationService notificationService;

        public EmployeeController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public IActionResult Index()
        {
            List<Employee> list = employeeManager.ListAll();
            return View(list);
        }

        //[AllowAnonymous] yetkilendirmeleri etkisiz sayar ulaşılabilir hala gelir
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employeeManager.Create(employee);
                    notificationService.Notification(NotifyType.Success, $"{employee.NameSurname} isimli personel başarılı bir şekilde kayıt edildi.");
                }
                catch (Exception ex)
                {
                    notificationService.Notification(NotifyType.Error, ex.Message);
                }
            }
            else
            {
                ModelStateControl.KontrolEt(notificationService, ModelState);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateEmployeePartial()
        {
            return PartialView("_CreateEmployeePartialView", new Employee());
        }

        public IActionResult EditEmployeePartial(int id)
        {
            Employee employee = employeeManager.Get(id);

            return PartialView("_EditEmployeePartialView", employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employeeManager.Update(employee);
                    notificationService.Notification(NotifyType.Success, $"{employee.NameSurname} isimli müşteri başarılı bir şekilde güncellendi.");

                }
                catch (Exception ex)
                {
                    notificationService.Notification(NotifyType.Error, ex.Message);

                }
            }
            else
            {
                ModelStateControl.KontrolEt(notificationService, ModelState);

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteEmployeePartial(int id)
        {
            Employee employee = employeeManager.Get(id);

            return PartialView("_DeleteEmployeePartialView", employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            try
            {
                employeeManager.Delete(employee);
                notificationService.Notification(NotifyType.Success, $"{employee.NameSurname} isimli personel başarılı bir şekilde silindi.");

            }
            catch (Exception ex)
            {
                notificationService.Notification(NotifyType.Error, ex.Message);

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateEmployeeState(int id)
        {
            var employee = employeeManager.Get(id);
            employee.Status = !employee.Status;
            employeeManager.Update(employee);
            notificationService.Notification(NotifyType.Success, $" {employee.NameSurname} isimli müşteri başarılı bir şekilde güncellendi.");

            return Ok();
        }
    }
}
