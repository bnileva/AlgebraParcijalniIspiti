using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.Models;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required, StringLength(50)]
    public string Address { get; set; }

    [StringLength(50)]
    public string? CompanyName { get; set; }

    [StringLength(50)]
    public string? Designation { get; set; }
}

