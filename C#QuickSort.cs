using System;
public class Bubble_Sort
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 3, 5, 6, 2, 3, 5 };
        int j;
        for (int p = 0; p <= a.Length - 2; p++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    j = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = j;
                }
            }
        }
        Console.WriteLine("\n" + "Sorted numbers: ");
        foreach (int arraydisplay in a)
            Console.Write(arraydisplay + " ");
        Console.Write("\n");

    }
}