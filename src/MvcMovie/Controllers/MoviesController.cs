using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /HelloWorld/
        // invoked by appending /HelloWorld/ to the base url
        public IActionResult Index()
        {
            var Mov = new MovieDatabase();
            return View(Mov);
        }

    }
   
}
