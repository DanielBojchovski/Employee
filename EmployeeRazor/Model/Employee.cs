using System.ComponentModel.DataAnnotations;

namespace EmployeeRazor.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is required./ Името е задолжително")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "FirstName must be between 2 and 50 characters./ Името треба да биде помеѓу 2 и 50 букви.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required./ Презимето е задолжително")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "LastName must be between 2 and 50 characters./ Презимето треба да биде помеѓу 2 и 50 букви.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Employee's salary is required./ Платата на вработениот е задолжителна")]
        [Range(18000, double.MaxValue, ErrorMessage = "Salary must be atleast 18000 denars./ Платата мора да биде во минимум 18000 денари.")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Employee's email address is required./ Email адресата на вработениот е задолжителна")]
        [StringLength(50, ErrorMessage = "Email's length cannot exceed 50 characters./ Email адресата не смее да надмине 50 знаци")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
