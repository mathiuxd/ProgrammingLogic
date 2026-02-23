
double temp = double.MinValue;
string? numberString;

for (int i = 1; i <= 3; i++)
{
    Console.Write("Enter a number: ");
    numberString = Console.ReadLine();


    if (double.TryParse(numberString, out double numberDouble))
    {
        if (numberDouble > temp) temp = numberDouble;
    }
    else
    {
        Console.WriteLine($"The entry: {numberString}, is incorrect.");
        i--;
    }

}

Console.WriteLine($"the largest number is {temp}");