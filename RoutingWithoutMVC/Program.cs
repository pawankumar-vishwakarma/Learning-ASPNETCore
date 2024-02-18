var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute();

//Convention based Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}"
    );

//Attribute-Based Routing
app.MapControllers();
app.Run();
