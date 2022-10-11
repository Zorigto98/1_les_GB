Console.WriteLine("Введите число, для которого нужно найти факториал");
int N = Convert.ToInt32(Console.ReadLine());
int Mult=1;

for (int i = 1; i < N; i++)
{
    Mult = Mult * i;
}

Console.WriteLine($"Факториал {N}  = {Mult}");