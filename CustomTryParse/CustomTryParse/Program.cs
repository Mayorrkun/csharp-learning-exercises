/*
 * Create an int and try to convert any string to an int
 * Notice the error, write a try ... catch handler around it
 * Catch the error and output the message
 * Create a custom try parse function
 * find the real function and copy return type/params
 * */


//try
//{
//    Console.WriteLine("Enter a number : ");
//    int num = Convert.ToInt32(Console.ReadLine());
//}
//catch (FormatException e)
//{
//    Console.WriteLine($"{e.Message}");
//}
//catch (OverflowException e)
//{
//    Console.WriteLine($"{e.Message}");
//}

Console.Write("Enter a number :");
if(TryParse(Console.ReadLine(), out int result,out string e))
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine(e);
}

static bool TryParse(string input, out int result, out string e)
{
    result = -1;
    e = "";
    try
    {
        result = Convert.ToInt32(input);
        return true; 
    }

    catch (Exception ex)
    {
        e = ex.Message;
        return false;
    }

    
}