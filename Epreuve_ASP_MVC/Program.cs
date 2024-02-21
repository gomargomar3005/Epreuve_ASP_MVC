using Shared_Epreuve.Repositories;
using BLL = BLL_Epreuve;
using DAL = DAL_Epreuve;

namespace Epreuve_ASP_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            #region Produit
            builder.Services.AddScoped<IProduitRepository<BLL.Entities.Produit>, BLL.Services.ProduitService>();
            builder.Services.AddScoped<IProduitRepository<DAL.Entities.Produit>, DAL.Services.ProduitService>();
            #endregion

            //#region Image
            //builder.Services.AddScoped<IImageRepository<BLL.Entities.Image>, BLL.Services.ImageService>();
            //builder.Services.AddScoped<IImageRepository<DAL.Entities.Image>, DAL.Services.ImageService>();
            //#endregion

            //#region Categorie
            //builder.Services.AddScoped<IImageRepository<BLL.Entities.Image>, BLL.Services.ImageService>();
            //builder.Services.AddScoped<IImageRepository<DAL.Entities.Image>, DAL.Services.ImageService>();
            //#endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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