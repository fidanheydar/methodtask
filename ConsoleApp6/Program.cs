#region task1
int[] arr = { 9, 23, 46, 778, 9, 123, 56, };
int num = 9;
Equal(arr);
void Equal(params int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == num)
        {
            Console.WriteLine(num + "This number is in the array");
            break;
        }
        else
        {
            Console.WriteLine(num + "This number is not in the array");
            break;
        }
    }
}
#endregion


#region task2
Console.WriteLine(MaxNum(81, -98, 3670, 10000, 984));
int MaxNum(params int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
#endregion