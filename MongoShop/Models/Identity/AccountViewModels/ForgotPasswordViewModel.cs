﻿using System.ComponentModel.DataAnnotations;

namespace MongoShop.Models.Identity.AccountViewModels;

public class ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}