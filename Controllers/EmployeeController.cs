using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello world. {DateTime.Now.ToString() }";
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            //return View(); --> demiş olsaydık Index2.cshtml arayacaktı View folder'ın altında

            var names = new String[]
            {
                "Ahmet","Merhmet","Tahir"

            };

            return View(names);

        }

        public IActionResult Index3()
        {
            var list = new List<Employee>();
            {
                
                list.Add(new Employee(){ Id = 1, FirstName = "Ahmet", LastName = "Uygun", Age = 20 });
                list.Add(new Employee(){ Id = 2, FirstName = "Mehmet", LastName = "Oba", Age = 25 });
                list.Add(new Employee(){ Id = 3, FirstName = "Yasin", LastName = "Koç", Age = 30 });

                
            }

            return View("Index3", list);
        }
    }
}
