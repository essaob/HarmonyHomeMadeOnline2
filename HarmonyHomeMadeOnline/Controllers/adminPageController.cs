using HarmonyHomeMadeOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace HarmonyHomeMadeOnline.Controllers
{
    public class adminPageController : Controller
    {
        private readonly OnlineContext myDB;

        public adminPageController(OnlineContext context)
        {

            myDB = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult addProduct(Product product)
        {
            //Product obj = new Product();
            myDB.products.Add(product);
            myDB.SaveChanges();
            return View("AdminPage");
        }
        public ActionResult deleteProduct(Product product) {
            Product obj = new Product();
            obj = (from temp in myDB.products where temp.productName == product.productName select temp).FirstOrDefault();
            myDB.products.Remove(obj);
            myDB.SaveChanges();
            return View("AdminPage");
        }
        public ActionResult editProduct(Product product)
        {
            Product obj = new Product();
            obj = (from temp in myDB.products where temp.productName == product.productName select temp).FirstOrDefault();
            myDB.SaveChanges();
            return View("AdminPage");
        }
    }
}
