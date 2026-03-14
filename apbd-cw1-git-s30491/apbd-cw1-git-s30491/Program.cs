Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i % 2 == 0)
    {
        Console.WriteLine("d");
    }
    else if (i % 2 == 1)
    {
        Console.WriteLine("e");
    }
}

int CalculateAverage(int[] values)
{
    int sum = 0;
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }

    return sum / values.Length;
}

int CalculateMax(int[] values)
{
    int max = 0;
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }

    return max;
}
// here be treasure

int CalculateMin(int[] values)
{
    int min = int.MaxValue;
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] < min)
        {
            min = values[i];
        }
    }

    return min;
}