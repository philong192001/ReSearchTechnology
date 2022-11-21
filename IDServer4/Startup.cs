using IDServer4.Config;
using IDServer4.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer4
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        public IConfiguration _config { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _config = configuration;
            _env = env;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var connectionString = _config.GetConnectionString("DefaultConnection");

            //services.AddDbContext<DataContext>(config =>
            //{
            //    //config.UseSqlSever(connectionString);
            //    config.UseInMemoryDatabase("Memory");
            //});

            // AddIdentity registers the services
            //services.AddIdentity<IdentityUser, IdentityRole>(config =>
            //{
            //    config.Password.RequiredLength = 4;
            //    config.Password.RequireDigit = false;
            //    config.Password.RequireNonAlphanumeric = false;
            //    config.Password.RequireUppercase = false;
            //})
            //    .AddEntityFrameworkStores<DataContext>()
            //    .AddDefaultTokenProviders();

            //services.ConfigureApplicationCookie(config =>
            //{
            //    config.Cookie.Name = "IdentityServer.Cookie";
            //    config.LoginPath = "/Auth/Login";
            //    config.LogoutPath = "/Auth/Logout";
            //});

            //var assembly = typeof(Startup).Assembly.GetName().Name;

            ////var filePath = Path.Combine(_env.ContentRootPath, "is_cert.pfx");
            ////var certificate = new X509Certificate2(filePath, "password");

            //services.AddIdentityServer()
            //    .AddAspNetIdentity<IdentityUser>()
            //    //.AddConfigurationStore(options =>
            //    //{
            //    //    options.ConfigureDbContext = b => b.UseSqlServer(connectionString,
            //    //        sql => sql.MigrationsAssembly(assembly));
            //    //})
            //    //.AddOperationalStore(options =>
            //    //{
            //    //    options.ConfigureDbContext = b => b.UseSqlServer(connectionString,
            //    //        sql => sql.MigrationsAssembly(assembly));
            //    //})
            //    //.AddSigningCredential(certificate);
            //    .AddInMemoryApiResources(Configuration.GetApis())
            //    .AddInMemoryIdentityResources(Configuration.GetIdentityResources())
            //    .AddInMemoryClients(Configuration.GetClients())
            //    .AddDeveloperSigningCredential();

            //services.AddAuthentication()
            //    .AddFacebook(config => {
            //        config.AppId = "3396617443742614";
            //        config.AppSecret = "secret";
            //    });


            services.AddIdentityServer()
                    .AddInMemoryApiResources(Configuration.GetApis())
                    .AddInMemoryClients(Configuration.GetClients())
                    .AddDeveloperSigningCredential();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCookiePolicy(new CookiePolicyOptions()
                {
                    MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.Lax
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseIdentityServer();
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
