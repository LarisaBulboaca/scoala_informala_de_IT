//2. Write a program that reads five numbers from the console and prints the greatest of them.

public static class Program
{
    public static void Main()
    {
        Console.Write("Enter five numbers here: ");

        Console.Write("Number 1 = ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Number 1 = ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Number 1 = ");
        int number3 = int.Parse(Console.ReadLine());

        Console.Write("Number 1 = ");
        int number4 = int.Parse(Console.ReadLine());

        Console.Write("Number 1 = ");
        int number5 = int.Parse(Console.ReadLine());

        int greatestNumber = number1;

        if (number2 > greatestNumber)
        {
            greatestNumber = number2;
        }

        if (number3 > greatestNumber)
        {
            greatestNumber = number3;
        }

        if (number4 > greatestNumber)
        {
            greatestNumber = number4;
        }

        if (number5 > greatestNumber)
        {
            greatestNumber = number5;
        }

        Console.WriteLine("The greatest number is " + greatestNumber);
    }
}