using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using FYPFinalCode.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;


namespace FYPFinalCode.Controllers
{
    public class UserController : Controller
    {
        private FYPdbcontext _dbContext;
        public UserController(FYPdbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public IActionResult ChildInfo()
        {
            return View();
        }

        public IActionResult InfoInput()
        {
            DbSet<Student> dbs = _dbContext.Student;
            var item = dbs.ToList();
                ViewData["item"] = new SelectList(item, "StudentBc", "StudentName", "StudentAge");
                return View();
    }
        [HttpPost]
        public IActionResult InfoInput(string studentname, string studentbc, int studentage, Student student)
        {
            if (ModelState.IsValid)
            {
                DbSet<Student> dbs = _dbContext.Student;
                var stud = dbs.Where( mo => mo.StudentBc == student.StudentBc).FirstOrDefault();


                if (stud == null)
                {
                    Student newstud = new Student();
                    newstud.StudentName = studentname;
                    newstud.StudentBc = studentbc;
                    newstud.StudentAge = studentage;


                    dbs.Add(newstud);

                    //string sql = @"INSERT INTO Student(StudentBc, StudentName, StudentAge) VALUES ('{0}', '{1}', '{2}')"
                    if (_dbContext.SaveChanges() == 1)
                        TempData["Msg"] = "New order added!";
                    else
                        TempData["Msg"] = "Failed to update database!";
                }

            }
            else
            {
                TempData["Msg"] = "Invalid information entered";
            }
                return RedirectToAction("ChildInfo");
            }
        }

    }
    



