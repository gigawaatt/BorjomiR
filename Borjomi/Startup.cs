using Borjomi.Data;
using Borjomi.Data.Intetfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Borjomi.Data.Repository;

namespace Borjomi
{
    public class Startup
    {
        


        //private IConfigurationRoot _confStr;

        //public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        //{
        //    _confStr = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        //}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddMvc();
            services.AddTransient<IStaff, StaffRepository>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            string connection = Configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confStr.GetConnectionString("DefaultConnection")));
            services.AddDbContext<AppDBContent>(options =>
                options.UseSqlServer(connection));
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseRouting();

            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            { endpoints.MapRazorPages(); endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}"); });





            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBStaffObjects.Initial(content);
            }

            



        }
    }
}
