public class HourlyTeacher : Teacher
{

    private double hourlySalary;
    private int hoursWorked = 0;

    public double getHourlySalary()
    {
        return hourlySalary;
    }
    public void setHourlySalary(double hourlySalary)
    {
        this.hourlySalary = hourlySalary;
    }

    public HourlyTeacher(string name, string adress, double hourlySalary):base(name, adress)
    {
        this.hourlySalary = hourlySalary;
    }
    public HourlyTeacher(string name, string adress, double hourlySalary, int hoursWorked):base(name, adress)
    {
        this.hourlySalary = hourlySalary;
        this.hoursWorked = hoursWorked;
    }

    public override double CalculateWeeklyPay()
    {
        return this.hourlySalary * this.hoursWorked;
    }

    
}