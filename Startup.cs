using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentManagement.Models;

namespace StudentManagement
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        { //MvcOptions.EnableEndpointRouting = false;
            services.AddMvc(option => option.EnableEndpointRouting = false).AddXmlSerializerFormatters();
            services.AddSingleton<IStudentRepository, MockStudentRepository>();
          //  services.AddMvcCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            ////默认文件中间件
            //app.UseDefaultFiles();
            ////添加静态文件中间件
            app.UseStaticFiles();
            
          //  app.UseFileServer();
            //默认路由
            app.UseMvcWithDefaultRoute();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
            app.Run(async (context) =>
            {
                //throw new Exception("错误！");
                await context.Response.WriteAsync("run str");
            });
        }
    }
}
