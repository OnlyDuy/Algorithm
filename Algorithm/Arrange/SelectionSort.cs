using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Arrange
{
    //- Thuật toán Sắp xếp chọn(Selection sort)
    //	+ Lần lượt tìm kiếm các phần tử nhỏ nhất(hoặc lớn nhát) trong ds và đổi chỗ các phần tử đầu tiên của danh sách đó
    //	+ Các bước:
    //	   Chia mảng làm 2 phần: phần đã sắp xếp + phần chưa sắp xếp
    //     GD1: phần đã sắp xếp ko cs phần tử nào
    //     Trong mỗi lượt, tìm phần tử nhỏ nhất trong phần chưa sắp xếp và đổi chỗ cho phần tử đầu tiên của phần chưa
    //  sắp xếp => Lượt 1: phần tử đầu tiên là nhỏ nhất => đưa phần tử này vào phần đã sắp xếp
    //  => Qua mỗi lượt, phần đã sắp xếp sẽ mở rộng dần, phần chưa sắp xếp sẽ thu hẹp dần
    public class SelectionSort
    {
        public static void SapXepChon(int[] mangSo)
        {
            for (int i = 0; i < mangSo.Length - 1; i++)
            {
                // Xác định vị trí của phàn tử cần sắp xếp ( vị trí nhỏ nhất )
                int vitriMin = i;
                for (int j = i + 1; j < mangSo.Length; j++)
                {
                    if (mangSo[j] < mangSo[vitriMin])
                    {
                        vitriMin = j;
                    }
                }

                if (i != vitriMin)
                {
                    int temp = mangSo[i];
                    mangSo[i] = mangSo[vitriMin];
                    mangSo[vitriMin] = temp;
                }
            }
        }
    }
}
