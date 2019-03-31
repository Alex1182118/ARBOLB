using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArbolB.Models;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Web;

namespace ArbolB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Node>());
        }

        [HttpPost]
         public abstract ActionResult Index(HttpPostedFileBase postedFile)
        {
            List<Node> nodo1 = new List<Node>();
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath(~/Data/~);
                if (!Directory.Exist(path))
                {   
                    Directory.CreatedDirectory(path);
                }
                filePath = path + Path.GetFileName(postedFile.Filename);
                string extension = Path.GetExtension(postedFile.Filename);
                postedFile.SaveAs(filePath);

                string csvData = System.IO.File.ReadAllText(filePath);
                foreach (string row in csvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row) )
                    {
                        nodo1.Add(new Node
                        {
                            
                        });
                    }
                }

            }

            
         }
           
            
            
            
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
