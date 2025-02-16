using Jexessment.Contracts;
using Jexessment.Models;
using Jexessment.Repositories;

namespace Jexessment.Service;

public class JexessmentService: IJexessmentService
{
    private readonly IVacancyRepository vacancyRepository;

    public JexessmentService(IVacancyRepository vacancyRepository)
    {
        this.vacancyRepository = vacancyRepository;
    }

    public void AddVacancy(Vacancy vacancy)
    {
        vacancyRepository.AddVacancy(vacancy);
    }

    public Task<IEnumerable<Vacancy>> GetVacancies()
    {
        return vacancyRepository.GetVacancies();
    }
}