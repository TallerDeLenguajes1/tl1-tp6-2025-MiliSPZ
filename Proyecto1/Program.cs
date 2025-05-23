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

int numero1 = 0, numero2 = 0, numero3 = 0, resultado = 0;
bool esNumero = true;
string? inputNumero1, inputNumero2, inputNumero3;

do
{
    Console.WriteLine("Ingrese un numero:");
    inputNumero1 = Console.ReadLine();
    esNumero = int.TryParse(inputNumero1, out numero1);
    if (!esNumero)
    {
        Console.WriteLine("Error: No es un número válido.");
        continue;
    }

    double num = numero1;

    Console.WriteLine($"Valor absoluto: {Math.Abs(num)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(num, 2)}");
    if (num >= 0)
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(num)}");
    else
        Console.WriteLine("Raíz cuadrada: No definida para números negativos");

    Console.WriteLine($"Seno: {Math.Sin(num)}");
    Console.WriteLine($"Coseno: {Math.Cos(num)}");

    float numFloat = (float)num;
    Console.WriteLine($"Parte entera (float): {Math.Truncate(numFloat)}");

    Console.WriteLine("Ingrese otros dos numeros:");
    Console.WriteLine("Ingrese el primer numero:");
    inputNumero2 = Console.ReadLine();
    esNumero = int.TryParse(inputNumero2, out numero2);
    if (!esNumero)
    {
        Console.WriteLine("Error: No es un número válido.");
        continue;
    }
    Console.WriteLine("Ingrese el segundo numero:");
    inputNumero3 = Console.ReadLine();
    esNumero = int.TryParse(inputNumero3, out numero3);
    if (!esNumero)
    {
        Console.WriteLine("Error: No es un número válido.");
        continue;
    }


    Console.WriteLine($"El máximo entre los dos numeros es: {Math.Max(numero2, numero3)}");
    Console.WriteLine($"El mínimo entre los dos numeros es: {Math.Min(numero2, numero3)}");


} while (esNumero);