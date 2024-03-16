using static System.Reflection.Metadata.BlobBuilder;

namespace Garage_Homework_Class.Models;

public class Group
{
    public int GroupNo;
    public int GroupLimit;
    public Student[] students = new Student[0];


    public void AddStudent(Student student)
    {
        Console.WriteLine($"Please Add Name ( Student name.{students.Length + 1})");
        student.Name = Console.ReadLine();
        Console.WriteLine($"Please Add Surname (Student surname. {students.Length + 1})");
        student.Surname = Console.ReadLine();
    }
    public void GetStudent()
    {
        foreach (Student student in students)
        {
            if (student == null)
            {
                Console.WriteLine("Student Not Found");
                return;
            }
            else
            {
                Console.WriteLine($"Group:{GroupNo}, Student name:{student.Name},Student surname:{student.Surname}");
            }
        }
    }

}
