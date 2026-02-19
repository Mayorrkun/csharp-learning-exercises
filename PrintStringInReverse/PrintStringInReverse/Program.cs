/*
 Ask user to input message 
 Print in order
 Print in reverse
 */
using System.Threading.Tasks;
bool running = true;
string message;
;
do
{
    Console.Write("Please enter a message: ");
    message = Console.ReadLine();

    if (!string.IsNullOrEmpty(message))
    {
        running = false; 
    }
    else
    {
        Console.WriteLine("\nPlease Try again\n");
    }
}

while (running);

string reverse ="";

for (int i = message.Length - 1; i >= 0; i--)
{
    
    Console.Write(message[i]);
    reverse += message[i];
    Thread.Sleep(200);

}

Console.WriteLine($"\nThis is your message:\t\t \"{message}\" ");
Console.WriteLine($"This is your message in reverse: \"{reverse}\"");

