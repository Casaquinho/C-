public class Student : Person
{
    private int nCourses = 0;
    private string[] courses;

    private int[] grades;

    public Student(string name, string address) : base(name, address)
    {
        courses = new string[30];
        grades = new int[30];
    }
    public void addCourse(string course, int grade)
    {
        courses[nCourses] = course;
        grades[nCourses] = grade;
        nCourses++;
    }

    public void printGrade()
    {
        for(int i = 0; i <= this.nCourses; i++)
        {
            Console.WriteLine(this.courses[i] + this.grades[i]);
        }
    }

    public double getAvarageGrade()
    {
        int total = 0;
        for(int i = 0; i <= this.nCourses; i++)
        {
            total += this.grades[i];
        }
        return total/this.nCourses;
    }

    public string toString()
    {
        return "student: " + GetName() + "adress: " + GetAddress();
    }
    


}