using System.Runtime.InteropServices;

Console.WriteLine("Type help or enter a command");

string? input = Console.ReadLine();

if (input != null)
{
    input = input.ToLower();
    if (input.StartsWith("help"))
    {
        Console.WriteLine("No");
    }

    if (input.StartsWith("yeet"))
    {
        Console.WriteLine("Ye");
        Console.WriteLine("et");
    }

    if (input.StartsWith("bctxt"))
    {

    }

}

else
{
    Console.WriteLine("Error: Null Input");
}