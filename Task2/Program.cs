/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] masiv = new int[10];
int sum = 0;
Console.Write("Массив: ");
for(int i = 0; i < masiv.Length; i++)
{
    masiv[i] = new Random().Next(-1000, 1001);
    Console.Write(masiv[i] + " ");
    if (i % 2 != 0)
    {
        sum += masiv[i]; 
    }
}
Console.WriteLine();
Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях равна " + sum);