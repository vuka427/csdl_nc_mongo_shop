using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.ManageViewModels;

public class EnableAuthenticatorViewModel
{
    [Required]
    [StringLength(7, ErrorMessage = "{0} tối thiểu {2} và tối đa {1} ký tự.", MinimumLength = 6)]
    [DataType(DataType.Text)]
    [Display(Name = "Mã xác thực từ ứng dụng auth")]
    public string Code { get; set; }

    [BindNever]
    public string SharedKey { get; set; }

    [BindNever]
    public string AuthenticatorUri { get; set; }
}