/* 
 * Create two lists with interger data type, one for even number one for oodd
 * loop from 0-20
 * if number is even add to even list 
 * if number is odd add to odd list 
 * print even list 
 * print odd list 
 */


List<int> even = new List<int>();
List<int> odd  = new List<int>();

for (int i =0; i <= 20; i++)
{
    if (i % 2 == 0) {
    even.Add(i);
    }
    else
    {
        odd.Add(i);
    }
}
Console.WriteLine($"Even Numbers :");
foreach (int num in even) {
Console.Write($"{num}   ");
}

Console.WriteLine("");

Console.WriteLine($"Odd numbers :");
foreach (int num in odd)
{
    Console.Write($"{num}   ");
}