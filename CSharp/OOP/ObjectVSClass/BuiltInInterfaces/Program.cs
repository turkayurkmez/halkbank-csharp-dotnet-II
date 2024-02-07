// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");
Student student1 = new Student { Id = 1, Name = "Türkay", Age = 44, Score = 75 };
Student student2 = new Student { Id = 2, Name = "Okan", Age = 28, Score = 100 };
Student student3 = new Student { Id = 1, Name = "Semra", Age = 27, Score = 80 };

ClassRoom classRoom = new ClassRoom();
classRoom.Add(student1);
classRoom.Add(student2);
classRoom.Add(student3);


//var sorted = classRoom.GetSortedStudents();
foreach (var student in classRoom)
{
    Console.WriteLine(student);
}