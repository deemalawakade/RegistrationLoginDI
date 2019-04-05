using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegistrationUtilities
{
   public class RegisterMM
    {
        public long ID { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Required]
        public string EmailID { get; set; }

        [DataType(DataType.PhoneNumber)]
        public Nullable<decimal> PhoneNo { get; set; }


        public string Address { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string Capta { get; set; }
    }
}
