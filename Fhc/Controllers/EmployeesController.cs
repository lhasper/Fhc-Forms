using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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

        // GET: /New/
        [HttpGet]
        public ActionResult New()
        {
            var departments = db.Departments.ToList();
            var buildings = db.Buildings.ToList();
            
            var viewModel = new NewItAccessViewModel
                            {
                                Employee = new Employee(),
                               //FullTimeEmployee = new FullTimeEmployee(),
                                Departments = departments,
                                Building = buildings,
                               
                                




                            };
            return View("New",viewModel);
        }

        // POST: Employees/New
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(
            //[Bind(Include =
            //   "Id,FullTimeEmployeeId,FirstName,LastName,Department,Title,Building,StartDate,Supervisor,UserName,Password,Domain,Epic,Dentrix,Email,Internet,Skype,PhoneExt,Laptop")]
          //FormCollection formCollection, Employee employee)
          Employee employee)
        {
            //var empNum = 0; 
            
            if ( !ModelState.IsValid )
            {
                var viewModel = new NewItAccessViewModel()
                                {
                                    Employee = employee,
                                    Departments = db.Departments.ToList(),
                                    Building = db.Buildings.ToList(),
                                    
               //FullTimeEmployee = new FullTimeEmployee()
                };

                return View("New", viewModel);
                }



            

            if (employee.Id == 0)
            
               // var empNum = new FullTimeEmployee();
               // db.SaveChanges();
               //var empNum= new FullTimeEmployee();
                //db.FullTimeEmployees.Add(empNum);
                
              
                db.Employees.Add(employee);
            
            else
            {
                //var empNum = new FullTimeEmployee();

                var empNum = GetEmployeeId();
                var employeeInDb = db.Employees.Single(c => c.Id == employee.Id);
                employeeInDb.FirstName = employee.FirstName;
                //employeeInDb.FullTimeEmployeeId = empNum;
                employeeInDb.LastName = employee.LastName;
                employeeInDb.DepartmentId = employee.DepartmentId;
                employeeInDb.Title = employee.Title;
                employeeInDb.BuildingId = employee.BuildingId;
                employeeInDb.StartDate = employee.StartDate;
                employeeInDb.Supervisor = employee.Supervisor;
                employeeInDb.UserName = "test";
                employeeInDb.Password = "test";
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
            return RedirectToAction("Index","Home");
                
        }

           
        

        // GET: Employees
        public ViewResult Index()
        {
            return View();
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

        public int GetEmployeeId()
        {
            //var y = empId;
          // var empId = 0;
            var x = new FullTimeEmployee();
            db.FullTimeEmployees.Add(x);
            db.SaveChanges();
           var empId = x.FullTimeEmployeeId;
            return empId;
        }

    }
}


