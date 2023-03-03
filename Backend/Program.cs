using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository;
using oraclebam.Repository.Interface;
using System.Data.Common;

namespace oraclebam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddEntityFrameworkSqlServer().AddDbContext<ModelContext>(options => options.UseOracle(builder.Configuration.GetConnectionString("dbConnection")));
            builder.Services.AddScoped<IMvSysSefExchangeFileRepository, MvSysSefExchangeFileRepository>();
            builder.Services.AddScoped<IQvSysSelExchangeLogRepository, QvSysSelExchangeLogRepository>();
            builder.Services.AddScoped<IMvSysSehExchangeHostRepository, MvSysSehExchangeHostRepository>(); 
            builder.Services.AddScoped<IMvSysSeoExchangeOperationRepository, MvSysSeoExchangeOperationRepository>();
            builder.Services.AddScoped<IMvSysSegEmailGroupRepository, MvSysSegEmailGroupRepository>();
            builder.Services.AddScoped<IQvSysSsmSystemMailRepository, QvSysSsmSystemMailRepository>();
            builder.Services.AddScoped<IMvSysSjqJobQueueRepository, MvSysSjqJobQueueRepository>();
            builder.Services.AddScoped<IMvSysSjJobRepository, MvSysSjJobRepository>();
            builder.Services.AddScoped<IMvSysSxExceptionRepository, MvSysSxExceptionRepository>();
            builder.Services.AddScoped<IMvSysSvxValueExceptionRepository, MvSysSvxValueExceptionRepository>();

            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            #region [Cors]
            builder.Services.AddCors();

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });
            #endregion
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}