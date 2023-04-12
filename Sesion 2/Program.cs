/*
Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. 
Ej: nombre, apellido, edad, sabe programar, etc.
*/
string? nombre, apellido, hobby;
int edad;
Console.Write("Nombre: ");
nombre = Console.ReadLine();
Console.Write("Apellido: ");
apellido = Console.ReadLine();
Console.Write("Edad: ");
edad = int.Parse(Console.ReadLine());
Console.Write("Hobby: ");
hobby = Console.ReadLine();
Console.WriteLine($"{nombre} {apellido} tiene {edad} años y su pasatiempo es {hobby}");

/*
Ejercicio 2
Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/
// Coche: puertas, ruedas, marca, ITV vigente
string coche = "R8";
int puertas = 4;
int ruedas = 4;
string marca = "Audi";

// Mesa: peso, largo, material, color
string material = "Madera";
double peso = 22.5;
double largo = 1.20;
string color = "blanco";

/*
Ejercicio 3
Operadores Determina los operadores para verificar las siguientes condiciones:
Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/
// Un número es mayor o igual a 18
Console.WriteLine($"18 >= 10:  {18 >= 10}");

// Un char es ‘a’
char a = 'a';
Console.WriteLine($"Un char es 'a': {a.Equals('a')}");

// Se cumplen dos conciones a la vez (ambas verdaderas)
Console.WriteLine($"4 != 3*2 y 5 <= 2+3: {4 != 3*2 && 5 <= 2+3}");

// Se cumple una de dos condiciones a la vez (una true y otra false)
Console.WriteLine($"2*3 == 6 o 10 < 0: {2*3 == 6 || 10 < 0}");