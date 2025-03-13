using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.ManageViewModels;

public class IndexViewModel
{
    [Display(Name = "Tài khoản")]
    public string Username { get; set; }

    public bool IsEmailConfirmed { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    [Display(Name = "Số điện thoại")]
    public string PhoneNumber { get; set; }

    public string StatusMessage { get; set; }
}