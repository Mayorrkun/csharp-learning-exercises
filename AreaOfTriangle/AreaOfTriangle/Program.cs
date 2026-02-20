/*
 *Ask user for a width and height
 *Create a function to calculate the area
 *Funstion should calculate the area using width * height / 2
 *Print out the area of the triangle*/


Console.Write("Please enter the width of your triangle: ");
double.TryParse(Console.ReadLine(), out double width);
Console.WriteLine();
Console.Write("Please enter the height of your triangle: ");
double.TryParse(Console.ReadLine(), out double height);

//saving memory for no reason lol 
double area = TriArea(ref width, ref height);
Console.WriteLine($"\n\nThe area of your triangle with the width {width}cm and height {height}cm is {area}cm^2 ");
static Double TriArea(ref double width, ref double height)
{
    return (width * height) / 2;
}
;