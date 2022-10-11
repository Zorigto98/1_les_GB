Console.WriteLine("Введите число которого нужно подсчитать сумму цифр");
int Num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = Num;

while (temp%10 != 0)
{
    sum = sum + temp%10;
    temp = temp/10;
}

Console.WriteLine($"сумма цифр числа {Num} = {sum}");