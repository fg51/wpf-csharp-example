//using Wrapper;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//WrapperClass _wr = new WrapperClass();

int[] xs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] ys = new int[10];


Console.Write($"xs: [ ");
foreach (int i in xs)
{
  Console.Write($"{i}, ");
}
Console.WriteLine($" ]");




Console.Write($"ys: [ ");
foreach (var i in ys)
{
  Console.Write($"{i}, ");
}
Console.WriteLine($" ]");

var x = CsBindgen.NativeMethods.add(10, 10);
Console.WriteLine($"x = {x}");
