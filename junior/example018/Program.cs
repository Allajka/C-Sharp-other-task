/* 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
¬ отрицание(инверсия !) - логическая операция, которая делает ложное высказывание истинным, а истинное ложным
⋁ дизъюнкция (логическое сложение || ) - дизъюнкция 2-х высказываний ложна тогда и только тогда, когда оба высказывания ложны
⋀ конъюнкция(логическое умножение &&) - конъюнкция 2-х высказываний истина тогда и только тогда, когда оба высказывания истины. 
Приоритет: 
1. скобка
2. инверсия
3. конъюнкция
4. дизъюнкция
таблица истинности https://docs.google.com/spreadsheets/d/1vQ0Gy5gDhY32hfoco-0FfpUCNPDnX-z1_F-cgEQasPc/edit?usp=sharing
*/

bool X1 = true; 
bool Y1 = true;
bool X2 = false; 
bool Y2 = false;
bool result1 = !(X1 || Y1);
bool result2 = !(X1 || Y2);
bool result3 = !(X2 || Y1);
bool result4 = !(X2 || Y2);

bool result11 = !X1 && !Y1;
bool result22 = !X1 && !Y2;
bool result33 = !X2 && !Y1;
bool result44 = !X2 && !Y2;

if (result1 == result11 && result2 == result22 && result3 == result33 && result4 == result44) 
{
    Console.Write ($"Утверждение истинно");
}
else Console.Write ($"Утверждение ложное");