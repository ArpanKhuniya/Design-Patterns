using System;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Dictionary<string, double> StudentCoursesGrade = new Dictionary<string, double>(); 

    public Student(string firstName, string lastName) 
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }


    public void EnrollCourse(string courseName)
    {
        if (StudentCoursesGrade.ContainsKey(courseName))
        {
            Console.WriteLine(FirstName + " " + LastName + "has already enrolled for {0}", courseName);
        }
        else
        {
            StudentCoursesGrade[courseName] = 0;
        }
    }

    public void AssignGrade(string courseName, double grade)
    {
        StudentCoursesGrade[courseName] = grade;
    }

}

public class GPACalculator
{
    public double CalculateGPA(Student student)
    {
        return student.StudentCoursesGrade.Values.Average();
    }
}

public class TranscriptGenerator
{
    private GPACalculator _gpaCalculator;
    public TranscriptGenerator(GPACalculator gpaCalculator)
    {
        _gpaCalculator = gpaCalculator;
    }
    public void PrintTranscript(Student student)
    {
        Console.WriteLine($"Transcript for {student.FirstName} {student.LastName}");
        foreach (var course in student.StudentCoursesGrade)
        {
            Console.WriteLine($"{course.Key}: {course.Value}");
        }
        Console.WriteLine($"GPA: {_gpaCalculator.CalculateGPA(student)}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Student alice = new Student("Alice" ,"Morris");
        alice.EnrollCourse("Mathematics");
        alice.AssignGrade("Mathematics", 90);
        GPACalculator gpaCalc = new GPACalculator();
        TranscriptGenerator transcriptGen = new TranscriptGenerator(gpaCalc);
        transcriptGen.PrintTranscript(alice);

        Console.ReadKey();
    }
}