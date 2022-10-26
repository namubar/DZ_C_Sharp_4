Console.WriteLine ("Введите координаты точки А (X,Y,Z)");
int xa = int.Parse (Console.ReadLine()!);
int ya = int.Parse (Console.ReadLine()!);
int za = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите координаты точки B (X,Y,Z)");
int xb = int.Parse (Console.ReadLine()!);
int yb = int.Parse (Console.ReadLine()!);
int zb = int.Parse (Console.ReadLine()!);

double length (int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = 0;
    result = Math.Sqrt (Math.Pow((xa-xb), 2)+ Math.Pow ((ya-yb), 2) +Math.Pow((za-zb), 2));
    return result;
}
length (xa, ya, za, xb, yb, zb );
//Console.WriteLine ("Расстояние равно " + length (xa, ya, za, xb, yb, zb ));
Console.WriteLine (Math.Round (length (xa, ya, za, xb, yb, zb ), 2));