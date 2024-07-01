// See https://aka.ms/new-console-template for more information
Console.WriteLine("~~~~~~~~~~~~ Convertidor de Unidades ~~~~~~~~~~~~~~~");
Console.WriteLine("Bienvenido a su convertidor de unidades.");
Console.WriteLine("Ingrese un valor en metros.");

int x = int.Parse(Console.ReadLine());

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
bool repetir = true;
int resultado = 0;

do
{
    switch (opcion)
    {
        case "1":
            resultado = x / 1000;
            Console.WriteLine($"{x} m son {resultado} km.");
            break;
        case "2":
            resultado = x / 100;
            Console.WriteLine($"{x} m son {resultado} hm.");
            break;
        case "3":
            resultado = x / 10;
            Console.WriteLine($"{x} m son {resultado} dm.");
            break;
        case "4":
            resultado = x * 10;
            Console.WriteLine($"{x} m son {resultado} dcm.");
            break;
        case "5":
            resultado = x * 100;
            Console.WriteLine($"{x} m son {resultado} cm.");
            break;
        case "6":
            resultado = x * 1000;
            Console.WriteLine($"{x} m son {resultado} mm.");
            break;
        default:
            break;
    }
} while (repetir);
