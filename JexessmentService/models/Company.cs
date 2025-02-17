using System.ComponentModel.DataAnnotations;

namespace Jexessment.Models;

public class Company {

    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Address { get; set; }

    public List<Vacancy> Vacancies { get; } = new();
}