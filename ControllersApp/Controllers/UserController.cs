using ControllersApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersApp.Controllers
{
    [Controller]
    public class UserController : Controller
    {

        // In this controller we can learn/check the Status Codes Results and how we can use the ready made methods by extending 
        // the Controller class. In this controller we showcase few examples. 

        [Route("user/{id}")]
        public IActionResult User(int? id)
        {

            // In this controller we can learn/check the Status Codes Results 

      
            // Below you can see how we can use the Status Code Results.
            // In Addition you can use more manual way to construct your Response. Check the last if statement
            if (id <= 0)
            {
               return BadRequest();
            } 
            
            if (id > 100 && id <= 500)
            {
                return NotFound();
            }

            if (id > 501)
            { 
                Response.StatusCode = 404;
                return Content("User Not Found");
            }

            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Theodoros",
                LastName = "Charalambous",
                Age = 30,
            };

            return Json(user); // or new JsonResult(user);

        }
    }
}
