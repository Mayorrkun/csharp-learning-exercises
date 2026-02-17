using System;

Console.WriteLine("Even Odd Checker");
Console.WriteLine(" ");
Console.Write("Enter a Number:");
//converted the input to int 32 
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

//conditional for modulo 
if (num % 2 != 0)
{
    Console.WriteLine("This number: " + num + ", is odd");
}

else
{
    Console.WriteLine("This number: " + num + ", is even");
}
// end of program
Console.WriteLine("Thank you!");