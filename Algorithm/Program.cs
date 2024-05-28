using Algorithm.Arrange;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // SẮP XẾP CHỌN
            int[] mangSo1 = { 5, 2, 4, 1, 10 };
            SelectionSort.SapXepChon(mangSo1);
            Console.WriteLine("[Sắp xếp chọn] Mảng sau khi sắp xếp:");
            for (int i = 0; i < mangSo1.Length; i++)
            {
                Console.Write(mangSo1[i] + " ");
            }
            Console.WriteLine();

            // SẮP XẾP CHÈN
            int[] mangSo2 = { 5, 2, 4, 1, 10 };
            InsertionSort.SapXepChen(mangSo2);
            Console.WriteLine("[Sắp xếp chèn] Mảng sau khi sắp xếp:");
            for (int i = 0; i < mangSo2.Length; i++)
            {
                Console.Write(mangSo2[i] + " ");
            }
            Console.WriteLine();

            // SẮP NỔI BỌT
            int[] mangSo3 = { 5, 2, 4, 1, 10 };
            BubbleDort.SapXepNoiBot(mangSo3);
            Console.WriteLine("[Sắp xếp nổi bọt] Mảng sau khi sắp xếp:");
            for (int i = 0; i < mangSo3.Length; i++)
            {
                Console.Write(mangSo3[i] + " ");
            }
            Console.WriteLine();

            // SẮP XẾP NHANH
            int[] mangSo4 = { 5, 2, 4, 1, 10 };
            QuickSort.SapXepNhanh(mangSo4, 0, mangSo4.Length - 1);
            Console.WriteLine("[Sắp xép nhanh] Mảng sau khi sắp xếp:");
            for (int i = 0; i < mangSo4.Length; i++)
            {
                Console.Write(mangSo4[i] + " ");
            }
        }
    }
}
