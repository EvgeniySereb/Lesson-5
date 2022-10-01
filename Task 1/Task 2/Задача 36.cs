//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(int [] num )
{
 for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(-20 , 20);
}

}
    
void PrintArray(int[] num )
{

for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + " ");
    
    
}
Console.WriteLine();
}
void SumI(int [] num)

{
    int Sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if(i % 2 > 0)
        {
            Sum = Sum + Math.Abs(num[i]);
        }
        
    }
    Console.WriteLine("Сумма элементов стоящих на нечётных позициях " + Sum);
}

int [] numbers =  new int [10];
 FillArray(numbers);
 PrintArray(numbers);
 SumI(numbers);