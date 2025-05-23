// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

/* ------------------------------ */
/* ---------Ejercicio2-------- */

/* */

int opcion = 0, numero1 = 0, numero2 = 0, resultado = 0, continuar = 0;
bool esNumero = false;
string? inputOpcion, inputContinuar;

do
{
    Console.WriteLine("Ingrese un numero del 1 al 5 \n (Suma: 1, Resta: 2, Multiplicacion: 3, Division: 4, Salir: 5)");
    inputOpcion = Console.ReadLine();
    esNumero = int.TryParse(inputOpcion, out opcion);

    Console.WriteLine("Ingrese el primer numero");
    esNumero = int.TryParse(Console.ReadLine(), out numero1);
    Console.WriteLine("Ingrese el segundo numero");
    esNumero = int.TryParse(Console.ReadLine(), out numero2);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ha elegido la opcion de la SUMA");
            resultado = numero1 + numero2;
            Console.WriteLine("\nEl resultao de la suma es:" + resultado);
            break;
        case 2:
            Console.WriteLine("Ha elegido la opcion de la RESTA");
            resultado = numero1 - numero2;
            Console.WriteLine("\nEl resultao de la resta es:" + resultado);
            break;
        case 3:
            Console.WriteLine("Ha elegido la opcion de la MULTIPLICACION");
            resultado = numero1 * numero2;
            Console.WriteLine("\nEl resultao de la multiplicacion es:" + resultado);
            break;
        case 4:
            Console.WriteLine("Ha elegido la opcion de la DIVISION");
            resultado = numero1 / numero2;
            Console.WriteLine("\nEl resultao de la division es:" + resultado);
            break;
        default:
            Console.WriteLine("Ha elegido la opcion de SALIR");
            break;
    }
    Console.WriteLine("Desea continuar? \n 1. Si \n 2. No");
    inputContinuar = Console.ReadLine();
    esNumero = int.TryParse(inputContinuar, out continuar);
    if (continuar == 2)
    {
        opcion = 5;
        Console.WriteLine("Ha elegido la opcion de SALIR");
    }
    else
    {
        opcion = 0;
    }
} while (opcion != 5);