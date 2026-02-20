int age = 50;

if (age > 18)
{
    Console.WriteLine("Over 18");
}
else if (age > 30)
{
    Console.WriteLine("Over 30");
}
else if (age > 50)
{
    Console.WriteLine("Over 50");
}

// Now this willl throw a logic error your code will run of course 
//but it will always return 18 as it is the first condition satisfied as true
//To fix this wed have to set a range for each condition 
//pretty basic 

ageChecker(age);

// Now this will return the correct output 

static void ageChecker(int age)
{

    if (age >= 18 && age < 30)
    {
        Console.WriteLine("Over 18");
    }
    else if (age >= 30 && age < 50)
    {
        Console.WriteLine("Over 30");
    }
    else if (age >= 50)
    {
        Console.WriteLine("Over 50");
    }

}
