using Jexessment.Models;

namespace Jexessment.Contracts;

public interface IJexessmentService
{
    void AddVacancy(Vacancy vacancy);

    //[Query]
    Task<IEnumerable<Vacancy>> GetVacancies();
}

