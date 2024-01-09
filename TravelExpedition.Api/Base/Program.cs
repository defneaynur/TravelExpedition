
using TravelExpedition.Api.Base;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
//builder.Services.AddControllersWithViews();
//builder.Services.AddMvc().AddControllersAsServices();
// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddMvc();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

builder.BaseAppSettings();
builder.BaseInject();
builder.BaseConfigure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Travel/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("myAppCors");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Travel}/{action=Index}/{id?}");

app.Run();
