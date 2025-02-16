using System.Collections.Concurrent;
using Jexessment.Models;

namespace Jexessment.Repositories;

public class VacancyRepository : IVacancyRepository
{
    private readonly ConcurrentDictionary<string, Vacancy> vacancies;

    public VacancyRepository()
    {
        vacancies = new ConcurrentDictionary<string, Vacancy>();
    }

    public void Add(Vacancy vacancy)
    {
        vacancies.TryAdd(vacancy.Title, vacancy);
    }

    public void AddVacancy(Vacancy vacancy)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Vacancy>> GetVacancies(string name)
    {
        return Task.Run(async () =>
        {
            await Task.Delay(400);        // Simulate processing time
            IEnumerable<Vacancy> filtered = vacancies.Values;
            if (!String.IsNullOrEmpty(name))
                filtered = filtered.Where(it => it.Title != null && it.Title.StartsWith(name, StringComparison.InvariantCultureIgnoreCase));
            return filtered;
        });
    }

    public async Task<IEnumerable<Vacancy>> GetVacancies() => [new Vacancy{
                IdVacancy = Guid.NewGuid(),
                IdCompany = Guid.NewGuid(),
                Title = "Programmer",
                Description = "A good one"}];
}