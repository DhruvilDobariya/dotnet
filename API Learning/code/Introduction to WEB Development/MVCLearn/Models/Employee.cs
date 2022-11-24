using System.ComponentModel.DataAnnotations;

namespace MVCLearn.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Employee Name")]
        public string Name { get; set; } = null!;
    }
}
