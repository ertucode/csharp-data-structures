using DataStructures;

var lru = new Lru<long, string>() { Capacity = 3 };
lru.Update(1, "1");
lru.Update(2, "3");
lru.Update(4, "4");
lru.Update(5, "5");
Console.WriteLine($"This shouldnt exist: {lru.Get(1)}");
Console.WriteLine($"This should exist: { lru.Get(2) }");


