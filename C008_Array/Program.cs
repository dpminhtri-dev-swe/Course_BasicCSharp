using System.Globalization;
using System.Net.WebSockets;
using System.Security.Principal;

Console.WriteLine("========= MẢNG 1 CHIỀU ==========");
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Bài 1.In các phần tử của mảng");
Console.ResetColor();
int[] numbers = [5,10,15,20,25];
for(int i =0 ; i< numbers.Length  ;i++)
{
    Console.WriteLine(numbers[i]);
}

Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Bài 2.In ngược các phần tử của mảng");
Console.ResetColor();

for(int i = numbers.Length -1; i >= 0 ; i--)
{
        Console.WriteLine(numbers[i]);

}

Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Bài 3. Tính tổng và trung bình của mảng");
Console.ResetColor();

int tong = 0;
foreach(int number in numbers)
{
    tong += number;
}

Console.WriteLine("Tổng các phần tử của mảng là : " + tong);
Console.WriteLine("Trung bình các phần tử trong mảng là : {0}", (float)tong/numbers.Length);

Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Bài 4. Tìm phần tử lớn nhất và nhỏ nhất trong mảng");
Console.ResetColor();

int min= numbers[0];
int max = numbers [0];
foreach(int number in numbers)
{
    if(number > max)
    {
        max = number;
    }
    if(number < min)
    {
        min = number;
    }
}

Console.WriteLine("Số lớn nhất trong mảng là :"+ max);
Console.WriteLine("Số nhỏ nhất trong mảng là :" + min);

Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Đếm số chẵn và lẻ trong mảng");
Console.ResetColor();

int countChan =0;
int countLe =0;
for(int i =0 ; i< numbers.Length ; i++)
{
    if(numbers[i] % 2== 0)
    {
        countChan ++ ;
    }
    else
    {
        countLe ++;
    }
}
Console.WriteLine("Số chắn trong mảng là :" + countChan);
Console.WriteLine("Số lẻ trong mảng là :" + countLe);


Console.ForegroundColor=ConsoleColor.Green;

Console.WriteLine("Bài 6. Tăng mỗi phần tử lên 10 và xuất ra mảng mới");
Console.ResetColor();

int[] a= new int[numbers.Length];

for (int i =0 ; i< a.Length ; i ++)
{
    
        a[i] = numbers[i]+10;
    
}
Console.WriteLine("Các phần tử của mảng sau khi cập nhật:");
foreach(int number in a )
{
    Console.WriteLine(number);
}

Console.ForegroundColor=ConsoleColor.Green;

Console.WriteLine("Bài 7.Tạo mảng mới");
Console.ResetColor();

int[] b = new int[5];
Console.WriteLine("Các phần tử của mảng mới:");
foreach(int number in b)
{
     Console.Write(number + " ");
}

Console.WriteLine("=========== Mảng 2 Chiều ==========");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bài 9. Tạo mảng 2 chiều, in các phần tử");
Console.ResetColor();
int[,] matrix =
{
    {1,2,3},
    {4,5,6}
};

for(int  row =0 ; row <= 1; row++){
    for(int  col =0 ; col <= 2; col++)
    {
     Console.Write(matrix[row,col]);   
    }
    Console.WriteLine("");
}


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bài 10. Phương thức của Array");
Console.ResetColor();

int[] mang = { 30, 10, 20, 40 };


// - `Array.Sort`.
// - `Array.Reverse`.
// - `Array.IndexOf`.
// - `Array.Resize`.
Console.WriteLine("Sort:");
Array.Sort(mang);
foreach(int number in mang)
{
    Console.Write(number + " ");
}
Console.WriteLine();
Console.WriteLine("Reverse: ");
Array.Reverse(mang);
foreach(int number in mang)
{
    Console.Write(number + " ");
}
Console.WriteLine();
Console.WriteLine("IndexOf: ");

Console.WriteLine(Array.IndexOf(numbers, 20));
Console.WriteLine("Resize");
Array.Resize(ref mang, 8);
foreach(int number in mang)
{
    Console.WriteLine(number);
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("========== LINQ ==========");
Console.ResetColor();
// - Tính tổng bằng `Sum`.
// - Tìm lớn nhất bằng `Max`.
// - Tìm nhỏ nhất bằng `Min`.
// - Tính trung bình bằng `Average`.
// - Đếm số chẵn bằng `Where` kết hợp `Count`.
// - Tạo mảng mới chỉ chứa số chẵn bằng `Where` và `ToArray`.

int[] LinQArray= {1,2,5,6,3,2};
Console.WriteLine("Sum:");
int tongLinq = LinQArray.Sum();
Console.WriteLine(tongLinq);
Console.WriteLine("Tìm MAX:");
int maxLinq= LinQArray.Max();
Console.WriteLine(maxLinq);
Console.WriteLine("Tìm MIN:");
int minLinq= LinQArray.Min();
Console.WriteLine(minLinq);
Console.WriteLine("Tính trung bình:");
double avgLinq= LinQArray.Average();
Console.WriteLine(avgLinq);
Console.WriteLine("Tạo mảng chứ số chẵn");
int[] soChan= LinQArray.Where(number => number%2==0).ToArray();
foreach(int number in soChan)
{
    Console.WriteLine(number);

}
Console.WriteLine("Xắp sếp tử trong mảng :");
int[] CountLinq = LinQArray.OrderBy(n =>n).ToArray();


Console.WriteLine("Đếm ptu trong mảng :");
int count = LinQArray.Where(n => n%3 ==0).Count();
Console.WriteLine(count);
