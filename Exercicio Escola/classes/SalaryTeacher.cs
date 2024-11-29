using System.Dynamic;

public class SalaryTeacher:Teacher
{
    private double weeklySalary;

    public SalaryTeacher(string name, string adress, double weekSalary):base(name, adress)
    {
        this.weeklySalary = weeklySalary;
    }
    public double GetWeekSalary()
    {
        return this.weeklySalary;
    }
    public void setSalaryTeacher(double weeklySalary)
    {
        this.weeklySalary = weeklySalary;
    }
    public override double CalculateWeeklyPay()
    {
        double salary = GetWeekSalary();
        return salary;
    }
    public string toString()
    {
        return "name: " + this.name + "address: " + this.address + "week salary:" + this.weeklySalary;
    }
}
