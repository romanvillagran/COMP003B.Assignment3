using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration
    {
        [Required(ErrorMessage = "Enter your name")]
        [MinLength(3, ErrorMessage = "Name must contain 3 or more letters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is needed")]
        [EmailAddress(ErrorMessage = "Not a real email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "How many tickets")]
        [Range(1,10,ErrorMessage = "can get up to 10 tickets")]
        public int Tickets { get; set; }

        public string ReferralCode { get; set; }
    }

}
