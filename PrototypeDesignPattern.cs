using System;
using System.Collections.Generic;

public class EducationSystem
{
    private List<Institution> institutions;

    public EducationSystem()
    {
        institutions = new List<Institution>();
    }

    public void AddInstitution(Institution institution)
    {
        institutions.Add(institution);
    }

    public void RemoveInstitution(Institution institution)
    {
        institutions.Remove(institution);
    }

    public List<Institution> GetInstitutions()
    {
        return institutions;
    }
}

public class Institution : ICloneable
{
    public string Name { get; }
    public string Location { get; }
    private List<Department> departments;

    public Institution(string name, string location)
    {
        Name = name;
        Location = location;
        departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    public object Clone()
    {
        return new Institution(Name, Location);
    }
}

public class Department : ICloneable
{
    public string Name { get; }
    private List<Teacher> teachers;

    public Department(string name)
    {
        Name = name;
        teachers = new List<Teacher>();
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public object Clone()
    {
        return new Department(Name);
    }
}

public class Teacher : ICloneable
{
    public string Name { get; }
    public string Subject { get; }

    public Teacher(string name, string subject)
    {
        Name = name;
        Subject = subject;
    }

    public object Clone()
    {
        return new Teacher(Name, Subject);
    }
}

public class Student : ICloneable
{
    public string Name { get; }
    public int Age { get; }
    public string Gender { get; }
    public string Major { get; }
    private List<Course> courses;

    public Student(string name, int age, string gender, string major)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Major = major;
        courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public object Clone()
    {
        return new Student(Name, Age, Gender, Major);
    }
}

public class Course : ICloneable
{
    public string Name { get; }
    public string Instructor { get; }
    public string Schedule { get; }

    public Course(string name, string instructor, string schedule)
    {
        Name = name;
        Instructor = instructor;
        Schedule = schedule;
    }

    public object Clone()
    {
        return new Course(Name, Instructor, Schedule);
    }
}
