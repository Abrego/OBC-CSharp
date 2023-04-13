/*
Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
*/

Console.Write("Número: ");
int tabla = int.Parse(Console.ReadLine()!);

int num = 1;

while (num <= 10)
{
    Console.WriteLine($"{tabla} x {num} = {tabla * num}");
    num++;
}