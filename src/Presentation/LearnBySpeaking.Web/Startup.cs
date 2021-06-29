using FluentValidation.AspNetCore;
using LearnBySpeaking.Core.Data;
using LearnBySpeaking.Data;
using LearnBySpeaking.Services.Common;
using LearnBySpeaking.Services.Common.Abstract;
using LearnBySpeaking.Services.Domain;
using LearnBySpeaking.Services.Domain.Abstract;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace LearnBySpeaking.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            services.AddControllersWithViews().AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddIdentity<IdentityUser, IdentityRole>(x =>
                {
                    x.Password.RequireNonAlphanumeric = false;
                })
                .AddEntityFrameworkStores<LearnBySpeakingContext>()
                .AddDefaultTokenProviders();

            services.AddDbContext<LearnBySpeakingContext>(options =>
            {
                options.UseSqlite(@"Data Source=D:\LearnBySpeaking2.db", x => x.MigrationsAssembly("LearnBySpeaking.Web"));
            });

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped(typeof(IRepository<,>), typeof(LearnBySpeakingRepository<,>));

            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IQuestionService, QuestionService>();

            services.AddScoped<IWiredCrawlerService, WiredCrawlerService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
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