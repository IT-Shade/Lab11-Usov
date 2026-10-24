int[] number = { 2, 8, 1, 9, 1, 2 };
bool found = false;
int duplicate1 = 0;
int duplicate2 = 0;

for (int i = 0; i < number.Length; i++)
{
    for (int j = i + 1; j < number.Length; j++)
    {
        if (number[i] == number[j])
        {
            duplicate1 = number[i];
            duplicate2 = number[j];
            found = true;
            break;
        }
    }
}

Console.WriteLine($"Найдено дубликатов: {duplicate1} и {duplicate2}");

int foundNumber = -1;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        foundNumber = i;
        break;
    }
}

Console.WriteLine($"Первое число кратное 2 и 3: {foundNumber}");