// 20. Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти ");
int user = Convert.ToInt32(Console.ReadLine());
string first = "X от 0 до n, Y от 0 до n";
string second = "X от 0 до -n, Y от 0 до n";
string third = "X от 0 до -n, Y от 0 до -n";
string fourth = "X от 0 до n, Y от 0 до -n";

if (user == 1) Console.Write(first);
if (user == 2) Console.Write(second);
if (user == 3) Console.Write(third);
if (user == 4) Console.Write(fourth);