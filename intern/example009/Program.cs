//  8. Показать четные числа от 1 до N

Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine());
string result = "";

for (int i = 2; i <= number ; i= i+2)
{
    result = result + i + " ";
}

Console.Write("Четные лисла: " + result);