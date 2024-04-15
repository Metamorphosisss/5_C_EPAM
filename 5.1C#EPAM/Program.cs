internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("length please:");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[length];

        Console.WriteLine("your numbers please:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(MaxNumberInArray(array));
    }
    static int MaxNumberInArray(int[] array)
    {
        int maxnumber = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxnumber)
            {
                maxnumber = array[i];
            }
        }

        return maxnumber;
    }
}