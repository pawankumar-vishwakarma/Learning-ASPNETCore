using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCoreEFCRUD.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName="varchar(100)")]
        public string Name { get; set; }
        [Column("Gender", TypeName ="varchar(10)")]
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
