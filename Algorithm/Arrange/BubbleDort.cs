using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Arrange
{
    //   - Sắp xếp nổi bọt(Bubble sort)
	//+ So sánh 2 phần tử liền kề trong danh sách và đổi chỗ chúng nếu chúng sai thứ tự
	//+ Sau mỗi lượt, phần tử lớn nhất của mảng sẽ nổi lên đầu ds
    public class BubbleDort
    {
        public static void SapXepNoiBot(int[] mangSo)
        {
            for (int i = mangSo.Length - 1; i >= 0; i--)
            {
                bool daSapXep = true;
                for (int j = 0; j < i; j++)
                {
                    if (mangSo[j] > mangSo[j + 1])
                    {
                        int temp = mangSo[j];
                        mangSo[j] = mangSo[j + 1];
                        mangSo[j + 1] = temp;
                        daSapXep = false;
                    }
                }

                if (daSapXep)
                {
                    break;
                }
            }
        }
    }
}
