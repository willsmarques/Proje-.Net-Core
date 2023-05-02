﻿using Microsoft.AspNetCore.Mvc;
using MVCProjeto.Models;

namespace MVCProjeto.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics"});
            list.Add(new Department { Id = 2, Name = "Fashoin"});

            return View(list);
        }
    }
}
