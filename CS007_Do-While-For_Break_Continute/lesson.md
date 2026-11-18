# Lesson 007: `for`, `while`, `do while`, `break`, `continue`

## 1. Vì sao cần vòng lặp?

Nếu muốn in 5 dòng, ta có thể viết:

```csharp
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);
```

Nhưng nếu muốn in từ 1 đến 1.000 thì cách này rất dài. Vòng lặp cho phép chạy lại một đoạn code nhiều lần dựa trên một điều kiện.

```text
Kiểm tra điều kiện
      ↓
Đúng → chạy thân vòng lặp → quay lại kiểm tra
Sai  → thoát vòng lặp
```

## 2. Vòng lặp `for`

`for` thường dùng khi biết trước số lần lặp.

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

Đọc như sau:

```csharp
for (khởi tạo; điều kiện; cập nhật)
```

- `int i = 1`: chạy một lần trước vòng lặp.
- `i <= 5`: mỗi vòng kiểm tra điều kiện này.
- `i++`: sau mỗi vòng, tăng `i` lên 1.

Luồng chạy:

```text
i = 1 → in 1 → i++
i = 2 → in 2 → i++
i = 3 → in 3 → i++
i = 4 → in 4 → i++
i = 5 → in 5 → i++
i = 6 → điều kiện sai → dừng
```

## 3. Vòng lặp `while`

`while` dùng khi muốn lặp **trong khi điều kiện còn đúng**. Điều kiện được kiểm tra trước khi chạy thân vòng lặp.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

Nếu điều kiện sai ngay từ đầu, vòng `while` có thể chạy 0 lần:

```csharp
int i = 10;

while (i <= 5)
{
    Console.WriteLine(i);
}
```

Đoạn code trên không in gì.

## 4. Vòng lặp `do while`

`do while` chạy thân vòng lặp trước, sau đó mới kiểm tra điều kiện. Vì vậy nó luôn chạy ít nhất một lần.

```csharp
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);
```

Ví dụ điều kiện sai ngay từ đầu:

```csharp
int i = 10;

do
{
    Console.WriteLine(i);
}
while (i <= 5);
```

Đoạn code trên vẫn in `10` một lần.

## 5. So sánh `for`, `while`, `do while`

| Vòng lặp | Kiểm tra điều kiện | Dùng khi |
|---|---|---|
| `for` | Trước mỗi vòng | Biết trước số lần lặp |
| `while` | Trước mỗi vòng | Lặp khi điều kiện còn đúng |
| `do while` | Sau mỗi vòng | Muốn chạy ít nhất một lần |

## 6. Lệnh `break`

`break` dừng ngay vòng lặp gần nhất.

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i == 4)
    {
        break;
    }

    Console.WriteLine(i);
}
```

Output:

```text
1
2
3
```

Khi `i == 4`, chương trình thoát vòng lặp ngay nên không in `4`.

## 7. Lệnh `continue`

`continue` bỏ qua phần còn lại của **vòng hiện tại**, rồi chuyển sang vòng tiếp theo.

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;
    }

    Console.WriteLine(i);
}
```

Output:

```text
1
2
4
5
```

Khi `i == 3`, lệnh `Console.WriteLine(i)` bị bỏ qua, nhưng vòng lặp vẫn tiếp tục.

## 8. Cẩn thận với `continue` trong `while`

Trong `while`, phải cập nhật biến trước khi `continue`, nếu không có thể tạo vòng lặp vô hạn.

Sai:

```csharp
int i = 1;

while (i <= 5)
{
    if (i == 3)
    {
        continue; // i không tăng, vòng lặp bị kẹt tại 3
    }

    i++;
}
```

An toàn hơn:

```csharp
int i = 1;

while (i <= 5)
{
    if (i == 3)
    {
        i++;
        continue;
    }

    Console.WriteLine(i);
    i++;
}
```

## 9. Vòng lặp lồng nhau

Một vòng lặp có thể nằm bên trong vòng lặp khác.

```csharp
for (int row = 1; row <= 3; row++)
{
    for (int column = 1; column <= 4; column++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
```

Output:

```text
****
****
****
```

`break` bên trong vòng lặp lồng nhau chỉ dừng vòng lặp gần nhất, không tự động dừng tất cả vòng lặp.

## 10. Cách debug vòng lặp

Khi chưa hiểu output, hãy tạo bảng trace:

| Lần | Giá trị biến | Điều kiện | Hành động |
|---:|---:|---|---|
| 1 | 1 | `1 <= 5` đúng | In 1 |
| 2 | 2 | `2 <= 5` đúng | In 2 |
| 3 | 3 | `3 <= 5` đúng | In 3 |

Đặt breakpoint bên trong vòng lặp, sau đó nhấn `F5` và dùng `F10` để chạy từng dòng.

## Tóm tắt

```text
for       = biết trước số lần lặp
while     = kiểm tra trước, có thể chạy 0 lần
do while  = chạy trước rồi kiểm tra, luôn chạy ít nhất 1 lần
break     = dừng hẳn vòng lặp
continue  = bỏ qua vòng hiện tại, sang vòng kế tiếp
```

## Câu hỏi phỏng vấn

1. Khi nào dùng `for`, khi nào dùng `while`?
2. Điểm khác nhau quan trọng nhất giữa `while` và `do while` là gì?
3. `break` và `continue` khác nhau thế nào?
4. Vì sao `continue` có thể gây vòng lặp vô hạn trong `while`?
5. `break` trong vòng lặp lồng nhau dừng vòng nào?

