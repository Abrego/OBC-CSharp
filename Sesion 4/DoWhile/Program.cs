/*
Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
Tienes completa libertad para elegir el formato de la salida.
*/
int positivos = 0, negativos = 0, ceros = 0, numero;
string salir = "a";

do {
    Console.WriteLine("Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());
    if (numero > 0)
        positivos++;
    else if (numero < 0)
        negativos++;
    else
        ceros++;
    Console.Write("Presione X para salir, o cualquier otra tecla para continuar: ");
    salir = Console.ReadLine();
} while (salir.ToUpper() != "X");

Console.WriteLine($"Positivos: {positivos}");
Console.WriteLine($"Negativos: {negativos}");
Console.WriteLine($"Ceros: {ceros}");