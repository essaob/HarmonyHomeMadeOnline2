using HarmonyHomeMadeOnline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HarmonyHomeMadeOnline.Controllers
{
    public class HomePageController : Controller
    {
        private readonly OnlineContext myDB;

        public HomePageController(OnlineContext context)
        {

            myDB = context;
        }
        public IActionResult MainPage()
        {
            return View();
        }
		[HttpPost]
		public ActionResult cheekUser(User user)
		{
			User obj = new User();
			obj = (from temp in myDB.users where temp.userName == user.userName select temp).FirstOrDefault();
			if (obj == null ) { ViewBag.ErrorMessage = "Invalid username or password"; }
			
		/*	
			if(user.userName=="admin") 
				if(user.userPass == "123") 
				return View("adminPage/AdminPage");
			*/

			if (obj.userPass == user.userPass)
			{
                if (user.userName == "admin")
					return View("adminPage/AdminPage");
                return View("MainPage2");
			}
            //ViewBag.ErrorMessage = "Invalid username or password";
            //return View("Login"); // Replace "Login" with your actual login view name
          

            // If the user is not found, display an appropriate message
            ViewBag.ErrorMessage = "Invalid username or password";
            return View("Login"); // Replace "Login" with your actual login view name
        }
		
		//public ActionResult CheckUser(User user)
		//{
		//	var obj = myDB.users.FirstOrDefault(u => u.userName == user.userName);

		//	if (obj != null && obj.userPass == user.userPass)
		//	{
		//		return RedirectToAction("MainPage");
		//	}

		//	// If the user is not found, display an appropriate message
		//	ViewBag.ErrorMessage = "Invalid username or password";
		//	return View("Login"); // Replace "Login" with your actual login view name
		//}
	}
}
