using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.AccountViewModels;

public class ResetPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "{0} tối thiểu {2} và tối đa {1} ký tự.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Nhập lại khẩu")]
    [Compare("Password", ErrorMessage = "Mật khẩu không khớp.")]
    public string ConfirmPassword { get; set; }

    public string Code { get; set; }
}