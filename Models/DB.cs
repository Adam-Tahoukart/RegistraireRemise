// Fichier qui donne acces aux donnees json
namespace PFI.Models
{
    public static class DB
    {
        public static Repository<User> Users = new Repository<User>("Users");
        public static Repository<Student> Students = new Repository<Student>("Students");
        public static Repository<Course> Courses = new Repository<Course>("Courses");
        public static Repository<Teacher> Teachers = new Repository<Teacher>("Teachers");
        public static Repository<Registration> Registrations = new Repository<Registration>("Registrations");
        public static Repository<Allocation> Allocations = new Repository<Allocation>("Allocations");
    }
}