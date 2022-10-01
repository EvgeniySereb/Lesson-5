void FillArray(int [] num )
{
 for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(100 , 1000);
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
void PrintChet(int [] num)
{
    int Kol = 0;
    for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 ==0)
    {
      Kol +=1;

    }
    num[i]++;
    
}
Console.WriteLine("Количество Четных чисел в массиве = " + Kol);
}
int [] numbers =  new int [10];
 FillArray(numbers);
 PrintArray(numbers);
 PrintChet(numbers);