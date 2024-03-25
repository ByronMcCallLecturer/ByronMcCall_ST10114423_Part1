using Microsoft.AspNetCore.Mvc;
using CloudDevelopment.Models;
namespace CloudDevelopment.Controllers
{
    public class UserController : Controller
    {

        public  userTable usrtbl=new userTable();



        [HttpPost]
        public ActionResult About(userTable Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Privacy", "Home");   
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(usrtbl);
        }

        //[HttpPost]
        //public IActionResult Privacy(userTable u)
        //{
            //var result = usrtbl.select_User();

           // return View("Index", "Home"); // Ensure 'u' is not null
        //}







        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }


    }
}
