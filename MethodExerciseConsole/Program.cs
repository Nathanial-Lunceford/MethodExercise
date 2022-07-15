// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static string GetInfo(string getting)
    {
        Console.WriteLine($"What is your {getting}?");

        return Console.ReadLine();
    }

    /*            Math methods                  */

    private static double Add(params double[] nums )
    {
        double sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    private static double Subtract(params double[] nums)
    {
        double sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sum -= nums[i];
        }
        return sum;
    }

    private static double Multiply(params double[] nums)
    {
        double sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sum *= nums[i];
        }
        return sum;
    }

    private static double Divide(params double[] nums)
    {
        double sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sum /= nums[i];
        }
        return sum;
    }

    private static double Modulus(double numerator, double denominator)
    {
        double remainder = numerator % denominator;
        
        return remainder;
    }

private static void Main(string[] args)
    {

        string Name = GetInfo("Name");

        string Color = GetInfo("favorite Color");

        string Animal = GetInfo("favorite Animal");

        string Band = GetInfo("favorite Band");

        Console.WriteLine($" {Name} was outside, wearing a tattered {Color} shirt for " +
            $"the band {Band}. He had recently acquired a {Animal}, and was showing " +
            $"it off to anyone who wanted to see it.");
        
        Console.WriteLine(Add(1.4, 5.1, 6.5, 2));

        Console.WriteLine(Subtract(20, 5, 3, 2, 5));

        Console.WriteLine(Multiply(5, 2, 4,  2));

        Console.WriteLine(Divide(20, 2, 5));

        Console.WriteLine(Modulus(5, 7));
    }
}