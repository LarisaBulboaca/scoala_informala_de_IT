//5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.


//Without conditional statements
Console.WriteLine("Insert two numbers here: ");
Console.Write("The first number is: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("The second number is: ");
int secondNumber = int.Parse(Console.ReadLine());

int greaterNumber = Math.Max(firstNumber, secondNumber);

Console.WriteLine("The greater number is " + greaterNumber);

//With conditional statements

Console.WriteLine("Pick two numbers: ");
Console.Write("number 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("number 2: ");
int number2 = int.Parse(Console.ReadLine());

int greaterNumber2;

if (number1 > number2)
{
    greaterNumber2 = number1;
}
else
{
    greaterNumber2 = number2;
}

Console.WriteLine($"The greater number is {greaterNumber2}");