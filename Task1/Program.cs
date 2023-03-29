void Programm(int m)
{
    int count = 0;
    int[] array = new int[m];
    for(int i = 0; i < array.Length; i++)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        array[i] = a;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            count++;
        } 
    }
    Console.Write($"Количество неотрицательных чисел: {count}");
}

Console.WriteLine("Введите кол-во чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Programm(M);