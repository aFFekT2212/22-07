int x1, x2, y1, y2, z1, z2;
Console.Write("x1 = ");
x1 = Int32.Parse(Console.ReadLine());
Console.Write("y1 = ");
y1 = Int32.Parse(Console.ReadLine());
Console.Write("z1 = ");
z1 = Int32.Parse(Console.ReadLine());
Console.Write("x2 = ");
x2 = Int32.Parse(Console.ReadLine());
Console.Write("y2 = ");
y2 = Int32.Parse(Console.ReadLine());
Console.Write("z2 = ");
z2 = Int32.Parse(Console.ReadLine());

double p = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
Console.WriteLine(p);


