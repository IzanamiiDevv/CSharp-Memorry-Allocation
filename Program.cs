using System;
using System.Runtime.InteropServices;

class Program
{
    public unsafe static void Main()
    {
        int[] numbers = { 19,2,3,4,6,19,29,3,4,5, 20 ,12 ,13, 14, 39, 8, 10, 9 ,18, 5};
        int size = 10;

        IntPtr ptr = Marshal.AllocHGlobal(sizeof(int) * size);
        int* numarr = (int*)ptr.ToPointer();

        Initial(numarr, size, numbers);


        Console.WriteLine("Hello World");
        PrinArray(numarr, 15);

        ReAssign(&size, 20);
        ptr = Marshal.ReAllocHGlobal(ptr, (IntPtr)(sizeof(int) * size));
        numarr = (int*)ptr.ToPointer();
        Initial(numarr, size, numbers);

        PrinArray(numarr, 15);

        Marshal.FreeHGlobal(ptr);
    }

    public unsafe static void Initial(int* buffer, int size, int[] array)
    {
        for(int i = 0; i < size; i++)
        {
            buffer[i] = array[i];
        }
    }

    public unsafe static void PrinArray(int* array, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    public unsafe static void ReAssign(int* buffer, int vakue)
    {
        (*buffer) = vakue;
    }
}