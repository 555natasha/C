// взяли три точки - вершины треугольника. 
// Возьмем из них 2 случаные точки и найдем середину между ними.
// Опять выберем точку и найдем середину. и так далее

Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

//определяем первые вершины треугольника
int xa = 40, ya = 1, 
    xb = 1, yb = 20, 
    xc = 80, yc = 20;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

// определили какую-то точку х, в которую положили нашу первую точку xa,ya
int x = xa, y = ya;
// вводим счетчик - сколько раз надо поделить отрезки пополам
int count = 0;

while(count < 10000)
{
    // генерируем случайное число what 
    int what = new Random().Next(0, 3); // выбираем одну из трех точек, 
                                        // поэтому указываем диапозон от 1 до 3 - 0 1 2
    if (what == 0) // 
    {
        x = (x + xa)/2; // в х кладем середину отрезка
        y = (y + ya)/2; // в y кладем середину отрезка
    }

    if (what == 1) // 
    {
        x = (x + xb)/2; // в х кладем середину отрезка
        y = (y + yb)/2; // в y кладем середину отрезка
    }

    if (what == 2) // 
    {
        x = (x + xc)/2; // в х кладем середину отрезка
        y = (y + yc)/2; // в y кладем середину отрезка
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}