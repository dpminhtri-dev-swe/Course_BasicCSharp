# Lesson C008: Mảng trong C#

## 1. Mảng là gì?

Mảng, tiếng Anh là array, dùng để lưu nhiều giá trị có cùng kiểu dữ liệu.

Không dùng mảng:

```csharp
int score1 = 8;
int score2 = 7;
int score3 = 9;
```

Dùng mảng:

```csharp
int[] scores = { 8, 7, 9 };
```

Mảng giúp quản lý nhiều giá trị bằng một tên chung.

## 2. Khai báo và khởi tạo

```csharp
int[] numbers = { 10, 20, 30, 40 };
string[] names = { "An", "Binh", "Chi" };
```

Khai báo kích thước trước:

```csharp
int[] numbers = new int[5];
```

Mảng trên có 5 phần tử, mặc định đều là 0.

```text
Index:  0   1   2   3   4
Value:  0   0   0   0   0
```

## 3. Index bắt đầu từ 0

```csharp
int[] numbers = { 10, 20, 30, 40 };

Console.WriteLine(numbers[0]); // 10
Console.WriteLine(numbers[2]); // 30
```

Bảng index:

```text
Index:  0   1   2   3
Value: 10  20  30  40
```

Phần tử thứ nhất có index 0, phần tử thứ hai có index 1.

## 4. Cập nhật phần tử

```csharp
int[] numbers = { 10, 20, 30 };

numbers[1] = 99;

Console.WriteLine(numbers[1]); // 99
```

## 5. Thuộc tính Length

```csharp
int[] numbers = { 10, 20, 30, 40 };

Console.WriteLine(numbers.Length); // 4
```

Index hợp lệ nằm trong khoảng từ 0 đến Length - 1.

Mảng có Length bằng 4 thì index hợp lệ là 0, 1, 2, 3.

## 6. Lỗi vượt quá phạm vi

```csharp
int[] numbers = { 10, 20, 30 };
Console.WriteLine(numbers[3]);
```

Đoạn code này gây IndexOutOfRangeException vì mảng chỉ có index từ 0 đến 2.

## 7. Duyệt mảng bằng for

```csharp
int[] numbers = { 10, 20, 30, 40 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
```

Điều kiện quan trọng là i < numbers.Length. Không dùng i <= numbers.Length vì sẽ vượt index cuối.

## 8. Duyệt mảng bằng foreach

```csharp
int[] numbers = { 10, 20, 30, 40 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

So sánh:

```text
for     = có index, phù hợp khi cần vị trí hoặc cập nhật phần tử
foreach = lấy từng giá trị, code dễ đọc hơn
```

## 9. Tính tổng phần tử

```csharp
int[] numbers = { 10, 20, 30 };
int total = 0;

foreach (int number in numbers)
{
    total += number;
}

Console.WriteLine(total); // 60
```

## 10. Tìm số lớn nhất

```csharp
int[] numbers = { 10, 25, 7, 40, 18 };
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine(max); // 40
```

Ta bắt đầu từ index 1 vì đã dùng phần tử đầu tiên làm max ban đầu.

## 11. Đếm số chẵn

```csharp
int[] numbers = { 1, 2, 4, 7, 8, 10 };
int count = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine(count); // 4
```

## 12. Mảng 2 chiều

Mảng 2 chiều có hàng và cột:

```csharp
int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

Console.WriteLine(matrix[0, 1]); // 2
```

Có thể hình dung:

```text
       cột 0  cột 1  cột 2
hàng 0   1      2      3
hàng 1   4      5      6
```

Mảng 2 chiều thường dùng vòng lặp lồng nhau, nhưng hãy chắc mảng 1 chiều trước.

## 13. Array hay List?

```text
Array = kích thước cố định sau khi tạo
List  = có thể thêm hoặc xóa phần tử linh hoạt
```

Trong bài này tập trung vào array. List<T> sẽ học sau.

## 14. Một số phương thức có sẵn của Array

Các phương thức này thuộc lớp `Array`, không phải LINQ.

### `Array.Sort`

```csharp
int[] numbers = { 30, 10, 20 };
Array.Sort(numbers);
// numbers: 10, 20, 30
```

### `Array.Reverse`

```csharp
int[] numbers = { 1, 2, 3 };
Array.Reverse(numbers);
// numbers: 3, 2, 1
```

### `Array.IndexOf`

```csharp
int[] numbers = { 10, 20, 30 };
int index = Array.IndexOf(numbers, 20);
Console.WriteLine(index); // 1
```

Nếu không tìm thấy, `Array.IndexOf` trả về `-1`.

### `Array.Resize`

```csharp
int[] numbers = { 1, 2, 3 };
Array.Resize(ref numbers, 5);
// numbers có Length bằng 5
```

`Array.Resize` tạo một mảng mới có kích thước khác rồi gán lại vào biến cũ.

## 15. LINQ cơ bản với mảng

LINQ giúp xử lý dữ liệu ngắn gọn. Khi học, bạn có thể viết rõ:

```csharp
using System.Linq;
```

Một số method thường gặp:

```csharp
int[] numbers = { 10, 20, 30, 40 };

int total = numbers.Sum();
int max = numbers.Max();
int min = numbers.Min();
double average = numbers.Average();
int count = numbers.Count();
```

Lọc số chẵn bằng `Where`:

```csharp
int[] evenNumbers = numbers
    .Where(number => number % 2 == 0)
    .ToArray();
```

Sắp xếp bằng LINQ:

```csharp
int[] sortedNumbers = numbers
    .OrderBy(number => number)
    .ToArray();
```

## 16. Cách thủ công và LINQ

Tính tổng thủ công:

```csharp
int total = 0;
foreach (int number in numbers)
{
    total += number;
}
```

Tính tổng bằng LINQ:

```csharp
int total = numbers.Sum();
```

LINQ ngắn hơn, nhưng vẫn nên hiểu `for` và `foreach` trước để biết bản chất.

## 17. Khi nào dùng LINQ?

```text
for/foreach = cần học bản chất, xử lý từng bước, debug chi tiết
LINQ        = muốn lọc, sắp xếp, tính toán collection ngắn gọn
```

## Tóm tắt

```text
array[index]           = lấy phần tử
array[index] = value   = cập nhật phần tử
array.Length           = số phần tử
for                    = duyệt có index
foreach                = duyệt từng giá trị
index hợp lệ           = 0 đến Length - 1
```

## Câu hỏi phỏng vấn

1. Array là gì?
2. Vì sao index của array bắt đầu từ 0?
3. Length cho biết điều gì?
4. Khác nhau giữa for và foreach khi duyệt array?
5. Vì sao i <= array.Length có thể gây lỗi?
6. Array khác List<T> ở điểm nào?
7. `Array.Sort` khác `OrderBy` ở điểm nào?
8. `Sum`, `Max`, `Min`, `Count` và `Where` dùng để làm gì?
9. Vì sao nên học `for/foreach` trước LINQ?

