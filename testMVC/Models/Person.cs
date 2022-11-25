using System.ComponentModel.DataAnnotations;
namespace testMVC.Models
{
    public class Person
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; } = String.Empty;
        [Range(16,62,ErrorMessage ="Age 16-62 only ")]
        public int Age { get; set; }
        public string Location { get; set; } = String.Empty;
    }
}
