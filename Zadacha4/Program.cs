
Console.WriteLine("Введите первое число");
string? first= Console.ReadLine();

Int32.TryParse(first,out int number1);

Console.WriteLine("Введите второе число");
string? second= Console.ReadLine();

Int32.TryParse(second,out int number2);

Console.WriteLine("Введите третье число");
string? three = Console.ReadLine();

Int32.TryParse(three,out int number3);

int max1 = number1 > number2  ? number1 : number2;
int max = max1 > number3 ? max1 : number3;

Console.WriteLine($" Максимвальным из чисел {number1}  {number2}   {number3}  является {max}");

