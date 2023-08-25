
using DemoApplication;
using DemoApplication.Models;
using DemoApplication.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions(){

  WebRootPath="wwroot"

    });


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IEmailMessage, EmailMessage>();
builder.Services.AddSingleton<ListClass>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseAuthentication();

app.UseUserMiddleWare();
//DeveloperExceptionPageExtensions a=new DeveloperExceptionPageExtensions();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//int a = 1,b=0;
//app.MapGet("/",()=>"Answer is");
//app.MapControllers();

app.MapControllerRoute(
   name: "CustomRoute",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Home", action = "Index2" });

////app.MapGet("/",()=>"Hello");

app.Run();




//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Middleware1: Incoming Request\n");
//    //Calling the Next Middleware Component
//    await next();
//    await context.Response.WriteAsync("Middleware1: Outgoing Response\n");
//});
////Second Middleware Component Registered using Use Extension Method
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Middleware2: Incoming Request\n");
//    //Calling the Next Middleware Component
//    await next();
//    await context.Response.WriteAsync("Middleware2: Outgoing Response\n");
//});
////Third Middleware Component Registered using Run Extension Method
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Middleware3: Incoming Request handled and response generated\n");
//    //Terminal Middleware Component i.e. cannot call the Next Component
//});

