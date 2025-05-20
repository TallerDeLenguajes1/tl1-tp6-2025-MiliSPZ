// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("Valor de a:" + a);
Console.WriteLine("Valor de b:" + b);

/* ------------------------------ */
/* ---------Ejercicio1-------- */

/* Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del número sólo si éste es mayor a 0.

Nota: Si observa un subrayado amarillo sugiriendo modificar las variables al tipo
"nullable", abra el archivo de configuración de proyecto de extensión .csproj y elimine
la línea que dice <Nullable>enable</Nullable>. No olvide guardar el archivo. */
Console.WriteLine("Ingrese un numero mayor que 0");
int number = 0;
var num = Console.ReadLine();
bool esNumero = int.TryParse(num, out number);

if (esNumero)
{
    if (number < 10)
    {
        Console.WriteLine("El numero es:" + number);
    }
    else
    {
        int invertido = 0;
        int temp = number;
        while (temp > 0)
        {
            int digito = temp % 10;
            invertido = invertido * 10 + digito;
            temp /= 10;
        }
        Console.WriteLine("El número invertido es: " + invertido);
    }
}