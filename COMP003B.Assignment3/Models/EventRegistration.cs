using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration
    {
        [Required(ErrorMessage = "Enter your name")]
        [MinLength(3, ErrorMessage = "Name must contain 3 or more letters")]
        public string FullName { get; set; }


    }

}
