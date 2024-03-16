

using Garage_Homework_Class.Models;


Group group = new Group();
Console.WriteLine("Add a group number");
group.GroupNo = int.Parse(Console.ReadLine());
Console.WriteLine("How many student will be in the group");
group.GroupLimit = int.Parse(Console.ReadLine());
for (int i = 0; i < group.GroupLimit; i++)
{
    Student student = new Student();
    group.AddStudent(student);
    Array.Resize(ref group.students, group.students.Length+1);
    group.students[group.students.Length - 1] = student;
    Console.WriteLine("Student Added");
}

group.GetStudent();