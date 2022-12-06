using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopAdmin.ViewModels;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    public string? UserName { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; }
}