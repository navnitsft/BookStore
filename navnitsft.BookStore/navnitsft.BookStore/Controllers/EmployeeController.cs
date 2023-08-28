using Microsoft.AspNetCore.Mvc;
using navnitsft.BookStore.Models;
using navnitsft.BookStore.Repository;

namespace navnitsft.BookStore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepository _employeeRepository = null;

        public EmployeeController()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public ViewResult GetAllEmployees()
        {
            ViewBag.ViewBag1 = "Navneet Kumar";

            var data = _employeeRepository.GetAllEmployee();
            return View(data);
        }

        public ViewResult GetEmployee(int id)
        {
            var data = _employeeRepository.GetEmployeeById(id);
            return View(data);
        }
        public ViewResult SearchEmployee(string name, string email)
        {
            var data = _employeeRepository.SearchEmployee(name, email);
            return View(data);
        }
    }
}
