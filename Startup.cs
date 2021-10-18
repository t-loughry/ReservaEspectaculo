using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReservaEspectaculo.Data;
using ReservaEspectaculo.Models;

namespace ReservaEspectaculo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)        {

            services.AddDbContext<MiContexto>(options => options
                .UseSqlServer(Configuration.GetConnectionString("ReservaEspectaculo"))
                );

            //services.AddDbContext<MiContexto>(options => options
            //    .UseInMemoryDatabase(databaseName: "InMemoryDb")
            //    );

            services.AddIdentity<Usuario, Rol>().AddEntityFrameworkStores<MiContexto>();

            services.PostConfigure<Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme,
                opciones =>
                {
                    opciones.LoginPath = "/CuentaCliente/IniciarSesion";
                    opciones.AccessDeniedPath = "/CuentaCliente/AccesoDenegado";
                }
                );

            services.AddControllersWithViews();
        }
                

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MiContexto contexto)
        {
            DbInicializador.Inicializar(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            contexto.Database.EnsureCreated(); //sino existe la base de datos la crea
            contexto.Database.Migrate(); //aplica las migraciones pendientes
                     

            app.UseRouting();

            app.UseAuthentication();

            //app.UseSession();                       

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
                        
        }
    }
}
