﻿var names = new Array.Array("Ahmet", "Fatma", "Elif");

names.SetItem(2, "Kader");

foreach (var name in names)
{
    Console.WriteLine(name);
}




var array = new Array.Array();

array.Add("Ahmet");
array.Add("Fatma");
array.Add("Elif");
array.Add("Berra");
array.Add("Kader");

Console.WriteLine(array.GetItem(array.Find("Elif"))); 

foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.WriteLine(array.Count);
Console.WriteLine(array.GetItem(3));

Console.Read();

