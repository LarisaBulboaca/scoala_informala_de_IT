// 1. Write a program that reads from the console three numbers of type int and prints their sum.
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter three numbers:");

        Console.Write("Number 1 = ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Number 2 = ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Number 3 = ");
        int number3 = int.Parse(Console.ReadLine());

        int sum = number1 + number2 + number3;
        Console.WriteLine("The sum of your three numbers is " + sum);
    }
}