using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Second.Models
{
    public class DataModel
    {
        [Key]
        public int StdID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Plesae enter your Fist Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Must be 3 latters")]
        public string firstname { get; set; }
        [Column(TypeName = "varchar(20)")]

        [System.ComponentModel.DataAnnotations.Display(Name = "Last Name")]
        [Required(ErrorMessage = "Plesae enter your Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Must be 3 latters")]
        public string lastname { get; set; }
        [Column(TypeName = "varchar(20)")]

        [System.ComponentModel.DataAnnotations.Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Plesae enter your Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
       

       /* [System.ComponentModel.DataAnnotations.Display(Name = "Gender")]
        [Required(ErrorMessage = "Plesae enter your Gender")]
        public string gender { get; set; }
        [Column(TypeName = "varchar(20)")]*/

        [Required(ErrorMessage = "Plesae enter your email")]
        [System.ComponentModel.DataAnnotations.Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Pleas enter a valid email address")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Plesae enter a strong password")]
        [System.ComponentModel.DataAnnotations.Display(Name = "Password")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Pleas enter only intgers")]
        //[StringLength(20, MinimumLength = 4, ErrorMessage = "Must be at least 4 characters long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Plesae confirm your password")]
        [Compare("Password", ErrorMessage = "Password dose not match")]
        [System.ComponentModel.DataAnnotations.Display(Name = "Confirm Password")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Pleas enter only intgers")]
        public string ConfirmPassword { get; set; }


        [System.ComponentModel.DataAnnotations.Display(Name = "Security Question")]
        public string securityQ { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Security Answer")]
        [Required(ErrorMessage = "Plesae enter your Security Answer")]
        public string securityA { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Address")]
        [Required(ErrorMessage = "Plesae enter your Address")]
        //[StringLength(100, MinimumLength = 4)]
        public string address { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "State")]
        [Required(ErrorMessage = "Plesae enter your State")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        public string state { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Plesae enter your Zip Code")]
        //[StringLength(4, MinimumLength = 4, ErrorMessage = "Must be 4 digits")]

        public int zipcode { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Mobile")]
        [Required(ErrorMessage = "Plesae enter your Phone")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Pleas enter only intgers")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "Must be 11 digits")]
        public string phone { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "City")]
        [Required(ErrorMessage = "Plesae enter your City")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Pleas enter only alphabets")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Must be 3 latters")]
        public string city { get; set; }
    }
}
