/*
Ejercicio 1 - If

Escribe un programa que:
Pida datos a un cliente: Nombre, email, cupón
Determine si un cliente tiene un cupon descuento
Muestre un precio rebajado en función del descuento
Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable.
*/
string? nombre, email, cupon;
decimal precio;

Console.Write("Nombre: ");
nombre = Console.ReadLine();
Console.Write("Email: ");
email = Console.ReadLine();
Console.Write("Cupón (S/N): ");
cupon = Console.ReadLine()!;
Console.Write("Precio: ");
precio = decimal.Parse(Console.ReadLine()!);

if (cupon.ToUpper() == "S")
    precio = precio * 0.9m;

Console.WriteLine($"El precio del producto es: {precio}");