// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
//using System;
using IS = System.Runtime.InteropServices;


namespace CsBindgen
{
  internal static unsafe partial class NativeMethods
  {
    const string __DllName = "nativelib";

    [IS.DllImport(__DllName, EntryPoint = "add", CallingConvention = IS.CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int add(int left, int right);


  }



}
