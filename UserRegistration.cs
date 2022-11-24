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

    public void Email()
    {
        Console.Write("\nEnter Email Id in a right Format : ");
        Console.WriteLine("Example: abc.xyz@bl.co.in : ");
        string email = Console.ReadLine();
        var regex = new Regex(@"^([a][b][c])([_\.\+\-])([a-zA-Z0-9]+)\@([b][l])\.([c][o])\.([a-z]{2})*$");
        bool matchRes = regex.IsMatch(email);
        if (matchRes == true)
        {
            Console.WriteLine($"{email} is valid");
        }
        else
        {
            Console.WriteLine($"{email} is invalid");
            Email();
        }
    }

    public void MobileNumber()
    {
        Console.Write("\nEnter Mobile Number : ");
        Console.WriteLine("Example: +(country code) (10 digit number)");
        string mobileNumber = Console.ReadLine();
        var regex = new Regex(@"^\+[1-9]{1}[0-9]{0,2}\s[1-9]{1}[0-9]{9}");
        bool matchRes = regex.IsMatch(mobileNumber);
        if (matchRes == true)
        {
            Console.WriteLine($"{mobileNumber} is valid");
        }
        else
        {
            Console.WriteLine($"{mobileNumber} is invalid.");
            MobileNumber();
        }
    }

    public void Password()
    {
        Console.Write("\nEnter a Password with atleast one Uppercase Character and one numeric number: ");
        string password = Console.ReadLine();
        var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
        bool matchRes = regex.IsMatch(password);
        if (matchRes == true)
        {
            Console.WriteLine($"{password} is valid");
        }
        else
        {
            Console.WriteLine($"{password} is invalid ");
            Password();
        }
    }
}
