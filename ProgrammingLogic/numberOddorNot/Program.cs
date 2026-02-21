
Console.Write("Enter a number: ");
string numberString = Console.ReadLine()!;

int number = int.Parse(numberString);

string message = (number % 2 == 0) ? "This number is even" : "This number isn't even";

Console.WriteLine(message);