﻿using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers {
    
    public class TestController : Controller {
        
        public string GetString() {
            return "Hello world!";
        }

        public ActionResult GetView() {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Maria";
            emp.Salary = 1000;
            return View("MyView", emp);
        }
    }
}
