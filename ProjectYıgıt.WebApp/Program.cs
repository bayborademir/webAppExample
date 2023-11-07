using ProjectYıgıt.WebApp.Business.Abstract;
using ProjectYıgıt.WebApp.Business.Concrete;
using ProjectYıgıt.WebApp.DataAcces;
using ProjectYıgıt.WebApp.DataAcces.Abstract;
using ProjectYıgıt.WebApp.DataAcces.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProjectYıgıtDbContext>();

builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IEmployeeService, EmployeeManager>();

builder.Services.AddControllers();

builder.Services.AddRazorPages();


//--------------------------------------------------------------------------


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.MapRazorPages();

app.Run();

