namespace StudentManagementSystemCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }     // Primary key
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
//This class defines the structure of the Students table in the database.
//Each property = one column.
