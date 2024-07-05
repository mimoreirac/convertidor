// See https://aka.ms/new-console-template for more information
bool repetir = true;
do
{
    Console.WriteLine("~~~~~~~~~~~~ Convertidor de Unidades ~~~~~~~~~~~~~~~");
    Console.WriteLine("Bienvenido a su convertidor de unidades.");
    Console.WriteLine("A que unidad desea convertir?");
    Console.WriteLine("1. Kilometros.");
    Console.WriteLine("2. Hectometros.");
    Console.WriteLine("3. Decametros.");
    Console.WriteLine("4. Decimetros.");
    Console.WriteLine("5. Centimetros.");
    Console.WriteLine("6. Milimetros.");
    Console.WriteLine("7. Millas.");
    Console.WriteLine("8. Pulgadas.");
    Console.WriteLine("9. Salir.");

    string opcion = Console.ReadLine();
    double resultado,
        x;
    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x / 1000;
            Console.WriteLine($"{x} m son {resultado} km.");
            break;
        case "2":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x / 100;
            Console.WriteLine($"{x} m son {resultado} hm.");
            break;
        case "3":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x / 10;
            Console.WriteLine($"{x} m son {resultado} dm.");
            break;
        case "4":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x * 10;
            Console.WriteLine($"{x} m son {resultado} dcm.");
            break;
        case "5":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x * 100;
            Console.WriteLine($"{x} m son {resultado} cm.");
            break;
        case "6":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x * 1000;
            Console.WriteLine($"{x} m son {resultado} mm.");
            break;
        case "7":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x / 1609;
            Console.WriteLine($"{x} m son {resultado} millas.");
            break;
        case "8":
            Console.WriteLine("Ingrese un valor en metros.");
            x = double.Parse(Console.ReadLine());
            resultado = x * 39.37;
            Console.WriteLine($"{x} m son {resultado} mm.");
            break;
        case "9":
            Console.WriteLine("Hasta pronto...");
            repetir = false;
            break;
        default:
            break;
    }
} while (repetir);
