using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace lesson7Exercise2;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two double values:");

        //Enter two numbers
        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());

        //add the numbers
        Func<double, double, double> add = (x, y) => x + y;

        //multiply the numbers
        Func<double, double, double> multiply = (x, y) => x * y;

        //find the smaller value
        Action<double, double> findSmaller = (x, y) =>
        {
            double smaller = x < y ? x : y;
            Console.WriteLine($"The smaller value is: {smaller}");
        };

        //Output results
        Console.WriteLine($"The sum is: {add(number1, number2)}");
        Console.WriteLine($"Multiplying would equal: {multiply(number1, number2)}");
        findSmaller(number1, number2);
        Console.ReadLine();
    }
}