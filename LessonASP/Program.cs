var builder = WebApplication.CreateBuilder(args);

// должны быть добавлены сервисы 
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();    
}
app.UseStaticFiles();


app.UseRouting();


app.MapGet("/grettings", () => app.Configuration["ServerGreetings"]);

app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern:"{comtroller=Home}/{action=Index}/{id?}"
    );

app.Run();
