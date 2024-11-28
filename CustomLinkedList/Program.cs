using CustomLimkedList.DataTypes;

CustomLimkedList.DataTypes.LinkedList<int> list = new CustomLimkedList.DataTypes.LinkedList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.AddToFront(10);
list.AddToEnd(10);
foreach(var i in list)
    Console.Write(i + " ");
Console.WriteLine();

Console.WriteLine("Count: " + list.Count);

Console.WriteLine("100 is in list: " + list.Contains(100));
Console.WriteLine("10 is in list: " + list.Contains(10));

Console.WriteLine("Remove 10");
list.Remove(10);
foreach(var i in list)
    Console.Write(i + " ");
Console.WriteLine();

Console.WriteLine("CopyTo method:");
int[] arr = new int[10];
list.CopyTo(arr,2);
foreach(var i in arr)
    Console.Write(i + " ");
Console.WriteLine();


