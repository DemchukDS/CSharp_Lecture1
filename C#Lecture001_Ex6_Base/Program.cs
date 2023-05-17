int obj1 , obj2 , obj3 , obj4 , obj5;
int max = obj1;

Cosole.WriteLine("Enter 5 object numbers: ");
Console.Write("The first - ");
Console.ReadLine(obj1);
Console.Write("The second - ");
Console.ReadLine(obj2);
Console.Write("The third - ");
Console.ReadLine(obj3);
Console.Write("The fourth - ");
Console.ReadLine(obj4);
Console.Write("The fifth - ");
Console.ReadLine(obj5);

if (obj1 > max) max = obj1;
if (obj2 > max) max = obj2;
if (obj3 > max) max = obj3;
if (obj4 > max) max = obj4;
if (obj5 > max) max = obj5;