// See https://aka.ms/new-console-template for more information
using System;

string cadena1, cadena2;

// Ingreso y operaciones con cadenas
Console.WriteLine("Ingrese una cadena de texto:");
cadena1 = Console.ReadLine();
int longitud = cadena1.Length;
Console.WriteLine("La longitud de la cadena es: " + longitud);

// Acceso a los caracteres individuales usando Substring()
Console.WriteLine("Caracteres de la cadena:");
for (int i = 0; i < cadena1.Length; i++)
{
    Console.WriteLine(cadena1.Substring(i, 1));
}

Console.WriteLine("Ingrese otra cadena de texto:");
cadena2 = Console.ReadLine();

// Concatenación y comparación
Console.WriteLine("Cadenas concatenadas: " + cadena1 + " " + cadena2);
Console.WriteLine("¿Las cadenas son iguales? " + (cadena1 == cadena2));
Console.WriteLine("CompareTo: " + cadena1.CompareTo(cadena2));
Console.WriteLine("Compare: " + string.Compare(cadena1, cadena2));

// Buscar ocurrencia de una palabra
Console.WriteLine("Ingrese una palabra a buscar en la primera cadena:");
string palabra = Console.ReadLine();
int pos = cadena1.IndexOf(palabra);
if (pos != -1)
    Console.WriteLine($"La palabra '{palabra}' se encuentra en la posición {pos}.");
else
    Console.WriteLine($"La palabra '{palabra}' NO se encuentra en la cadena.");

// Uso de LastIndexOf, StartsWith y EndsWith
Console.WriteLine("Última aparición de la palabra: " + cadena1.LastIndexOf(palabra));
Console.WriteLine("¿La cadena empieza con la palabra? " + cadena1.StartsWith(palabra));
Console.WriteLine("¿La cadena termina con la palabra? " + cadena1.EndsWith(palabra));

// Convertir a mayúsculas y minúsculas
Console.WriteLine("Cadena en mayúsculas: " + cadena1.ToUpper());
Console.WriteLine("Cadena en minúsculas: " + cadena1.ToLower());

// Split con separador personalizado y Trim
Console.WriteLine("Ingrese una cadena separada por ';' (ejemplo: uno; dos; tres):");
string cadenaSeparada = Console.ReadLine();
string[] partes = cadenaSeparada.Split(';');
Console.WriteLine("Partes de la cadena (sin espacios):");
foreach (string parte in partes)
{
    Console.WriteLine(parte.Trim());
}

// Replace
Console.WriteLine("Ingrese un texto a reemplazar en la primera cadena:");
string aReemplazar = Console.ReadLine();
Console.WriteLine("Ingrese el nuevo texto:");
string nuevoTexto = Console.ReadLine();
Console.WriteLine("Cadena modificada: " + cadena1.Replace(aReemplazar, nuevoTexto));

// Calculadora
Console.WriteLine("Ingrese el primer número:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
int num2 = int.Parse(Console.ReadLine());

int suma = num1 + num2;
Console.WriteLine($"La suma de {num1} y de {num2} es igual a: {suma.ToString()}");

int resta = num1 - num2;
Console.WriteLine($"La resta de {num1} y de {num2} es igual a: {resta.ToString()}");

int multiplicacion = num1 * num2;
Console.WriteLine($"La multiplicación de {num1} y de {num2} es igual a: {multiplicacion.ToString()}");

if (num2 != 0)
{
    double division = (double)num1 / num2;
    Console.WriteLine($"La división de {num1} y de {num2} es igual a: {division.ToString()}");
}
else
{
    Console.WriteLine("No se puede dividir por cero.");
}

// Resolver ecuación simple ingresada como cadena
Console.WriteLine("Ingrese una ecuación simple (ejemplo: 5+3):");
string ecuacion = Console.ReadLine();
char[] operadores = { '+', '-', '*', '/' };
int idx = ecuacion.IndexOfAny(operadores);

if (idx > 0)
{
    int n1 = int.Parse(ecuacion.Substring(0, idx));
    int n2 = int.Parse(ecuacion.Substring(idx + 1));
    char op = ecuacion[idx];
    double resultado = 0;
    switch (op)
    {
        case '+': resultado = n1 + n2; break;
        case '-': resultado = n1 - n2; break;
        case '*': resultado = n1 * n2; break;
        case '/': resultado = n2 != 0 ? (double)n1 / n2 : double.NaN; break;
    }
    Console.WriteLine($"El resultado de la ecuación es: {resultado.ToString()}");
}
else
{
    Console.WriteLine("Ecuación no válida.");
}
