using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKuharica.Filters;
using eKuharica.Services;
using eKuharica.Services.Feedbacks;
using eKuharica.Services.Recipes;
using eKuharica.Services.RecipeTranslations;
using eKuharica.Services.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace eKuharica
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
            services.AddControllers(x=> {
                x.Filters.Add<ErrorFilter>();
            });

            services.AddSwaggerGen();

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<IRecipeTranslationService, RecipeTranslationService>();

            //services.AddDbContext<eKuharicaContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<Context>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection")).EnableSensitiveDataLogging());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
