using System.ComponentModel.DataAnnotations;

namespace SilverTouchPractical.Models
{
    public class Registration
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
