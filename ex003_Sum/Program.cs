//Console.Write("Введите первое число ");
//int first_ch = 3;
//Console.Write("Введите второе число ");
//int second_ch = 8;
int numberA = new Random().Next(1, 10); // 1 2 3 4 5 6 7 8 9
Console.Write("число numberA ");
Console.Write(numberA);
int numberB = new Random().Next(1, 10);
Console.Write(" число numberB ");
Console.WriteLine(numberB);

//int result = first_ch + second_ch;
int result = numberA + numberB;
Console.WriteLine("Сумма равна ");
Console.WriteLine(result);