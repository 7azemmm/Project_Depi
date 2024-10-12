namespace Depi_Project.Models{
    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Equipment
{
    [Key]
    public int Equipment_Id { get; set; }
    [Required]
    public string? Equipment_Name {get ;set;}
    [Required]
    public string? Maintainance_Date {get ; set;}
    [Required]
    public string ? Status {get ; set ;}
}
}

