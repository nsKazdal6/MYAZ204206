using CollectionsConsoleApp;




//------------------------




var g1 = new List<int>() { 10, 20 , 30 , 25 , 4 };
var g2 = new List<int>() { 15, 25 , 35 , 3 , 25 , 4 };
var g3 = new List<int>() { 10, 15 , 20 , 25 , 40 , 50 , 4 };

g1
    .Union(g2)
    .Union(g3)
    .ToList()
    .ForEach( n => Console.WriteLine(n) );

g1
    .Intersect(g2)
    .Intersect(g3)
    .ToList()
    .ForEach( n => Console.WriteLine(n) );

g1
    .Except(g2)
    .Except(g3)
    .ToList()
    .ForEach( n => Console.WriteLine(n) );





//----------------------




var list = "ahmet".ToList();

foreach (var item in "kazdal")
{
    list.Add(item);
    Console.WriteLine($"{list.Count,-4}"+$"{list.Capacity,-4}");
}

var resault = new List<char>();  

foreach (var item in list)
{
    if (!resault.Contains(item))
    {
        resault.Add(item);
    }
    Console.WriteLine(item);
}




//-----------------------





var list1 = "meltem".ToList();
var hashset = new HashSet<char>();

foreach (var item in list1)
{
    hashset.Add(item);
}

hashset
    .ToList()
    .ForEach (n => Console.WriteLine(n) );

Console.ReadKey();





//--------------------





var list2 = new List<Customer>()
{
    new Customer(){Id=1,FullName="Ahmet Kazdal"},
    new Customer(){Id=2,FullName="Fatma Tan"},
    new Customer(){Id=3,FullName="Arif Yılmaz"},
    new Customer(){Id=4,FullName="Ayşe Sakal"},
    new Customer(){Id=5,FullName="Berra İclal"}
};

var list3 = new List<Customer>()
{
    new Customer(){Id=1,FullName="Ahmet Kazdal"},
    new Customer(){Id=4,FullName="Ayşe Sakal"},

};

var result = new List<Customer>();

foreach (Customer customer in list2)
{
    if (list3.Select(c => c.Id).Contains(customer.Id))
    {
        result.Add(customer);
    }
}

result.ForEach(c => Console.WriteLine(c.FullName));

Console.ReadKey();






