using Jexessment.Contracts;
using Jexessment.Models;
using Jexessment.Repositories;
using Jexessment.Service;
using Microsoft.AspNetCore.Mvc;

namespace Jexessment;

public static class Program
{    
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddTransient<IVacancyRepository, VacancyRepository>();
        builder.Services.AddTransient<IJexessmentService, JexessmentService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();        

        app.MapGet("/getvacancies", async ([FromServices] IJexessmentService service) =>
        {
            return await service.GetVacancies();
        })
        .WithName("GetVacancies");

        app.MapPost("/addvacancy", async (Vacancy vacancy, [FromServices] IJexessmentService service) =>
        {
            service.AddVacancy(vacancy);
            return Results.Created($"/addvacancy/{vacancy.Id}", vacancy);
        })
        .WithName("AddVacancy");

        await app.RunAsync();
    }
}
