internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter two numbers: ");
        int first_number = Convert.ToInt32(Console.ReadLine());
        int seconnd_number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("average number -> " + CalculateAverageNumber(first_number, seconnd_number));
    }
    static double CalculateAverageNumber(double x, double y)
    {
        return (x + y) / 2;
    }
}