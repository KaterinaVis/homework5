/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76 */

int size = 10;
double[] numbers = new double[size];
double max = 0;
double min = 0;
double diff = 0;

FillArrayRandomNumbres(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
  if (max < numbers[i])
  {
    max=numbers[i];
  }
 else 
  {
    min=numbers[i];
  }
}
diff=max-min;

Console.WriteLine($"Максимальный элемент {max}");
Console.WriteLine($"Минимальный элемент {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {diff}");

void FillArrayRandomNumbres(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = Math.Round(new Random().NextDouble()*10,1);
}
}

void PrintArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
