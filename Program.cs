using System.ComponentModel;

int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
int count = 0;

foreach (int points in pointsPerLab)
{
    if (points < 0)
    {
        continue;
    }
    sum += points;
    count++;
}

Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
Console.WriteLine($"Количество сданных работ: {count}");

int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDupcicates = false;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            hasDupcicates = true;
            Console.WriteLine($"Найденные дубликаты: {groupIds[i]} и {groupIds[j]}");
            break;
        }
    }
}

Console.WriteLine(hasDupcicates ? "Есть повторяющиеся номера" : "Все номера уникальны");