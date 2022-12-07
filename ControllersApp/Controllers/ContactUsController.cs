using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Dynamic;


namespace ControllersApp.Controllers
{

    // In this controller, we use the IActionResult which is the parent to all type of return results.
    // IAction result is the recomended type to use from microsoft.
    // Having the IActionResult in place we can return any content we want
    // using the readymade methods by extending the controller class


    public class ContactUsController : Controller
    {

        [Route("contact-us/contact-form")]
        public IActionResult contactForm()    
        {
            // And All return type objects are childs of this  
            return Content("<h1>Contact Us Form</h1>", "text/html");
        }

        [Route("contact-us/contact-form/sendEmail")]
        public IActionResult sendEmail()
        {

            // And All return type objects (JsonResult, ContentResult, ) are childs of this
            var response = new { status = "ok", message = "Email Send" };
            return Json(response);
        }
    }
}
