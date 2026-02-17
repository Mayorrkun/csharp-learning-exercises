/*
 Ask the user for a number for the table
 Write a for loop to print X times table
 */

bool running = true;
int num;

do { 
Console.Write("Enter a number of your choice: ");

bool success = int.TryParse(Console.ReadLine(), out num);



    if (success)
    {
       running = false;
    }
    else
    {
        Console.WriteLine("Enter a real number");
        Console.WriteLine("");
    }

}



while (running) ;

Console.WriteLine("Presenting the " + num + " Times Table");
for (int i = 1 ; i <= 12; i++) {
    Console.WriteLine( num + " x " + i + " = " + num*i );
} ;