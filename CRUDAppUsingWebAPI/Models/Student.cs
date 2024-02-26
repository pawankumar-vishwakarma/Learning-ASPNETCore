using Microsoft.Build.Framework;

namespace CRUDAppUsingWebAPI.Models
{

    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Std { get; set; }
        [Required]
        public string FatherName { get; set; }
    }

}
