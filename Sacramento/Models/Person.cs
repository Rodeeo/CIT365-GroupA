using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Person
    {
        public int ID { get; set; }

        [StringLength(40, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required]
        public string Phone { get; set; }
    }
}