//14. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.

public static class Program
{
    private static bool input;

    static void Main()
    {
        string companyName, companyAddress, companyPhone, companyFax, companyWebsite, companyManager;
        string managerName, managerSurname, managerPhone;

        Console.WriteLine("Please insert the company information here:");
        companyName = GetInput("Company name: ");
        companyAddress = GetInput("Company address: ");
        companyPhone = GetInput("Company phone:");
        companyFax = GetInput("Company fax: ");
        companyWebsite = GetInput("Company website: ");
        companyManager = GetInput("Company manager: ");

        Console.WriteLine("Please insert manager information here: ");
        managerName = GetInput("Manager name: ");
        managerSurname = GetInput("Manager surname: ");
        managerPhone = GetInput("Manager phone: ");

        Console.WriteLine("Information about the company: ");
        PrintCompanyInformation(companyName, companyAddress, companyPhone, companyFax, companyWebsite, companyManager);
        Console.WriteLine("Information about the manager: ");
        PrintManagerInformation(managerName, managerSurname, managerPhone);

    }

    
    static string GetInput(string input)
    {
        Console.WriteLine(input);
        return Console.ReadLine();
    }

    
    static void PrintCompanyInformation(string name, string address, string phone, string fax, string website, string manager)
    {
        Console.WriteLine("Company name: " + name);
        Console.WriteLine("Company address: " + address);
        Console.WriteLine("Company phone: " + phone);
        Console.WriteLine("Company fax: " + fax);
        Console.WriteLine("Company website: " + website);
        Console.WriteLine("Company manager: " + manager);
    }

    
    static void PrintManagerInformation(string name, string surname, string phone)
    {
        Console.WriteLine("Manager name: " + name);
        Console.WriteLine("Manager surname: " + surname);
        Console.WriteLine("Manager phone: " + phone);
    }
}

