Coords p1 = new Coords(0, 1, 10);

Console.WriteLine(p1.X);
Console.WriteLine(p1.Y);
Console.WriteLine(p1.ToString());

Coords p2 = p1 with {X = 5};
Console.WriteLine(p2.X);
Console.WriteLine(p2.Y);
Console.WriteLine(p2.ToString());

public struct Coords {
    public Coords (double x, double y, double z) {
        X = x;
        Y = y;
        Z = z;
    }
    public double X {get; set;}
    public double Y {get; set;}
    public double Z {get; set;}

    public override string ToString() => $"({X}, {Y}, {Z})";    
}