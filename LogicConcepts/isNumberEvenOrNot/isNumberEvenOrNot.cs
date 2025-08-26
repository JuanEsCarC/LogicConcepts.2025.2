
using Shared;

var response = string.Empty;

do
{
    try
    {
        int number = ConsoleExtensions.getInt("Ingrese un número entero: ");
        if (number % 2 == 0)
        {
            Console.WriteLine($"El número {number}, es entero.");
        }
        else
        {
            Console.WriteLine($"El número {number}, es impar.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("Desea continuar [S]i o [N]o? ");
    response = Console.ReadLine();
    
} while (response!.ToLower() == "S");
Console.WriteLine("Game Over!");