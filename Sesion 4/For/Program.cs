/*
Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:
ancho
alto
relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas 
y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos 
que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true
Output:
** **
** **

Input: 3, 4, 1, relleno = false
Output:
***
* *
* *
***
*/
int ancho, alto, cantidad;
string? relleno, caracter;

Console.Write("Ancho: ");
ancho = int.Parse(Console.ReadLine()!);
Console.Write("Alto: ");
alto = int.Parse(Console.ReadLine()!);
Console.Write("Cantidad: ");
cantidad = int.Parse(Console.ReadLine()!);
Console.Write("Relleno (S/N): ");
relleno = Console.ReadLine()!;

caracter = relleno.ToUpper()! == "S" ? "*" : " ";

for (int cant = 0; cant < cantidad; cant++) {
    for (int col = 0; col < ancho; col++)
        Console.Write("*");
    Console.Write(" ");
}
Console.WriteLine("");

for (int filas = 0; filas < alto - 2; filas++) {
    for (int cant = 0; cant < cantidad; cant++) {
        Console.Write("*");
        for (int col = 0; col < ancho - 2; col++)
            Console.Write(caracter);
        Console.Write("* ");
    }
    Console.WriteLine("");
}

for (int cant = 0; cant < cantidad; cant++) {
    for (int col = 0; col < ancho; col++)
        Console.Write("*");
    Console.Write(" ");
}