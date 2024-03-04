using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Entities;

public class ProfileEntity
{
    [Key]
    [ForeignKey(nameof(UserEntity))]
    public Guid UserId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = null!;

    [Column(TypeName = "nvarchar(50)")]
    public string? StreetName { get; set; }

    [Column(TypeName = "varchar(6)")]
    public string? PostalCode { get; set; } 

    [Column(TypeName = "nvarchar(50)")]
    public string? City { get; set; }

    public virtual UserEntity User { get; set; } = null!;

}
