/*
 *Ask user to enter password and store
 *Ask user to enter password again and store
 *Check if they both contain something 
 *if so check if they are the same 
 *if they are print passwords match 
 *if they are not print passwords do not match 
 *if they are empty print please enter a password 
 */


bool running = true;
string password, confirmed;

do
{
    Console.Write("Please Enter a password: ");
    password = Console.ReadLine();

    Console.Write("Confirm your password: ");
    confirmed = Console.ReadLine();

    if(!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmed))
    {
        if (password.Equals(confirmed))
        {
            Console.WriteLine("\nPasswords Match\n");
            running = false;
        }
        else
        {
            Console.WriteLine("\nPasswords do not Match\n");
        }

      
    }

    else
    {
        Console.WriteLine("\nPlease enter a password in both\n");
    }
}

while (running);




