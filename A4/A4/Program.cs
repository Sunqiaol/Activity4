using System;

interface IStudent
{
    void StudentDetail();
    void TestDetail();
}

class Student : IStudent
{
    public string Name { get; set; }
    public string Major { get; set; }
    public double gpa { get; set; }


    private int[] testgrade = new int[10];
    
    public int this[int i]
    {
        get
        {
            return testgrade[i];
        }
        set
        {
            testgrade[i]= value;
        }
    }
    public void StudentDetail()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Major : " + Major);
        Console.WriteLine("Gpa : " + gpa);
    }

    public void TestDetail()
    {
        for (int i = 0; i < 5; i++)
        {
            if (testgrade[i] != null) {
                Console.WriteLine(testgrade[i]);
        }
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Sunqiao Lin",
            Major = "Computer Science",
            gpa = 3.62
        };
        student[0] = 100;
        student[1] = 90;
        student[2] = 96;
        student[3] = 98;
        student[4] = 99;
        student.StudentDetail();
        student.TestDetail();
    }
}