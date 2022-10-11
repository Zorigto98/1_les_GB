Console.WriteLine("Введите число до которого нужно посчитать кубы");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++)
{
    Console.WriteLine($"Куб числа : {i}  = {Math.Pow(i,3)}");
}