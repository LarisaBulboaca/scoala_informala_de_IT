//3. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
Console.Write("Insert a radius value here: ");
int r = int.Parse(Console.ReadLine());
double perimeter = 2 * Math.PI * r;
double area = Math.PI * r * r;
Console.WriteLine($"The Perimeter of the circle with a radius of 20 is {perimeter} and the area of the circle is {area}");
