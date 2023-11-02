using IS = System.Runtime.InteropServices;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] xs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
int[] ys = new int[10];

void ShowArray(in string name, in int[] xs)
{
  Console.Write($"{name}: [");
  Array.ForEach(xs, i => Console.Write($"{i}, "));
  Console.WriteLine("]");
}


[IS.DllImport("native", EntryPoint = "add", CallingConvention = IS.CallingConvention.Cdecl, ExactSpelling = true)]
static extern int add();

ShowArray("xs", xs);
ShowArray("ys", ys);

// run native
var x = add();
Console.WriteLine($"x: {x}");

ShowArray("xs", xs);
ShowArray("ys", ys);
