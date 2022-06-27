//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Прогрмма работает при условии, если вы сперва вводите a - всегда являющиеся наименьшим числом, а b - всегда наибольшим.

// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a; 
int b; 
Console.WriteLine("Введите два числа"); 
a = Convert.ToInt32(Console.ReadLine()); 
b = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("{0} наименьшее число", a); 
Console.WriteLine("{0} наибольшее число", b); 
Console.ReadLine(); 