/*You have some text that contains your email address. And you want to hide that. You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain. Assume your email address will always be in format [username]@[domain]. You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. You will get as input the email address you need to obfuscate
Input
awesome@dotnet.com

Output
*******@dotnet.com*/

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Please insert your email here: ");
        string email = Console.ReadLine();

        string[] email2 = email.Split('@');
        int usernameLength = email2[0].Length;

        for (int i = 0; i < usernameLength; i++)
        {
            Console.Write("*");
        }

        Console.Write($"@{email2[1]}");
    }
}
