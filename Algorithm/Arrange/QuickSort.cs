using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Arrange
{
    //- Thuật toán sắp xếp nhanh(Quicksort)
    //	+ Hoạt động theo nguyên tắc chia nhỏ, sử dung 1 phần tử được gọi là điểm chốt để chia mảng thành 2 phần con
    //	+ 1 phần có các phần tử <= pivot
    //	+ 1 phần có các phần tử > pivot
    //	+ Hoạt động theo logic: 
    //      1, duyệt xuôi từ đầu mảng để tìm gtri > pivot
    //      2, duyệt ngược từ cuối mảng để tìm gtri<pivot
    //      3, Nếu tìm thấy cả 2 thì đổi chỗ 2 phần tử này với nhau
    //      4, Lặp lại

    public class QuickSort
    {
        public static void SapXepNhanh(int[] mangSo, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(mangSo, left, right);
                SapXepNhanh(mangSo, left, pivot - 1);
                SapXepNhanh(mangSo, pivot + 1, right);
            }
        }

        private static int Partition(int[] mangSo, int left, int right)
        {
            int pivot = mangSo[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (mangSo[j] <= pivot)
                {
                    i++;
                    Swap(mangSo, i, j);
                }
            }

            Swap(mangSo, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] mangSo, int i, int j)
        {
            int temp = mangSo[i];
            mangSo[i] = mangSo[j];
            mangSo[j] = temp;
        }
    }
}
