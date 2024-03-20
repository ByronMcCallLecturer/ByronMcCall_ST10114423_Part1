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
            return RedirectToAction("Index", "Home");   
        }
        [HttpGet]
        public ActionResult About()
        {
            
            return View(usrtbl);
        }

    }
}
