using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.ManageViewModels;

public class ChangePasswordViewModel
{
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu hiện tại")]
    public string OldPassword { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "{0} tối thiểu {2} và tối đa {1} ký tự.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu mới")]
    public string NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Nhập lại mật khẩu")]
    [Compare("NewPassword", ErrorMessage = "Mật khẩu không khớp")]
    public string ConfirmPassword { get; set; }

    public string StatusMessage { get; set; }
}