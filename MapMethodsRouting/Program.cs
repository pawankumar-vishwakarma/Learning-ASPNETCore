var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home", () => "Hello World! - GET");
//app.MapPost("/Home", () => "Hello World! - POST");
//app.MapPut("/Home", () => "Hello World! - PUT");
//app.MapDelete("/Home", () => "Hello World! - DELETE");

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home",async (context) =>
    {
        await context.Response.WriteAsync("This is Home page... GET");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page... PUT");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page... POST");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Home page... DELETE");
    });
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Error 404 Page Not Found");
});

app.Run();