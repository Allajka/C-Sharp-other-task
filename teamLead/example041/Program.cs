/* 41. Выяснить являются ли три числа сторонами треугольника. 
Длина любой стороны треугольника всегда меньше суммы длин двух его других сторон. 
Три числа a,b,c, то они являются сторонами треугольника если:
a+b>c и b+c>a и a+c>b*/

int checkTypeNumber(string textWrite)
{
    int number;
    while (true)
    {
        Console.Write(textWrite);
        string userType = Console.ReadLine()!;
        bool flag = int.TryParse(userType, out number);
        if (flag && number > 0) return number;
    }
}

 Console.WriteLine("Являются ли три положительных числа сторонами треугольника.");
int sideA = checkTypeNumber("Введите первое положительных число: ");
int sideB = checkTypeNumber("Введите второе положительных число: ");
int sideC = checkTypeNumber("Введите третье положительных число: ");

if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB) 
{
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine($"Три числа {sideA}, {sideB} и {sideC} являются сторонами треугольника");
    Console.ResetColor(); 
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Три числа {sideA}, {sideB} и {sideC} НЕ являются сторонами треугольника");
    Console.ResetColor(); 
}

