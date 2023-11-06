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
static extern void add(IntPtr xs, IntPtr ys);
//static extern void add(IntPtr xs, int[] ys);
//static extern void add(int[] xs, int[] ys);


void CallCppFunction(in int[] xs, int[] ys)
{

  // protect gc
  System.IntPtr ptrx = IS.Marshal.AllocCoTaskMem(IS.Marshal.SizeOf(typeof(int)) * xs.Length);
  System.IntPtr ptry = IS.Marshal.AllocCoTaskMem(IS.Marshal.SizeOf(typeof(int)) * ys.Length);

  IS.Marshal.Copy(xs, 0, ptrx, xs.Length);

  add(ptrx, ptry);

  IS.Marshal.Copy(ptry, ys, 0, ys.Length);

  // release protect
  IS.Marshal.FreeCoTaskMem(ptrx);
  IS.Marshal.FreeCoTaskMem(ptry);

}

ShowArray("xs", xs);
ShowArray("ys", ys);

// run native
CallCppFunction(xs, ys);

ShowArray("xs", xs);
ShowArray("ys", ys);
