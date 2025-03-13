using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.AccountViewModels;

public class LoginViewModel
{
    [Required]
    [Display(Name ="Tài khoản")]
    public string Username { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu")]
    public string Password { get; set; }

    [Display(Name = "Nhớ mật khẩu?")]
    public bool RememberMe { get; set; }
}