/*
Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. 
Presenta la lista en consola y pide que el usuario seleccione el lenguaje 
mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.
Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
*/

string ? opcion;

Console.WriteLine("[1] C\n[2] C++\n[3] C#\n[4] Java \n[5] Javascript\nSeleccione el número de una opción:");
opcion = Console.ReadLine();

switch(opcion) {
    case "1":
        Console.WriteLine("Se seleccionó C.");
        break;
    case "2":
        Console.WriteLine("Se seleccionó C++.");
        break;
    case "3":
        Console.WriteLine("Se seleccionó C#.");
        break;
    case "4":
        Console.WriteLine("Se seleccionó Java.");
        break;
    case "5":
        Console.WriteLine("Se seleccionó Javascript.");
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}