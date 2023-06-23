int[] ages = new int[] { 23, 45, 21, 67, 33 };

int sum = 0;
for (int i = 0; i < 5; i++)
{
    sum = sum + ages[i];
}


int num = 100;
while (num > 0)
{
    num = num / 2;
    Console.WriteLine($"From While : {num}");
}

int num2 = 100;
do
{
    num2 = num2 / 2;
    Console.WriteLine($"From Do-While : {num2}");
}
while (num2 > 0);


foreach(int age in ages)
{
    Console.WriteLine(age);
}