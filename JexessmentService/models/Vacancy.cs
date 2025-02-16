using System.ComponentModel.DataAnnotations;

namespace Jexessment.Models;

public class Vacancy {

    //[Required]
    public Guid IdVacancy { get; set; }
    
    //[Required]
    public Guid IdCompany { get; set; }

    //[Required]
    public string Title { get; set; }

    public string Description { get; set; }

}