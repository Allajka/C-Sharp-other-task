// 20. Задать номер четверти, показать диапазоны для возможных координат

int CheckInput ()
{
    int a = 20;
    while (true)
    {
        Console.Write("Введите номер четверти от 1 до 4: ");
        string N = Console.ReadLine()!;
        bool flag = int.TryParse(N, out a); 
        if (flag && a >= 1 && a <= 4) break;
    }
    return a;
}

int user = CheckInput();
string first = "Диапазоны для возможных координат ПЕРВОЙ четверти: \nX от 0 до n \nY от 0 до n";
string second = "Диапазоны для возможных координат ВТОРОЙ четверти: \nX от 0 до -n \nY от 0 до n";
string third = "Диапазоны для возможных координат ТРЕТЬЕЙ четверти: \nX от 0 до -n \nY от 0 до -n";
string fourth = "Диапазоны для возможных координат ЧЕТВЕРТОЙ четверти: \nX от 0 до n \nY от 0 до -n";

if (user == 1) Console.Write(first);
if (user == 2) Console.Write(second);
if (user == 3) Console.Write(third);
if (user == 4) Console.Write(fourth);