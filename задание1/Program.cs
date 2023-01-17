Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number1=number;
int sum=1;

// Условие
while (sum<num)
{
number=number*number1;
sum=sum+1;

}

Console.WriteLine($"Ответ: {number}");
