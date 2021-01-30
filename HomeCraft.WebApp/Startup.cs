using AutoMapper;
using HomeCraft.Data;
using HomeCraft.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HomeCraft.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(setupAction => {
                // if dis is set to false dis return a default format if an unsupported forrmat is requested by default it is false dat's y we get json when an unsupported media type is requested 
                //  setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                setupAction.ReturnHttpNotAcceptable = true;
                setupAction.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
            });

            services.AddDbContext<HomeCraftDbContext>(o => o.UseSqlServer(
               Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductsRepository, ProductsRepository>();
            // the GetCart model will be involked when the ShoppingCart is called 
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));

            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("LibraryOpenAPISpecification", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "Library API",
                    Version = "1",
                    Description = "Through this API you can access furniture products",
                    // used to add contact info 
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Email = "olatunjiadebanjo75@gmail.com",
                        Name = "Adebanjo Olatunji",
                        Url = new Uri("https://www.linkedin.com/in/olatunji-adebanjo-5976411b8/")
                    }
                });

                // used to add the security scheme used for authentication
                setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using Bearer scheme."
                });
                // used to add the security requirement used for authentication
                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id ="Bearer"
                            }
                        },
                        new List<string>{}
                    }
                });

                // incorporating XML comments on actions and models
                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
                setupAction.IncludeXmlComments(xmlCommentsFullPath);

            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("" +
                    "/swagger/LibraryOpenAPISpecification/swagger.json", "Library API");
            });

            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

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
