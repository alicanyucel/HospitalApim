using HospitalWebApi.Business.Extensions;
using HospitalWebApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// burada onyuzle haberleþmesi için cors yapýsýný kullanýyorum
// .net Core 5.0 daki configure service yapýsý burada bu þekilde
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); //  önyüzden gelen bütün isteklere izin ver
    });
});
builder.Services.LoadMyServices();
builder.Services.AddControllersWithViews();
// Aþaðýdaki kod satýrý code first içindir
//builder.Services.AddDbContext<HospitalContext>(b => b.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// burada da middleware i çaðýrýyoruz
// .Net Core da middlewarwe öncelik sýrasý var
// ayrýntýlý bilgi için =>
// //https://learn.microsoft.com/tr-tr/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0
app.UseHttpsRedirection();
app.UseCors(builder => builder.WithOrigins().AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();
app.Run();
