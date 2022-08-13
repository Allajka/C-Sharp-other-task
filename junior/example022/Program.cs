/* 22. Найти расстояние между точками в пространстве 2D/3D
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */


// в 2 D
// (double x, double y) a, b;
// a = (3, 6);
// b = (2, 1);
// double AC;
// double BC;
// double AB;

// if (a.x >= b.x) AC = a.x - b.x;
// else AC = b.x - a.x;

// if (a.y >= b.y) BC = a.y - b.y;
// else BC = b.y - a.y;

// AB = Math.Round(Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2)),3);
// Console.WriteLine(AB);

// в 3D

(double x, double y, double z) a, b;
a = (7, -5, 0);
b = (1, -1, 9);

double AC;
double BC;
double CC;
double AB;

if (a.x >= b.x) AC = a.x - b.x;
else AC = b.x - a.x;

if (a.y >= b.y) BC = a.y - b.y;
else BC = b.y - a.y;

if (a.y >= b.y) CC = a.z - b.z;
else CC = b.z - a.z;

AB = Math.Round(Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2)+ Math.Pow(CC, 2)),2);
Console.WriteLine(AB);