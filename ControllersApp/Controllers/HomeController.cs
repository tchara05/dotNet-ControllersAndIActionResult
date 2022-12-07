using Microsoft.AspNetCore.Mvc;
using ControllersApp.Models;
using Microsoft.AspNetCore.Identity;

namespace ControllersApp.Controllers
{

    // This is the starting controller of the tutorial. In this controller we can see
    // the different return types results. (Content Results, FileResult)
    //


    //
    // In order for the app to identify Classes as controllers you have to use
    // controller suffix like HomeController or add the annotation/directive [Controller] or both
    //

    [Controller]
    public class HomeController : Controller
    {

        [Route("/")]    //Routing Mapping
        [Route("home")] //You can use multiple route paths for same action method
        public ContentResult Index()
        {

            // This is the way to contruct the Type of results that you would like to return. 
            // You specify the Content and then you specify the ContentType. 
            //
            // However extending the Controller class in our controllers, we have ready methods available
            // to use them and avoid the from scratch construction of ContentResults. Check the next methods.

            ContentResult response = new ContentResult()
            {
                Content = "Home Page",
                ContentType = "text/plain"
            };

            return response;
        }


        [Route("about")]
        public ContentResult About()
        {

            // In order to use Content() method, the class controller needs to 
            // extent the : Controller class. If you remove the class Controller extention you have to use
            // the formal aproach to return responses as in Index() method. 

            return Content("About Page", "text/plain"); 
        }

        [Route("file-download-0")]
        public VirtualFileResult FileDownload0()
        {

            // or because of the Controller extension you can use return File("/files/TestPdf.pdf","application/pdf") as shortcut;
            return file("/files/TestPdf.pdf", "application/pdf");


        }



        [Route("file-download-1")]
        public VirtualFileResult FileDownload1()
        {

            // or because of the Controller extension you can use return File("/files/TestPdf.pdf","application/pdf") as shortcut;
            return new VirtualFileResult("/files/TestPdf.pdf","application/pdf"); 
          

        }

        [Route("file-download-2")]
        public PhysicalFileResult FileDownload2()
        {
            return new PhysicalFileResult(@"c:\<you have to write the full physical path>\TestPdf.pdf", "application/pdf");
        }






        // The method below is to show case, the redirection to other controllers. 
        //
        // Before start working on this method. Proceed to ContactUsController to check the IActionResult
        // and how they work.

        [Route("bookstore")]
        public IActionResult StoreBook()
        {
            // This method shows the BookStore page, but now we want to split the url and redirect it to the
            // store controller 

            // Old Code of showing the book store page. 
            // return Content("Book Store Page", "text/plain");

            // Using the local redirect result we can use the url directly where we want to redirect
            //return new LocalRedirectResult("store/books"); 

            // or return LocalRedirect("store/books") which is provide by extending the controller class

            // but the best practice to rediret is 
            return Redirect("store/books");
        }

    }
}
