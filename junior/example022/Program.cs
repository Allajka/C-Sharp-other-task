/* 22. Найти расстояние между точками в пространстве 2D/3D
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */
(double x, double y) a, b;
a = (7, -5);
b = (1, -1);
double AC;
double BC;
double AB;
// Console.WriteLine(a.x);
// Console.WriteLine(a.y);
// Console.WriteLine(b.x);
// Console.WriteLine(b.y);

if (a.x >= b.x) AC = a.x - b.x;
else AC = b.x - a.x;

if (a.y >= b.y) BC = a.y - b.y;
else BC = b.y - a.y;

AB = Math.Round(Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2)),3);
Console.WriteLine(AB);