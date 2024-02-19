using ModelsInAspNetCore.Models;

namespace ModelsInAspNetCore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
