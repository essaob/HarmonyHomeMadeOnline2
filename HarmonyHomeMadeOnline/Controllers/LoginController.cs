using HarmonyHomeMadeOnline.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HarmonyHomeMadeOnline.Controllers
{
    public class LoginController : Controller
    {
        private readonly OnlineContext myDB;

        public LoginController(OnlineContext context)
        {

            myDB = context;
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult CreatAccount()
        {
            return View();
        }
        public ActionResult InsertUser(User user)
        {

            User newUser = new User
            {
                userName = user.userName,
                userPass = user.userPass,
                userEmail = user.userEmail

            };

            myDB.users.Add(newUser);
            myDB.SaveChanges();

            return RedirectToAction("LoginPage");
        }
        //public ActionResult cheekUser(User user)
        //{
        //    User obj = new User();
        //    obj = (from temp in myDB.users where temp.userName == user.userName select temp).FirstOrDefault();
        //    if (obj.userPass == user.userPass)
        //    {
        //        return View("MainPage");
        //    }
        //    return View("LoginPage");
        //}
        
        
        
        
        /// //////////////////
      
        
       
    }
}
