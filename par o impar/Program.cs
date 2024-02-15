// See https://aka.ms/new-console-template for more information
Console.WriteLine(" par o impar");

Console.WriteLine("Ingrese un número para determinar si es par o impar:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("El número es par.");
}
else
{
    Console.WriteLine("El número es impar.");
}
