
using API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
       
       
   
        public IConfiguration _Config { get;set; }
       
       public Startup(IConfiguration config)
       {
            _Config = config;
          
           

         

       }
     //public IConfiguration Configuration{get;}
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(Options=>
            {
                Options.UseSqlite(_Config.GetConnectionString("DefaultConnection"));
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>{
                c.SwaggerDoc("v1",new OpenApiInfo{ Title="WebAPIv5",Version="1.1"});

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // app.UseSwagger();
                // app.UseSwaggerUI(c=>c.SwaggerEndpoint("/swagger/v1/swagger.js","") );
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();
            

          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();


                // endpoints.MapGet("/", async context =>
                // {
                //     await context.Response.WriteAsync("Hello World!");
                // });
            });
        }
    }
}
 
