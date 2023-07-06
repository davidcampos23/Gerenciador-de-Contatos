using Microsoft.EntityFrameworkCore;
using SistemaDeCadastros.Data;
using SistemaDeCadastros.Repositorio;
using System.Configuration;

namespace SistemaDeCadastros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Conexão Banco de Dados
            string DataBase = "server=localhost;initial catalog=CRUD_MVC_MYSQL;uid=root;pwd=0000";
            builder.Services.AddDbContext<BancoContext>(options => options.UseMySql(DataBase, Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));

            builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}