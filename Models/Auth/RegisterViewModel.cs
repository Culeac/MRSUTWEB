using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplication1.Models.Auth
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Numele utilizatorului este oblogatoriu")]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email-ul este oblogatoriu")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Username-ul este oblogatoriu")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Numarul de telefon este obligatoriu")]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}