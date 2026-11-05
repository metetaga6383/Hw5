double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];

double avg = Average(week);
Console.WriteLine($"Average temperature is : {avg:F1}°C\n");

int hottestDay = 0;
double maxTemp = week[0];
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > maxTemp)
    {
        hottestDay = i;
        maxTemp = week[i];
    
    }
}

Console.WriteLine($"The hottest day : {hottestDay}. day {maxTemp}°C\n");
Console.WriteLine("The days which are warmer than average :");
for (int i = 0;i < week.Length; i++)
{
    if (week[i] > avg)
    {
        Console.WriteLine($"{i}. day : {week[i]}°C");
    }
}

Console.WriteLine("\nLast three days degrees: ");
foreach(double temp in week[^3..])
{
    Console.WriteLine(temp);
}

static double Average(double[] t)
{
    double sum = 0;

    foreach (double temp in t)
    {
        sum += temp;
    }

    return sum / t.Length;
}