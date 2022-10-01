//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(double [] num )
{
 for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(0, 11) + new Random().NextDouble();
}

}
    
void PrintArray(double [] num )
{

for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + " ");
    
    
}
Console.WriteLine();
}
double Max(double [] num)
{
    double max = num[0];
    
    for (int i = 0; i < num.Length; i++)
    {
        if(num[i] > max)
        {
            max = num[i];
        }

    }

    Console.WriteLine("Максимальный элемент массива = " + max);
          return max;
}
  double Min(double [] num)

          {
            double min = num[0];
for (int i = 0; i < num.Length; i++)
    {
        if(num[i] < min)
        {
            min = num[i];
        }

    }
    Console.WriteLine("Минимальный элемент массива = " + min);
    return min;
}
void Diff(double Min , double Max)
{
    double raz = Min - Max;
    Console.WriteLine("Разница между максимальным и минимальным значением = " + raz);
}

double [] numbers =  new double [10];


 FillArray(numbers);
 PrintArray(numbers);
 double Maximum = Max(numbers);
 double Minimum = Min(numbers);

 Diff(Maximum , Minimum);