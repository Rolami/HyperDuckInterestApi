
using HyperDuckInterestApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using HyperDuckInterestApi.Data;

namespace HyperDuckInterestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);


            //builder.Services.AddDbContext<HyperDuckInterestApiContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("HyperDuckInterestApiContext") ?? throw new InvalidOperationException("Connection string 'HyperDuckInterestApiContext' not found.")));

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<HyperDuckInterestApiContext>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}


