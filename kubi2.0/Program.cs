Console.WriteLine("Введите число до которого нужно посчитать кубы и вывести чмсла, заканчивающиеся на четную цифру");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N; i++)
{
    if (Math.Pow(i,3)%2 == 0) Console.WriteLine($"Куб числа : {i}  = {Math.Pow(i,3)}");
}