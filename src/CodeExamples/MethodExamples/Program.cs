
//int[] ages = new int[] { 23, 45, 21, 67, 33 };
//double average = (ages[0] + ages[1] + ages[2] + ages[3] + ages[4]) / 5;

int[] ages = new int[] { 12, 34, 54, 21, 32, 23, 21, 56, 31 };

int[] grades = new int[] { 3, 2, 4 , 5, 2 , 4 };


double average = CalculateAverage(ages);
Console.WriteLine(average);

double gradesAverage = CalculateAverage(grades);
Console.WriteLine(gradesAverage);



double CalculateAverage(int[] ages)
{ 
    int sum = 0;
    foreach (int age in ages)
    {
        sum = sum + age;
    }

    return sum + ages.Length;
}

object[] everythings = new object[] { 22, 3.51, "Bogura", true };

foreach (var item in everythings)
{
    Console.WriteLine(item);
}