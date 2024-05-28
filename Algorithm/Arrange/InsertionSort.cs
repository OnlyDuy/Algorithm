using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Arrange
{
    //- Thuật toán sắp xếp chèn(Insertion sort)
    //	+ Lần lượt chèn từng phần tử vào vị trí thích hợp trong danh sách đã được sắp xếp một phần
    //	+ Các bước:
    //    Chia mảng làm 2 phần: phần đã sắp xếp + phần chưa sắp xếp
    //    Mở rộng phần sắp xếp ra phần tử đầu tiên của phần chưa sắp xếp
    // => Tìm cách chèn phần tử mới này vào đúng thứ tự nó cần có trong phần đã sắp xếp
    //    Việc chèn phần tử mới vào đúng thứ tự đc thực hiện bằng cách lần lượt
    // so sánh nó với các phần tử của vùng đã sắp xếp => nếu phần tử mới nhỏ hơn thì đổi chỗ với phần tử đang ss
    public class InsertionSort
    {
        public static void SapXepChen(int[] mangSo)
        {
            for (int i = 1; i < mangSo.Length; i++)
            {
                int giaTriChen = mangSo[i];
                // luu trữ vị trí của phần tử đang được ss với giá trị chèn
                int j = i - 1;
                //Vòng lặp hạy cho đến khi j nhỏ hơn 0 và mangSo[j] nhỏ hơn hoặc bằng giaTriChen.
                while (j >= 0 && mangSo[j] > giaTriChen)
                {
                    // Nếu mangSo[j] lớn hơn giaTriChen, điều đó có nghĩa là vị trí thích hợp để chèn giaTriChen
                    // nằm ở phía sau mangSo[j].
                    mangSo[j + 1] = mangSo[j];
                    j--;
                }
                mangSo[j + 1] = giaTriChen;
            }
        }
    }
}
