//  8. Показать четные числа от 1 до N

// Console.Write("Введите число: "); 
// int number = Convert.ToInt32(Console.ReadLine());
// string result = "";

// for (int i = 2; i <= number ; i= i+2)
// {
//     result = result + i + " ";
// }

// Console.Write("Четные числа: " + result);

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int index = 0;
int check = 2;

while (check <= number)
{
    array[index] = check;
    check = check + 2;
    index++;
}

index = 0;
while (index < number)
{
    Console.Write(array[index] + " ");
    index++;
}