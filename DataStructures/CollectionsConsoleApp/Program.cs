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