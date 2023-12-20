List<int> numbers = new List<int> { 1, 22, -3, 45, -18, 64, 2, -7, 25 };
int lenght;

var orderedNumbers = from i in numbers
                     orderby i ascending
                     select i;
if (numbers.Count % 2 == 0)
{
    var newNumbers =  from n in orderedNumbers.TakeLast(numbers.Count/2)
                      orderby n descending
                      select n;
    List<int> final = newNumbers.ToList();
    foreach (var n in final)
    {
        Console.WriteLine(n * n);
    }
}
else
{
    var newNumbers = from n in orderedNumbers.TakeLast((numbers.Count + 1) / 2)
                     orderby n descending
                     select n;
    List<int> final = newNumbers.ToList();
    foreach (var n in final)
    {
        Console.WriteLine(n * n);
    }
}


