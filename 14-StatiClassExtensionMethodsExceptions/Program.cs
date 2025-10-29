using _14_StatiClassExtensionMethodsExceptions.Exception;
using _14_StatiClassExtensionMethodsExceptions.Models;

LoginSystem loginSystem = new LoginSystem();

while (true)
{
    Console.Write("Enter username: ");
    string username = Console.ReadLine();

    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    try
    {
        bool success = loginSystem.Login(username, password);
        if (success) break;
    }
    catch (InvalidUsernameException ex)
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
    catch (InvalidPasswordException ex)
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
    catch (UserNotFoundException ex)
    {
        Console.WriteLine("ERROR: " + ex.Message);
        loginSystem.ShowUsers();
    }
    catch (IncorrectPasswordException ex)
    {
        Console.WriteLine("WARNING: " + ex.Message);
    }
    catch (AccountLockedException ex)
    {
        Console.WriteLine("CRITICAL: " + ex.Message + " Please contact admin.");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
    }

    Console.WriteLine();
}
