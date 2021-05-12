using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using ToroChallenge.Data;
using ToroChallenge.Domain;
using ToroChallenge.PapelContexto.Domain.Entities;
using ToroChallenge.PapelContexto.Domain.Handlers;
using ToroChallenge.PapelContexto.Domain.Repositories;
using ToroChallenge.TransferenciaContexto.Domain.Entities;
using ToroChallenge.TransferenciaContexto.Domain.Handlers;

namespace ToroChallenge.WebApi
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

            services.AddControllers();

            //Assembly assem = typeof(Response).Assembly;
            //services.AddMediatR(assem);
            Assembly assem = typeof(Ordem).Assembly;
            services.AddMediatR(assem);
            //assem = typeof(Transferencia).Assembly;
            //services.AddMediatR(assem);
            services.AddTransient<IPapelRepository, PapelRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ToroChallenge.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ToroChallenge.WebApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
