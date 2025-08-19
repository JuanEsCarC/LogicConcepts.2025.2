
var numberString = string.Empty;

do
{
    Console.Write("Ingrese un número entero o la palabra 'salir' para terminar el programa: ");
    numberString = Console.ReadLine();

    if (numberString!.ToLower() == "salir")
    {
        continue;
    }

    int number = 0;
    if (int.TryParse(numberString, out number))
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"El número {number}, es entero.");
        }
        else
        {
            Console.WriteLine($"El número {number}, es impar.");
        }
    }else
    {
        Console.WriteLine($"El valor ingresado: '{numberString}', no es un número entero.");
    }

    Console.WriteLine(string.Empty);

} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over!");