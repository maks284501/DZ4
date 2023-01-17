//задаём переменные
 int[] masiv = new int[8]; // объявляем массив
       int n=0;

//запрашиваем цифры 8 раз подряд
while(n<8)

{Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 masiv[n] = number;
 n=n+1;
}     
            
            
 //Вывод массива         
 Console.Write("Array: ");
 for(int i = 0; i<masiv.Length; i++)
Console.Write(" " + masiv[i]); 
