using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Search_Sort_1
{

    class Program
    {
        static void DisplayElements(int[] a, int N)
        {
            for (int i = 0; i < N; i++)
                Console.Write(a[i] + "");
        }
        static void Main(string[] args)
        {
            int[] a = { 16, 82, 6, 76, 4, 6, 76, 4, 82, 2 };
            int[] b = { 2, 4, 6, 16, 76, 82 };

            Console.Write("Mang ban dau la:\t");
            DisplayElements(a, a.Length);

            int X = 6;

            int vitri1 = Search.SeqSearch(a, a.Length, X);
            Console.WriteLine("\n\nTom kiem tuan tu :" + " chi socu ptu {0} trong mang la : {1} ", X, vitri1);


            int vitri2 = Search.BinSearch(b, b.Length, X);
            Console.Write("\n\nMang b da sap xep tuan tu la:\t");
            DisplayElements(b, b.Length);
            Console.WriteLine("\n\nTiem kiem nhi phan: " + " Chi so phan tu {0} trong mang b la: {1} ", X, vitri2);

            Sort.BubbleSort(a, a.Length);
            Console.Write("\n\nMang sap tang theo giai thuat noi bot la:\t");
            DisplayElements(a, a.Length);
            Console.WriteLine();

            Sort.InsertionSort(a, a.Length);
            Console.Write("\n\nMang sap tang theo giai thuat chen la:\t");
            DisplayElements(a, a.Length);
            Console.WriteLine();


            Sort.QuickSort(a, 0, a.Length - 1);
            Console.Write("\n\nMang sap tang theo giai thuat nhanh la:\t");
            DisplayElements(a, a.Length);
            Console.WriteLine();

            Sort.SelectionSort(a, a.Length);
            Console.Write("\n\nMang sap tang theo giai thuat chon la:\t");
            DisplayElements(a, a.Length);
            Console.WriteLine();
        }
    }
}