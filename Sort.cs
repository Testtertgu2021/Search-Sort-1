using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Sort_1
{
    class Sort
    {
        //sap xep noi bot
        static public void BubbleSort(int[] arr, int N)
        {
            int temp;
            for (int i = N - 1; i > 0; i--) //i: vt cuoi se dua phan tu max den do
            {
                for (int j = 0; j < i; j++) //i: vt bot
                {
                    if (arr[j] > arr[j + 1]) // neu hai phan tu lien tiep sai vt thi doi cho
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }

        }
        static public void SelectionSort(int[] a, int N)
        {
            int imin; //chi so phan tu nho nhat cua doan dang xet
            int temp;

            for (int i = 0; i < N - 1; i++) // i : vt pt dau doan dang xet
            {
                imin = i;
                for (int j = i + 1; j < N; j++)
                    if (a[j] < a[imin])
                        imin = j; //ghi nhan vt pt nho nhat

                //hoan vi
                temp = a[i];
                a[i] = a[imin];
                a[imin] = temp;
            }
        }
        // sap xep chen
        static public void InsertionSort(int[] a, int N)
        {
            int j, x;
            for (int i = 1; i < N; i++) //i
            {
                x = a[i]; //luu gt arr[i] de tranh bi ghi de khi doi cho pt //tim vt chen trong doan da sap

                j = i - 1; //tu vt cuoi da sap
                while (j >= 0 && a[i] > x)
                {
                    a[j + 1] = a[j]; // doi sang phai pt lon hon x
                    j--;
                }
                a[j + 1] = x; //chen x vao doan 
            }
        }
        //sap nhanh tren toan mang a thi truyen tham so
        //left = 0 , right = a,Lenght - 1
        static public void QuickSort(int[] a, int left, int right)
        {
            int x = a[(left + right) / 2];
            int i = left;
            int j = right;
            int temp;
            while (i < j)
            {
                while (a[i] < x)
                    i++;
                while (a[j] > x)
                    j--;
                if (i < -j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    i++;
                    j--;
                }
            }
            if (left < j)
                QuickSort(a, left, j);
            if (left < right)
                QuickSort(a, i, right);
        }
    }
}
