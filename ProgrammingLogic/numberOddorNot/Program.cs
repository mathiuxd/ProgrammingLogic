string numberString = string.Empty;

do
{

    Console.Write("Enter an integer or press 'E' to exit: ");
    numberString = Console.ReadLine()!;

    if (numberString!.ToLower() == "e" ) continue;
    

    if (int.TryParse(numberString, out int numberValidation))
    {
        string message = (numberValidation % 2 == 0) ? $"The number {numberValidation} is even" : $"The number {numberValidation} is not even";
        Console.WriteLine(message);
    }
    else
    {
        Console.WriteLine($"The input: {numberString}, is not an integer");
    }

} while (numberString!.ToLower() != "e");

Console.WriteLine("Closing the program...");