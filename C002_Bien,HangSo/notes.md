# Ghi chú cá nhân

Mỗi khi gặp lỗi hoặc học được điều mới, ghi lại theo mẫu:

## Ngày 1

### Điều mới học được

- `Console.WriteLine()` : In dữ liệu ra màn hình rồi xuống dòng.

```csharp
Console.WriteLine("Xin chào");
```

- `Console.ReadLine()` : Đọc dữ liệu người dùng nhập vào. Kết quả luôn là kiểu `string` hoặc `null`.

```csharp
string? input = Console.ReadLine();
```

- `Console.BackgroundColor = ConsoleColor.Color` : Đổi màu nền của cửa sổ console.
- `Console.ForegroundColor = ConsoleColor.Color` : Đổi màu chữ trong console.

```csharp
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Nội dung");
Console.ResetColor();
```

- `Console.ResetColor()` : Khôi phục màu nền và màu chữ mặc định.

- Chuyển chuỗi sang số:

```csharp
int age = int.Parse("20");
float price = float.Parse("12.5");
long value = Convert.ToInt64("123456789");
float number = Convert.ToSingle("3.14");
```
- Hằng số : khi khai báo hằng số thì giá trị của nó không đổi,  ko bị ghi đè
```csharp
const int a =20 ;
```
- Một biến đã khai báo có thể nhận giá trị mới. Giá trị cũ sẽ bị thay thế:

```csharp
int number = 10;
number = 20;
Console.WriteLine(number); // 20
```

- Phủ định điều kiện bằng dấu `!`:

```csharp
bool isValid = false;

if (!isValid)
{
    Console.WriteLine("Dữ liệu chưa hợp lệ");
}
```

- `TryParse()` trả về `true` hoặc `false`, đồng thời đưa giá trị chuyển đổi vào biến `out`:

```csharp
if (int.TryParse(input, out int result))
{
    Console.WriteLine($"Số vừa nhập là {result}");
}
else
{
    Console.WriteLine("Dữ liệu không hợp lệ");
}
```

- `Parse()` trả về giá trị đã chuyển đổi, không trả về `true` hoặc `false`:

```csharp
int result = int.Parse("123");
```

Nếu chuỗi không hợp lệ, `Parse()` sẽ phát sinh lỗi. Vì vậy, khi nhận dữ liệu từ người dùng, nên dùng `TryParse()`.

### Lỗi đã gặp

1. Không biết cách đọc dữ liệu vì chưa biết dùng `Console.ReadLine()`.
2. Chưa biết một biến đã khai báo có thể nhận giá trị mới.
3. Chưa phân biệt cách dùng `Parse()` và `Convert.To...()`.
4. Dùng `Parse()` trực tiếp trong `if`.
5. Gõ sai tên một số hàm và thuộc tính như `Console.ReaadLine()`, `Console.Realine()`, `BackGroundColor` hoặc `ForceGroundColor`.

### Nguyên nhân

1. `Console.ReadLine()` có chữ `Line` viết hoa chữ `L` và chỉ đọc dữ liệu dưới dạng chuỗi.
2. Chưa hiểu phép gán `=` sẽ thay thế giá trị cũ của biến.
3. Chưa nắm rõ kiểu dữ liệu mà mỗi hàm chuyển đổi trả về.
4. Nhầm rằng `Parse()` cũng trả về `true` hoặc `false` như `TryParse()`.
5. Chưa nhớ đúng tên các API của C#.

### Cách giải quyết

#### 1. Đọc và chuyển đổi dữ liệu nhập vào

```csharp
Console.Write("Nhập tuổi: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"Tuổi của bạn là {age}");
}
else
{
    Console.WriteLine("Bạn phải nhập một số nguyên");
}
```

#### 2. Ghi đè giá trị của biến

```csharp
int score = 5;
score = 10; // Giá trị 5 bị thay bằng 10
```

#### 3. Chọn đúng hàm chuyển đổi

- Dùng `Parse()` khi chắc chắn chuỗi hợp lệ:

```csharp
int number = int.Parse("100");
```

- Dùng `TryParse()` khi dữ liệu có thể sai, đặc biệt là dữ liệu người dùng nhập:

```csharp
if (int.TryParse(input, out int number))
{
    Console.WriteLine(number);
}
```

- Dùng `Convert.ToInt64()` để chuyển sang `long`, kiểu số nguyên 64-bit có thể nhận số âm.
- Dùng `Convert.ToSingle()` để chuyển sang `float`, kiểu số thực độ chính xác đơn.

#### 4. Không dùng `Parse()` trực tiếp trong `if`

Không viết:

```csharp
// Sai: Parse() trả về int, không phải bool
// if (int.Parse(input)) { }
```

Hãy dùng:

```csharp
if (int.TryParse(input, out int number))
{
    Console.WriteLine(number);
}
```

### Ghi nhớ nhanh

| Hàm | Kết quả trả về | Khi nào dùng |
|---|---|---|
| `int.Parse()` | Một giá trị `int` | Khi chắc chắn dữ liệu hợp lệ |
| `float.Parse()` | Một giá trị `float` | Khi chắc chắn chuỗi là số thực |
| `Convert.ToInt64()` | Một giá trị `long` | Khi cần số nguyên 64-bit |
| `Convert.ToSingle()` | Một giá trị `float` | Khi cần số thực kiểu `float` |
| `int.TryParse()` | `true` hoặc `false` | Khi dữ liệu có thể không hợp lệ |
