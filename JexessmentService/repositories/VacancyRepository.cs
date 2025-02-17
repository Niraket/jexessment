using System.Collections.Concurrent;
using Jexessment.Models;
using Microsoft.EntityFrameworkCore;

namespace Jexessment.Repositories;

public class VacancyRepository : IVacancyRepository
{
    private VacancyDbContext db;

    public VacancyRepository()
    {
        db = new VacancyDbContext();
    }

    public async void AddVacancy(Vacancy vacancy)
    {
        db.Vacancies.Add(vacancy);
        await db.SaveChangesAsync();
    }

    public async Task<IEnumerable<Vacancy>> GetVacancies() =>
        await db.Vacancies.ToListAsync();
}