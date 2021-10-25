using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Identity.Models.Account
{
	public class PasswordViewModel
	{
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Identity.Account.Password")]
		[MaxLength(100, ErrorMessage = "Models.MaxLength")]
		public string? Password { get; set; }
	}
}
