using Dependency_Injection.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

//Application Services
builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddSingleton(typeof(IEmployeeRepository), typeof(EmployeeRepository)); // to get the name of the class. 

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();

