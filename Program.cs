using System;
using System.Runtime.InteropServices;

class Program
{
    public unsafe static void Main()
    {
        IntPtr ptr = Marshal.AllocHGlobal(sizeof(int) * 10);
        int* numarr = (int*) ptr.ToPointer();

        int[] numbers = { 19,2,3,4,6,19,29,3,4,5};

        for(int i = 0; i < 10; i++)
        {
            numarr[i] = numbers[i];
        }
        Console.WriteLine("Hello World");
        Console.WriteLine($"NumArr: {numarr[0]}");

        Marshal.FreeHGlobal(ptr);
    }
}