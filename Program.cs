namespace ConsoleApp6;
using System;

class Program
{
    static void Main(string[] args)
    {
        Department department = new Department("IT", 3);
        Employee emp1 = new Employee("Aysel", 2500);
        Employee emp2 = new Employee("Arzuman", 4000);
        Employee emp3 = new Employee("Nermin", 3000);
        Employee emp4 = new Employee("Aytac", 2000);

        department.AddEmployee(emp1);
        department.AddEmployee(emp2);
        department.AddEmployee(emp3);
        department.AddEmployee(emp4);

        department.GetAllEmployees();
    }
}

public class Employee
{
    public string Name;
    public double Salary;

    public Employee(string name, double salary)
    {
        this.Name = name;
        this.Salary = salary;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
    }
}

public class Department
{
    public string Name;
    public int EmployeeLimit;
    private Employee[] Employees;
    private int employeeCount = 0;


    public Department(string name, int employeeLimit)
    {
        this.Name = name;
        this.EmployeeLimit = employeeLimit;
        this.Employees = new Employee[employeeLimit];
    }

    public void AddEmployee(Employee employee)
    {
        if (employeeCount < EmployeeLimit)
        {
            Employees[employeeCount] = employee;
            employeeCount++;
            Console.WriteLine($"Isci {employee.Name} əlavə edildi.");
        }
        else
        {
            Console.WriteLine("İşçi əlavə etmək mümkün deyil, limit aşılıb.");
        }
    }

    public void GetAllEmployees()
    {
        if (employeeCount == 0)
        {
            Console.WriteLine("Department-da işçi yoxdur.");
        }
        else
        {
            Console.WriteLine("Department-da olan işçilər:");
            for (int i = 0; i < employeeCount; i++)
            {
                Employees[i].ShowInfo();
            }
        }
    }
}