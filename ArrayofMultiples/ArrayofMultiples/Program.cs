/*Define and initialize two integer num and length 
 * create an int array with size length
 * loop through and insert the (loop counter x num) into array
 * output the final array
 * 
 */

int num = 7, length = 12;

int[] multiples = new int[length];

for (int i = 0; i < length; i++)
{
    multiples[i] = num * (i+1);
}


Console.WriteLine($"the number is {num} and the length is {length} \n ");

Console.Write($"The current array: [ ");
foreach (int i in multiples)
{
    Console.Write($" {i}, ");
}
Console.Write($"]");