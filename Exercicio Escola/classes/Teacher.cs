using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

public abstract class Teacher:Person
{
    private int nCourses = 0;
    private string[] courses;

    public Teacher(string name, string adress):base(name, adress)
    {
        this.courses = new string[30];
    }

    public Boolean addCourse(string course)
    {
        for(int i = 0; i <= this.nCourses; i++)
        {
            if(course.Equals(this.courses[i]))
            {
                return false;
            }
        }
        this.courses[nCourses] = course;
        return true;
    }

    public Boolean removeCourse(string course)
    {
        if(course == null)
        {
            return false;
        }
        int indice = 0;
        bool achou = false;
        for (int i = 0; i <= this.nCourses - 1; i++)
        {
            if(this.courses[i].Equals(course))
            {
                indice = i;
                achou = true;
            }
        }
        if(achou)
        {
            for(int z = indice; z < this.nCourses - 1; z++)
            {
                this.courses[z] = this.courses[z+1];
            }
            return true;
        }
        return false;
    }

    public abstract double CalculateWeeklyPay();
    
}