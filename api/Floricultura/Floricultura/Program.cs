using Floricultura.Data;
using Floricultura.Data.Client;
using Floricultura.Domain.Aws;
using Floricultura.Domain.Interfaces.Clients;
using Floricultura.Domain.Interfaces.Services;
using Floricultura.Domain.Profiles;
using Floricultura.Services.Services;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services
            .AddEntityFrameworkSqlServer()
            .AddDbContext<Context>(options =>
        options.UseSqlServer(
            GlobalSecrets.Configuracoes.ConnectionString
            ));

        builder.Services.AddScoped<IMenuService, MenuService>();
        builder.Services.AddScoped<IProdutoService, ProdutoService>();

        builder.Services.AddScoped<IS3Client, S3Client>();

        builder.Services.AddAutoMapper(typeof(ProdutoProfile).Assembly);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(x => x
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}