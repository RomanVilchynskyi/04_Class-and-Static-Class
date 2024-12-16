using _04_Class_and_Static_Class;
using _04_Static_class_fields_methods;

internal class Program
{

    static class AreaShapes
    {
        const double PI = 3.14;
        public static double TianArea(double h, double s)
        {
            return 0.5 * h * s;
        }
        public static double CircleArea(double r)
        {
            return PI * Math.Pow(r, 2);

        }
    }

    private static void Main(string[] args)
    {
        /*Console.WriteLine("Main started ....");
        Console.WriteLine($"Last id :: {Employee.LastId}");

        Employee emp = new Employee() {Name = "Denis", Birth = DateTime.Parse("30/10/2000"), Position = Position.Manager };
        Console.WriteLine($"Age :: {emp.Age}");

        Employee emp2 = new Employee()
        {
            Name = "Ivan",
            Birth = new DateTime(2005, 12, 9),
            Position = Position.QA
        };

        Console.WriteLine(emp2);
        Console.WriteLine($"Age :: {emp2.Age}");
        Console.WriteLine($"Same position  :: {Employee.SamePosition(emp2, emp)}");
        Console.WriteLine($"Last id :: {Employee.LastId}");

        Console.WriteLine(AreaShapes.TianArea(10, 15));*/

        Console.Write("Enter the number of districts: ");
        int numberOfDistricts = int.Parse(Console.ReadLine());

        City city = new City(numberOfDistricts);

        city.printCity();


    }
}