using HospitalWebApi.Business.Extensions;
using HospitalWebApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// burada onyuzle haberle�mesi i�in cors yap�s�n� kullan�yorum
// .net Core 5.0 daki configure service yap�s� burada bu �ekilde
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); //  �ny�zden gelen b�t�n isteklere izin ver
    });
});
builder.Services.LoadMyServices();
builder.Services.AddControllersWithViews();
// A�a��daki kod sat�r� code first i�indir
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
// burada da middleware i �a��r�yoruz
// .Net Core da middlewarwe �ncelik s�ras� var
// ayr�nt�l� bilgi i�in =>
// //https://learn.microsoft.com/tr-tr/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0
app.UseHttpsRedirection();
app.UseCors(builder => builder.WithOrigins().AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();
app.Run();
