/*
 Fizz Buzz Game 
 if divisible by 5 = Fizz 
 if divisible by 4 = Buzz
 if divisible by 5 and 4 = FizzBuzz
 if neither output number

we will iterate for 50 times 

 */

int i = 1;

bool fizz = false, buzz = false;


do
{
    fizz = i % 5 == 0;
    buzz = i % 4 == 0;

    if (fizz && buzz)
    {
        Console.WriteLine("FizzBuzz");
    }

    else if (fizz)
    {
        Console.WriteLine("Fizz");
    }

    else if (buzz)
    {
        Console.WriteLine("Buzz");
    }

    else
    {
        Console.WriteLine(i);
    }

    i++;
}

while (i <= 40);
