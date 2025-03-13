using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.ManageViewModels;

public class SetPasswordViewModel
{
    [Required]
    [StringLength(100, ErrorMessage = "{0} tối thiểu {2} và tối đa {1} ký tự.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu mới")]
    public string NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Nhập lại mật khẩu")]
    [Compare("NewPassword", ErrorMessage = "{0} tối thiểu {2} và tối đa {1} ký tự.")]
    public string ConfirmPassword { get; set; }

    public string StatusMessage { get; set; }
}