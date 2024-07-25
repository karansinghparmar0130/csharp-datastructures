using Array;

int[] array = [1, 2, 3];

// Filter
Func<int, bool> filterCriteria = (x) =>  x % 2 == 0;

Console.WriteLine("Test Filter V1");
var filterResult1 = array.Filter(filterCriteria);
foreach(var value in filterResult1)
    Console.WriteLine(value);

Console.WriteLine("Test Filter V2");
var filterResult2 = array.FilterV2(filterCriteria);
foreach(var value in filterResult2)
    Console.WriteLine(value);

Console.WriteLine("Test Filter V3");
var filterResult3 = array.FilterV3(filterCriteria);
foreach(var value in filterResult3)
    Console.WriteLine(value);

// Map
Func<int, int> mapCriteria = (x) =>  x * 2;

Console.WriteLine("Test Map V1");
var mapResult1 = array.Map(mapCriteria);
foreach(var value in mapResult1)
    Console.WriteLine(value);

Console.WriteLine("Test Map V2");
var mapResult2 = array.MapV2(mapCriteria);
foreach(var value in mapResult2)
    Console.WriteLine(value);

Console.WriteLine("Test Map V3");
var mapResult3 = array.MapV3(mapCriteria);
foreach(var value in mapResult3)
    Console.WriteLine(value);

// Reduce
Func<int, int, int> reduceCriteria = (acc, value) => acc + value;

Console.WriteLine("Test Reduce V1");
var reduceResult1 = array.Reduce(0, reduceCriteria);
Console.WriteLine(reduceResult1);

Console.WriteLine("Test Reduce V2");
var reduceResult2 = array.ReduceV2(0, reduceCriteria);
Console.WriteLine(reduceResult2);
