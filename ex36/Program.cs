/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int size = 4;
int[] numbers = new int[size];
int sum = 0;

FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for (int i=1; i < numbers.Length; i=i+2)
{
   sum += numbers[i];
}

Console.Write ($"Сумма элементов, стоящих на нечётных позициях: {sum} ");


void FillArrayRandomNumbres(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 10);
}
}

void PrintArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
