using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Hospital hospital = new Hospital();
        hospital.Departments = new List<Department>();

        while (input[0] != "Output")
        {
            string depa = input[0];
            string doct = input[1] + " " + input[2];
            string pati = input[3];
            if (input.Length == 5)//if pacient have two names
            {
                pati = input[3] + " " + input[4];
            }

            Pacients pacients = new Pacients { Name = pati };
            if (hospital.Departments.Where(d => d.Name == depa).Count() == 0)
            {
                Department department = new Department();
                department.Name = depa;

                department.Patients = new List<Pacients>();
                hospital.Departments.Add(department);
                department.Patients.Add(pacients);
            }
            else
            {
                hospital.Departments.Find(d => d.Name == depa).Patients.Add(pacients);
            }
            if (hospital.Doctors.Where(d => d.Name == doct).Count() == 0)//there is no such doctor
            {
                Doctor doctor = new Doctor();
                doctor.Name = doct;
                doctor.Patients = new List<Pacients>();
                hospital.Doctors.Add(doctor);
                doctor.Patients.Add(pacients);
            }
            else
            {
                hospital.Doctors.Find(d => d.Name == doct).Patients.Add(pacients);

            }
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        string[] commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        while (commands[0] != "End")
        {
            if (commands.Length == 1)//we search depatment pacients
            {
                var department = hospital.Departments.Find(d => d.Name == commands[0]).Patients.Take(60).ToList();
                foreach (var pacient in department)
                {
                    Console.WriteLine(pacient.Name);
                }
            }
            if (commands.Length == 2)
            {
                int n;
                bool isNumeric = int.TryParse(commands[1], out n);//we search doctor->pacients
                if (isNumeric == false)
                {
                    var doctor = hospital.Doctors.Find(d => d.Name == commands[0] + " " + commands[1]).Patients.OrderBy(p => p.Name).ToList();
                    foreach (var patient in doctor)
                    {
                        Console.WriteLine(patient.Name);
                    }
                }
                else//we search category room
                {
                    int roomNumber = int.Parse(commands[1]);
                    List<Pacients> patient = hospital.Departments.Find(d => d.Name == commands[0]).Patients.Skip(3 * (roomNumber - 1)).Take(3).OrderBy(p => p.Name).ToList();

                    foreach (var p in patient)
                    {
                        Console.WriteLine(p.Name);
                    }
                }

            }
            commands = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}

public class Hospital
{
    public Hospital()
    {
        this.Departments = new List<Department>();
        this.Doctors = new List<Doctor>();
    }
    public List<Department> Departments { get; set; }
    public List<Doctor> Doctors { get; set; }
}
public class Department
{
    public Department()
    {
        this.Patients = new List<Pacients>();
        this.Rooms = new List<Room>();
    }
    public string Name { get; set; }
    public List<Pacients> Patients { get; set; }
    public List<Room> Rooms { get; set; }
}

public class Doctor
{
    public Doctor()
    {
        this.Patients = new List<Pacients>();
    }
    public string Name { get; set; }
    public List<Pacients> Patients { get; set; }
}

public class Pacients
{
    public string Name { get; set; }

}
public class Room
{
    public Room()
    {
        this.Patients = new List<Pacients>();
    }

    public List<Pacients> Patients { get; set; }
}

