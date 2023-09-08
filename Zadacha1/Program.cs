
Console.WriteLine("Введите первое число");
string? first= Console.ReadLine();

Int32.TryParse(first,out int number1);

Console.WriteLine("Введите второе число");
string? second= Console.ReadLine();

Int32.TryParse(second,out int number2);

int max = number1 > number2 ? number1 : number2;
int min = number2 < number1 ? number2 : number1;

Console.WriteLine($"Максимальное число {max}, минимальное число {min}");
