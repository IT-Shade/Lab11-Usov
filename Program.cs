int[] number = { 4, 35, 12, 5, 8};
int target = 8;
int foundIndex = -1;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] == target)
    {
        foundIndex = i;
        break;
    }
}

Console.WriteLine($"Число найдено, индекс: {foundIndex}");

int[] Number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
int sum = 0;

foreach (int number in Number)
{
    if (number % 2 != 0)
    {
        continue;
    }
    sum += number;
}

Console.WriteLine($"Сумма чётных чисел: {sum}");