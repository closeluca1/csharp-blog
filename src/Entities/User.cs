using System.ComponentModel.DataAnnotations;

namespace Entities;

public class User : BaseEntity
{
    public Guid Id { get; set; }
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string PasswordHash { get; set; }
    public string Role { get; set; } = "Default";
}