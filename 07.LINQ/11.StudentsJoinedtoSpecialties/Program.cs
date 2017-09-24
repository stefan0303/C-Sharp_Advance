using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>();
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray(); ;
        while (input[0] != "Students:")
        {
            var speciality = new StudentSpecialty(input[0] + " " + input[1], input[2]);
            studentSpecialties.Add(speciality);
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        input = Console.ReadLine().Split(' ').ToArray();
        while (input[0] != "END")
        {
            var student = new Student(input[1] + " " + input[2], input[0]);
            students.Add(student);
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        var studentsNameFacultyNumberSpecialName = studentSpecialties.Join(students, sp => sp.FacultyNumber,
            st => st.FacultyNumber, (sp, st) => new
            {
                st.Name,
                sp.FacultyNumber,
                sp.Specialty
            }
        ).OrderBy(res => res.Name).ToList();
        foreach (var studentsFaculty in studentsNameFacultyNumberSpecialName)
        {
            Console.WriteLine(studentsFaculty.Name + " " + studentsFaculty.FacultyNumber + " " + studentsFaculty.Specialty);
        }
    }
}

class StudentSpecialty
{
    public StudentSpecialty(string speciality, string facultynumber)
    {
        this.FacultyNumber = facultynumber;
        this.Specialty = speciality;

    }
    public string Specialty { get; set; }

    public string FacultyNumber { get; set; }
}

class Student
{
    public Student(string name, string facultyNumber)
    {
        this.Name = name;
        this.FacultyNumber = facultyNumber;
    }
    public string Name { get; set; }

    public string FacultyNumber { get; set; }
}

