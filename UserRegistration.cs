using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
    public void FirstName()
    {
        Console.Write("\nEnter First Name: ");
        string firstName = Console.ReadLine();
        var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
        bool matchRes = regex.IsMatch(firstName);
        if (matchRes == true)
        {
            Console.WriteLine($"{firstName} is valid");
        }
        else
        {
            Console.WriteLine($"{firstName} is invalid");
            FirstName();
        }
    }

    public void LastName()
    {
        Console.Write("\nEnter Last Name: ");
        string lastName = Console.ReadLine();
        var regex = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
        bool matchRes = regex.IsMatch(lastName);
        if (matchRes == true)
        {
            Console.WriteLine($"{lastName} is valid");
        }
        else
        {
            Console.WriteLine($"{lastName} is invalid");
            LastName();
        }
    }
}
