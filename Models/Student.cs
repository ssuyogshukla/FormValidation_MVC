using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormValidation_MVC.Models
{
    public class Student
    {
        [DisplayName("Roll no:")]
        [Required(ErrorMessage ="Has to be No:")]
        public int roll { get; set; }
        [DisplayName("Name:")]
        [Required (ErrorMessage ="Feild not be Empty :")]
        
        public string name { get; set; }

        [DisplayName("Dob:")]
        [Required (ErrorMessage ="Correct ? ")]
        public  DateTime   Dob { get; set; }


        [DisplayName("Email:")]
        [EmailAddress (ErrorMessage =("Invalid Mail "))]
        public string email { get; set; }
    

        [DisplayName("Mobile no:")]
        [StringLength(12,ErrorMessage ="Less 13 & greater than 10 : ")]
        public string mob { get; set; }
    }
}
