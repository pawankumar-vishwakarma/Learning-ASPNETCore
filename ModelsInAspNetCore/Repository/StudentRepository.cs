using ModelsInAspNetCore.Models;

namespace ModelsInAspNetCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            //return DataSource().Where(x => x.id == id).FirstOrDefault();
            return DataSource().FirstOrDefault(student => student.id == id); //we can use anyone of both return methods
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>()
            {
                new StudentModel { id = 0, name = "Pawan", age = 23, gender = "Male" },
                new StudentModel { id = 1, name = "Manish", age = 25, gender = "Male" },
                new StudentModel { id = 2, name = "Shital", age = 21, gender = "Female" },
                new StudentModel { id = 4, name = "Raj", age = 23, gender = "Male" },
                new StudentModel { id = 5, name = "Rahul", age = 25, gender = "Male" },
                new StudentModel { id = 6, name = "Shruti", age = 26, gender = "Female" }
            };
        }
    }
}
