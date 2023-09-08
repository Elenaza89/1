Console.WriteLine("Введите  число");
string? first= Console.ReadLine();

Int32.TryParse(first,out int N);

List<int> arr = new List<int>();

for(int i=1; i <N; i++)
{
    if(i % 2 == 0)
    {
        arr.Add(i);
    }
}
foreach(var s in arr)
{
    Console.Write(s + " ");
}
