Console.Write("Nombre: ");
string? nombre = Console.ReadLine();
Console.Write("Apellido: ");
string? apellido = Console.ReadLine();
Console.Write("Teléfono: ");
string? telefono = Console.ReadLine();
Console.Write("Dirección: ");
string? direccion = Console.ReadLine();
Console.Write("Email: ");
string? email = Console.ReadLine();
Console.Write("¿Nuevo cliente?: ");
string? nuevoCliente = Console.ReadLine();

Cliente cliente = new Cliente(nombre!, apellido!, telefono!, direccion!, email!, nuevoCliente!);
Console.WriteLine(cliente.ToString());

public struct Cliente {
    public Cliente (string nombre, string apellido, string telefono, string direccion, string email, string nuevoCliente) {
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NuevoCliente = nuevoCliente;
    }
     public string Nombre {get; set;}
     public string Apellido {get; set;}
     public string Telefono {get; set;}
     public string Direccion {get; set;}
     public string Email {get; set;}
     public string NuevoCliente {get; set;}

    public override string ToString()
    {
        return $"Nombre completo: {Nombre} {Apellido}\nTeléfono: {Telefono}\nDirección: {Direccion}\nEmail: {Email}\nNuevo cliente: {NuevoCliente}";
    }
}