using System;
using System.Collections.Generic;

namespace ASPCoreAPICRUD.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public int Std { get; set; }
        public string FatherName { get; set; } = null!;
    }
}
