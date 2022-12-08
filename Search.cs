using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Sort_1
{
    class Search
    {
        //tim kiem tuan tu
        public static int SeqSearch(int[] a, int N, int X)
        {
            for (int i = 0; i < N; i++)
                if (a[i] == X)
                    return i;
            return -1;
        }
        //tim kiem nhi phan
        //mang a cos N phan tu da sap tang
        public static int BinSearch(int[] a, int N, int X)
        {
            int low, up, mid;
            low = 0;
            up = N - 1;

            while (low <= up)
            {
                mid = (int)(low + up) / 2;
                if (X == a[mid])
                    return mid;
                else
                    if (X < a[mid])
                    up = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;

        }

    }
}
