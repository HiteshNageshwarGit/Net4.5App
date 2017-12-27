using System.ComponentModel.DataAnnotations;

namespace Code_First_EF.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mobile { get; set; }
    }
}