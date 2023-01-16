// Запрос числа от пользователя
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num=0;

// Условие
while (number>0)
{
  num=((number%10)+num);
 number=number/10;
  


}

Console.WriteLine($"Количество: {num}");
