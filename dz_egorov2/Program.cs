Console.WriteLine("Введите число и процент");
double chislo = Convert.ToInt32(Console.ReadLine());
int procent = Convert.ToInt32(Console.ReadLine());
double result;
if (procent < 1 | procent > 100)
{
    Console.WriteLine("Ошибка");
}
else
{
    result = chislo * (procent / 100.0);
    Console.WriteLine($"Результат равен: {result}");

}
