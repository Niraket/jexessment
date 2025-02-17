using System.ComponentModel.DataAnnotations;

namespace Jexessment.Models;

public class Vacancy {

    [Required]
    public int Id { get; set; }
    
    [Required]
    public int CompanyId { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; }

    public Company Company { get; set; }

}