/*
 *Create and initialize int array of numbers
 *Create function SumOfNumbers with int return type
 *int array param
 *Function should return the total of all numbers
 *call and output the total
 **/

int[] numbers = new int[]
{
    1,2,3,4,5,6,7,8,9,10
};

Console.WriteLine(SumOfNumbers(ref numbers, out int sum) ? $"The sum of numbers in the array is: {sum}" : "Array is Empty\n");
results(ref numbers);


static bool SumOfNumbers(ref int[] numbers, out int sum)
{
    sum = 0;
    if (numbers.Length != 0)
    {
        
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return true;
    }

    return false;
   
}

static void results(ref int[] numbers)
{
    Console.WriteLine(SumOfNumbers(ref numbers, out int sum) ? $"The sum of numbers in the array is: {sum}" : "Array is Empty");

}