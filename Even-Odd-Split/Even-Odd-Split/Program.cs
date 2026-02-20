/*
 * Create two lists with an int datatype
 * Loop from 0-20
 * if number is even add to even list 
 * if number is odd add to odd list
 * print out even and odd lists */

List<int> even = new List<int>();
List<int> odd = new List<int>();

for (int i = 0; i <=200; i++)
{
    if (i!= 0 && i % 2 == 0)
    {
        even.Add(i);
    }
    else if (i !=0 && i % 2 == 1) {
        odd.Add(i);
    }
    else
    {

    }
}
Console.WriteLine("Even Numbers:");
foreach(int i in even)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine("Odd Numbers:");
foreach(int i in odd)
{
    Console.Write($"{i} ");
}