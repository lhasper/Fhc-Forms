using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fhc.Models;
using Fhc.ViewModels;

namespace Fhc.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext db;

        public EmployeesController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        
        public ActionResult New()
        {
            var departments = db.Departments.ToList();
            var buildings = db.Buildings.ToList();
            
            
            

            

            var viewModel = new NewItAccessViewModel
                            {
                                Employee = new Employee(),
                               
                                Departments = departments,
                                Building = buildings,
                                




                            };
            return View("New",viewModel);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(
            [Bind(Include =
                "Id,FullTimeEmployee,FirstName,LastName,Department,Title,Building,StartDate,Supervisor,UserName,Password,Domain,Epic,Dentrix,Email,Internet,Skype,PhoneExt,Laptop")]
            Employee employee)
        {
            if ( ModelState.IsValid )
            {
                var viewModel = new NewItAccessViewModel()
                                {
                                    Employee = employee,
                                    Departments = db.Departments.ToList(),
                                    Building = db.Buildings.ToList()

                                };

                return View("New", viewModel);
                }
            var empNum = new FullTimeEmployee();
            db.SaveChanges();
            if (employee.Id == 0)
            {
                db.Employees.Add(employee);
            }
            else
            {
                
               
                var employeeInDb = db.Employees.Single(c => c.Id == employee.Id);
                employeeInDb.FirstName = employee.FirstName;
                employeeInDb.FullTimeEmployee = empNum;
                employeeInDb.LastName = employee.LastName;
                employeeInDb.Department = employee.Department;
                employeeInDb.Title = employee.Title;
                employeeInDb.Building = employee.Building;
                employeeInDb.StartDate = employee.StartDate;
                employeeInDb.Supervisor = employee.Supervisor;
                employeeInDb.UserName = employee.UserName;
                employeeInDb.Password = employee.Password;
                employeeInDb.Domain = employee.Domain;
                employeeInDb.Epic = employee.Epic;
                employeeInDb.Dentrix = employee.Dentrix;
                employeeInDb.Email = employee.Email;
                employeeInDb.Internet = employee.Internet;
                employeeInDb.Skype = employee.Skype;
                employeeInDb.PhoneExt = employee.PhoneExt;
                employeeInDb.Laptop = employee.Laptop;
                
            }
            db.SaveChanges();
            return RedirectToAction("New","Employees");
                
        }

           
        

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);

            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()

        {
           
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( 
            [Bind(Include =
                "Id,EmployeeNumber,FirstName,LastName,Department,Title,Building,StartDate,Supervisor,UserName,Password")]
           Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include =
                "Id,EmpType,EmployeeNumber,FirstName,LastName,Department,Title,Building,StartDate,Supervisor,UserName,Password")]
            Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee != null) db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}


