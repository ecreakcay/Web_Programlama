﻿using System.ComponentModel.DataAnnotations;

namespace UcakRez.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen cinsiyet giriniz")]
		public string Gender { get; set; }

		[Required(ErrorMessage = "Lütfen fotoğraf ekleyiniz")]
		public string ImageUrl { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler eşleşmiyor!")]
		public string ConfirmPassword { get; set; }
	}
}
