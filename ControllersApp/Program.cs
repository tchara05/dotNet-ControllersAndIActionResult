using ControllersApp.Controllers;
var builder = WebApplication.CreateBuilder(args);


/**

In order to use the controllers you can go with 2 approaches.
First approach is to add every individual controller one by one

--> builder.Services.AddTransient<HomeController>(); 

Second approach is to add all controller in once using the AddController method

--> builder.Services.AddControllers(); 
 
In this tutorial we are using the second option

 */
builder.Services.AddControllers();


var app = builder.Build();

app.UseStaticFiles();


/**

In order to use the controllers with endpoints there are 2 ways to go about it. 
Manual Way of adding your controllers, routing and endpoints

--> app.UseRouting();
--> app.UseEndpoints(endpoints =>{
    endpoints.MapControllers();
});

Second way is to call method below which does the same
--> app.MapControllers(); 

 */


app.MapControllers();



app.Run();
