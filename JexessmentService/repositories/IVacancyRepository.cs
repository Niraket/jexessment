using Jexessment.Models;

namespace Jexessment.Repositories;

public interface IVacancyRepository 
{
    void AddVacancy(Vacancy vacancy);

    //[Query]
    Task<IEnumerable<Vacancy>> GetVacancies();
}