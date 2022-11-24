namespace Regex_User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Using Regex");

            UserRegistration objUser = new UserRegistration();
            objUser.FirstName();
            objUser.LastName();
        }
    }
}