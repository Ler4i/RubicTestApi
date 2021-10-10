using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RubicTestApi.Controllers;
using RubicTestApi.Context;

namespace RubicTestApi
{
    public class Startup//сам сервер
    {
        public Startup(IConfiguration configuration)//конструктор
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddDbContext<NoteContext>(opt => //бегает за нас в сервер
                opt.UseInMemoryDatabase("TestDB"));

            services.AddDbContext<UserContext>(opt =>
                opt.UseInMemoryDatabase("TestDB"));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//обязателен!!! app - важная переменная(сам сервер)
        {
            if (env.IsDevelopment())//потерн конвеер(все по порядку)
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(option => option.WithOrigins("http://localhost:8080").AllowAnyMethod());

            app.UseRouting();//ходит по всем контролерам: route- ссылка на наш сервер на сайте

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>//маппинг- сопоставление одного с другим(надо указывать)
            {
                endpoints.MapControllers();
            });//заканчивается потерн конвеер(все по порядку)
        }
    }
}
