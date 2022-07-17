using learn.core.domian;
using learn.core.Repository;
using learn.core.service;
using learn.infra.domain;
using learn.infra.Repository;
using learn.infra.service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apimonth
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
            services.AddScoped<IDBcontext, DbContext>();
            services.AddScoped<ICategory_apirepository, category_apirepository>();
            services.AddScoped<Icategoryservice, categoryservice>();

            services.AddScoped<ICourserepository, courserepository>();
            services.AddScoped<Icourseservice, courseservice>();

            services.AddScoped<IDepartment_repository, Department_repository>();
            services.AddScoped<IDepartmentservice, Departmentservice>();

            services.AddScoped<IEmployee_repository, Employee_repository>();
            services.AddScoped<IEmployeeservice, Employeeservice>();

            services.AddScoped<ITaskservice, Taskservice>();
            services.AddScoped<ITask_repository, Task_repository>();

            services.AddScoped<ITaskemp_repository, Taskemp_repository>();
            services.AddScoped<ITaskempservice, Taskempservice>();

            services.AddScoped<IChecking_repository, Checking_repository>();
            services.AddScoped<ICheckingservice, Checkingservice>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
