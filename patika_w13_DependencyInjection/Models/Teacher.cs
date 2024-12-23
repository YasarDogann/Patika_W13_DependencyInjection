using patika_w13_DependencyInjection.Interfaces;

namespace patika_w13_DependencyInjection.Models
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public Teacher() 
        {
            // Varsayılan veri test amaçlı
            FirstName = "Default";
            LastName = "Teacher";
        }

        public string GetInfo()
        {
            return $"Öğretmen Adı-Soyadı: {FirstName} {LastName}";
        }
    }
}
