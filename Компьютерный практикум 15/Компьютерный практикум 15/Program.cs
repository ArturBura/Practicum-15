//Составьте таблицу значений функции y = -5x² + 2x +1 на отрезке [-5; 5] с шагом h = 2.
//for(int x = -5; x <= 5 ; x += 2)
//{
//    double y = -5 * Math.Pow(x, 2) + 2 * x + 1;
//    Console.WriteLine(y);
//}
// Вариант 2
for (double x = -5.0; x <= 5.1; x+= 0.2)
{
    double x2 = Math.Pow(x, 3);
       Console.WriteLine($"x={Math.Round(x,1)} \t f(x)={Math.Round(x2,1)}");
}