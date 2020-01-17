using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class EmployeeCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee Number is required"),
            RegularExpression(@"^[A-Z]{3,3}[0-9]{3}$")]
        public string EmployeeNum { get; set; }
        [Required(ErrorMessage = "First Name is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [MaxLength(50), Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName {
            get{
} 
        }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string SocialSecurityNum { get; set; }
        public PaymentMethod Paymentmethod { get; set; }
        public StudentLoan StudentLoan { get; set; }
        public UnionMember UnionMember { get; set; }
        [Required, MaxLength(150)]
        public string Address { get; set; }
        [Required, MaxLength(50)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string Postcode { get; set; }
    }
}
