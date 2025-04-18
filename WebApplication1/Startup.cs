using Autofac;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Autofac.Extensions.DependencyInjection;
using Infrastructure.Data;
using Application.Common;

namespace ReservePro.Managemant.Api
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration _configuration { get; set; } = configuration;
        
        public void ConfigureContainer(ContainerBuilder builder)
        {

            builder.RegisterModule(new AutoFacModule());
        }
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // TODO Open these when use auth0 
            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutofac();
            services.AddAutoMapper(typeof(MappingConfig)); 
            services.AddDbContext<ReminderDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DbConection")));

            services.AddControllers(); 

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Reminder.Managment.Api", Version = "v1" });
            });
        }
    }
}
