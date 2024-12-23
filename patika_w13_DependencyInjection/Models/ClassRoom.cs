using patika_w13_DependencyInjection.Interfaces;

namespace patika_w13_DependencyInjection.Models
{
    public class ClassRoom
    {
        // Dependency Injection ile gelen ITeacher bağımlılığı
        private readonly ITeacher _teacher;

        // Constructor Injection
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        // Öğretmenin bilgilerini döndüren metot
        public void GetTeacherInfo()
        {
            // ITeacher arayüzüne ait GetInfo() çağrılır
            string teacherInfo = _teacher.GetInfo();

            Console.WriteLine(teacherInfo);
        }
    }
}
