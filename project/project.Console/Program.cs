using project.Core;

var converter = new RomanConverter();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Roman / Natural Number Tester ===");
    Console.WriteLine("1) Convert natural number to Roman numeral");
    Console.WriteLine("2) Convert Roman numeral to natural number");
    Console.WriteLine("3) Exit");
    Console.Write("Selecciona una opción: ");

    var option = Console.ReadLine()?.Trim();

    if (option == "3")
    {
        break;
    }

    Console.WriteLine();

    try
    {
        if (option == "1")
        {
            ConvertNaturalToRoman(converter);
        }
        else if (option == "2")
        {
            ConvertRomanToNatural(converter);
        }
        else
        {
            Console.WriteLine("Opción inválida. Presiona cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey(true);
    }
}

static void ConvertNaturalToRoman(RomanConverter converter)
{
    Console.Write("Ingresa un número natural (1-3999): ");
    var input = Console.ReadLine()?.Trim();

    if (!int.TryParse(input, out var number))
    {
        Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
    }
    else
    {
        var roman = converter.ConvertToRoman(number);
        Console.WriteLine($"Número natural: {number}");
        Console.WriteLine($"Número romano: {roman}");
    }

    Console.WriteLine("Presiona cualquier tecla para continuar...");
    Console.ReadKey(true);
}

static void ConvertRomanToNatural(RomanConverter converter)
{
    Console.Write("Ingresa un número romano: ");
    var roman = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(roman))
    {
        Console.WriteLine("Entrada inválida. Debes ingresar un número romano.");
    }
    else
    {
        var number = converter.ConvertToInteger(roman);
        Console.WriteLine($"Número romano: {roman}");
        Console.WriteLine($"Número natural: {number}");
    }

    Console.WriteLine("Presiona cualquier tecla para continuar...");
    Console.ReadKey(true);
}
