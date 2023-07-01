/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] masiv = new double[10];
double min = 100;
double max = 0;
Console.Write("Массив: ");
Random rand = new Random();
int i = 0;
for (i = 0; i < masiv.Length; i++)
{
    masiv[i] = rand.Next(1, 100) + rand.NextDouble();
    Console.Write(Math.Round(masiv[i], 2) + " | ");
    if (masiv[i] > max)
        {
            max = Math.Round(masiv[i], 2);
        }
    if (masiv[i] < min)
        {
            min = Math.Round(masiv[i], 2);
        }
}

System.Console.WriteLine();
System.Console.WriteLine("Максимальное число = " + max);
System.Console.WriteLine("Минимальное число = " + min);
System.Console.WriteLine($"Разница max и min = {max - min}");