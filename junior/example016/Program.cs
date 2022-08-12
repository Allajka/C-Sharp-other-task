// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.Write("Введите порядковый номер дня недели:  ");
int userDay = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday ", "Saturday", "Sunday" };

while (userDay > 7 || userDay <= 0) 
{
    Console.Write("Введите порядковый номер дня недели от 1 до 7:  ");
    serDay = Convert.ToInt32(Console.ReadLine());
}

if (userDay == 6 || userDay == 7) Console.WriteLine($"{weekDays[userDay-1]} выходной"); 
else Console.WriteLine($"{weekDays[userDay-1]} будний день");


// if (int.TryParse(userDay, out int number))
// {
//     while (userDay > 7 || userDay <= 0) 
//         {
//             Console.Write("Введите порядковый номер дня недели от 1 до 7:  ");
//             userDay = Convert.ToInt32(Console.ReadLine());
//         }

//     if (userDay == 6 || userDay == 7) Console.WriteLine($"{weekDays[userDay-1]} выходной"); 
//     else Console.WriteLine($"{weekDays[userDay-1]} будний день");
// }
// else
// {
//     Console.WriteLine("Некорректный ввод числа");
// }  