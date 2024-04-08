using HRMS.Data;
using HRMS.Models;
using HRMS.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace HRMS.Controllers
{
    public class EmployeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeController(ApplicationDbContext dbContext)
        {
            this.dbContext= dbContext;
        }

        

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeView view)
        {
            if (ModelState.IsValid)
            {
                var employe = new Employess
                {
                     Name = view.Name,
                    Email = view.Email,
                    Address = view.Address,
                    Date_Of_Join = view.Date_Of_Join,
                    Designation = view.Designation,
                    Gender = view.Gender,
                    password = view.password,
                    Phone = view.Phone
                };

                await dbContext.Employess.AddAsync(employe);
                await dbContext.SaveChangesAsync();

                return RedirectToAction("Login", "Employe");

            }


            return View();
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                bool userExist = dbContext.Employess.Any(x => x.Name == login.Name && x.password == login.password);
                if (userExist)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
                ModelState.AddModelError("", "Invalid Details");
                return View();
            
        }

    }
}
