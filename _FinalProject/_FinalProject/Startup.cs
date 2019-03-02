using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using _FinalProject.Model.Models;
using _FinalProject.Data.Context;
using System;
using Data.Interfaces;
using Data.Implementations.MockRepositories;
using Service.Services;
using Microsoft.AspNetCore.Identity;
using Data.Implementations.EFCoreRepositories;

namespace _FinalProject
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //MockImplementation
            //GetDependencyResolvedForMockRepositoryLayer(services);

            //EFCore Implementation
            GetDependencyResolvedForEFCoreRepositoryLayer(services);

            //ServiceLayer Implementation
            GetDependencyResolvedForServiceLayer(services);

            //service for DbContext
            services.AddDbContext<FinalProjectDBContext>();

            //service for Identitiy
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<FinalProjectDBContext>();
            //using MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            //use Identity Service
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void GetDependencyResolvedForMockRepositoryLayer(IServiceCollection services)
        {
            services.AddScoped<ICalendarRepository, MockCalendarRepository>();
            services.AddScoped<IEventRepository, MockEventRepository>();
            services.AddScoped<ICommentRepository, MockCommentRepository>();
            services.AddScoped<ILetterRepository, MockLetterRepository>();
            services.AddScoped<IMapRepository, MockMapRepository>();
            services.AddScoped<IPostRepository, MockPostRepository>();
            services.AddScoped<IRobinRepository, MockRobinRepository>();
            services.AddScoped<ISubmissionStatusRepository, MockSubmissionStatusRepository>();
            services.AddScoped<IUsersByRobinRepository, MockUsersByRobinRepository>();
            services.AddScoped<IUsersRepository, MockUserRepository>();
        }
        private void GetDependencyResolvedForEFCoreRepositoryLayer(IServiceCollection services)
        {
            services.AddScoped<ICalendarRepository, EFCoreCalendarRepository>();
            services.AddScoped<ICommentRepository, EFCoreCommentRepository>();
            services.AddScoped<ILetterRepository, EFCoreLetterRepository>();
            services.AddScoped<IMapRepository, EFCoreMapRepository>();
            services.AddScoped<IPostRepository, EFCorePostRepository>();
            services.AddScoped<IRobinRepository, EFCoreRobinRepository>();
            services.AddScoped<ISubmissionStatusRepository, EFCoreSubmissionStatusRepository>();
            services.AddScoped<IUsersByRobinRepository, EFCoreUsersByRobinRepository>();
            services.AddScoped<IUsersRepository, EFCoreUserRepository>();
            services.AddScoped<IEventRepository, EFCoreEventRepository>();
        }

        private void GetDependencyResolvedForServiceLayer(IServiceCollection services)
        {
            services.AddScoped<ICalendarService, CalendarService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ILetterService, LetterService>();
            services.AddScoped<IMapService, MapService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IRobinService, RobinService>();
            services.AddScoped<ISubmissionStatusService, SubmissionStatusService>();
            services.AddScoped<IUsersByRobinService, UsersByRobinService>();
            services.AddScoped<IUsersService, UsersService>();
        }
    }
}
