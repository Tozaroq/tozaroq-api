using Microsoft.EntityFrameworkCore;
using Tozaroq.Api.Data;

namespace Tozaroq.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
          
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            string postgreConnectionString = builder.Configuration.GetConnectionString("POSTGRES");
            builder.Services.AddDbContext<TozaroqDbContext>(o => o.UseNpgsql(postgreConnectionString));

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
