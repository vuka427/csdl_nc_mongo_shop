using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.AccountViewModels;

public class ExternalLoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}