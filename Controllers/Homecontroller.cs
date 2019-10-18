using Microsoft.AspNetCore.Mvc;
using NinjaSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaSchool.Controllers
{
    public class Homecontroller : Controller
    {
        private readonly INinjaRepo ninja_Repo;

        public Homecontroller(INinjaRepo ninjaRepo)
        {
            ninja_Repo = ninjaRepo;
        }

        public ViewResult Index()
        {
            var model = ninja_Repo.getallNinjas();
            return View(model);
        }
    }
}
