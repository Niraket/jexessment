using System.ComponentModel.DataAnnotations;

namespace Jexessment.Models;

public class Company {

    //[Required]
    public Guid IdCompany { get; set; }

    //[Required]
    public string Name { get; set; }

    public string Address { get; set; }

}