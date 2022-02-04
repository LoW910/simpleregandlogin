using Microsoft.AspNetCore.Mvc;
using SimpleLoginRegistration.Models;

namespace SimpleLoginRegistration.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() {
            return View();
        }


        [HttpPost("register")]
        public IActionResult Register(RegUser newUser){
            if(ModelState.IsValid) {
                return RedirectToAction("Success", "User");
            }
            return View("Index");
        }


        [HttpPost("login")]
        public IActionResult Login(LogUser loginUser){
            if(ModelState.IsValid){
                return RedirectToAction("Success", "User");
            }
            return View("Index");
        }

        [HttpGet("success")]
        public IActionResult Success(){
            return View();
        }
    }
}