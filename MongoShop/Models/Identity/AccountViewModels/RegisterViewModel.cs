using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.AccountViewModels;

public class RegisterViewModel
{
    [Required]
    [Display(Name = "Tài khoản")]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "{0} tối thiểu {2} và tối đa {1} ký tự.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Nhập lại mật khẩu")]
    [Compare("Password", ErrorMessage = "Mật khẩu không khớp.")]
    public string ConfirmPassword { get; set; }
}