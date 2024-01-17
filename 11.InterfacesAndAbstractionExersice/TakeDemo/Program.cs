List<int> list = new List<int>(){1,2,3,4,5,6,6,7,8};

IReadOnlyCollection<int> listd = list.Skip(4).Take(..).ToList();
foreach (var i in listd)
{
    Console.WriteLine(i); 
}