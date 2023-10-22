try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    int n = int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= n; i++)
        s += Math.Pow(x, i) * Math.Cos(i * Math.PI / 3) / 1;
    Console.WriteLine($"S={s:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}