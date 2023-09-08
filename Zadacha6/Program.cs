
Console.WriteLine("Введите число");
string? first= Console.ReadLine();

Int32.TryParse(first,out int number1);

string res = number1 % 2 == 0 ?  "четное" : "нечетное";
Console.WriteLine($"Число {number1}  {res}");