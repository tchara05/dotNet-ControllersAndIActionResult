using Microsoft.AspNetCore.Mvc;

namespace ControllersApp.Controllers
{
    public class StoreController : Controller
    {

        // We use this controller in order to perform the redirection of old pages/methods to new one.

        [Route("store/books")]
        public IActionResult Books()
        {
            return Content("<h1>Book Store</h1>","text/html");
        }
    }
}
