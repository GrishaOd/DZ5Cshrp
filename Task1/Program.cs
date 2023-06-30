/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] masiv = new int[8];
int count = 0;
for(int i = 0; i < masiv.Length; i++)
{
    masiv[i] = new Random().Next(100, 1000);
    Console.Write(masiv[i] + " ");
    if (masiv[i] % 2 == 0)
    {
        count ++;
    }
}
Console.WriteLine();
Console.Write("Количество четных чисел в массиве - " + count);