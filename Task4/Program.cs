Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
int sum = 1;

while (sum <= number)
{
    Console.Write($" {sum}");
    sum = sum + 1;

}