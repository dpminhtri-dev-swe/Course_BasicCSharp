# Bài tập CS009 – Method

## Bài 1 – Method không trả về

Viết method `PrintWelcome(string name)` in ra:

```text
Xin chào, {name}!
```

## Bài 2 – Method có giá trị trả về

Viết các method:

- `Add(int a, int b)`
- `Subtract(int a, int b)`
- `Multiply(int a, int b)`
- `Divide(double a, double b)`

Trong `Main`, gọi từng method và in kết quả.

## Bài 3 – Kiểm tra số

Viết các method:

- `IsEven(int number)` trả về `true` nếu số chẵn.
- `IsPositive(int number)` trả về `true` nếu số dương.
- `GetMax(int a, int b)` trả về số lớn hơn.

## Bài 4 – Method trong class

Tạo class `Student` có:

- `Name`
- `Score`
- method `IsPassed()` trả về `true` nếu điểm từ 5 trở lên.
- method `PrintInfo()` in thông tin sinh viên.

## Bài 5 – Access modifier

Tạo class `BankAccount`:

- `public Deposit(decimal amount)` để nạp tiền.
- `public Withdraw(decimal amount)` để rút tiền.
- `private IsValidAmount(decimal amount)` để kiểm tra số tiền hợp lệ.
- Không cho số dư xuống dưới 0.

## Bài 6 – Method overloading

Tạo class `Calculator` với các method `Add`:

- cộng 2 số nguyên;
- cộng 3 số nguyên;
- cộng 2 số thực.

Giải thích vì sao C# chọn đúng method trong mỗi lần gọi.

## Bài 7 – Tham trị

Viết method `ChangeValue(int value)` gán `value = 999`.

Gọi method rồi in biến bên ngoài. Giải thích vì sao biến bên ngoài không đổi.

## Bài 8 – `ref`

Viết method `Swap(ref int a, ref int b)` để hoán đổi hai biến.

Ví dụ:

```text
a = 10, b = 20
sau khi gọi: a = 20, b = 10
```

## Bài 9 – `out`

Viết method:

```csharp
bool TryParsePositive(string text, out int number)
```

Method trả về `true` nếu chuỗi là số nguyên dương, đồng thời đưa kết quả vào `number`.

## Bài 10 – Method xử lý mảng

Viết các method nhận `int[] numbers`:

- `GetSum`
- `GetAverage`
- `GetMax`
- `CountEvenNumbers`

Không dùng LINQ ở bài này; luyện vòng lặp và method trước.

## Bài 11 – Mini project máy tính

Tạo chương trình máy tính có các method:

- `ReadNumber`
- `ReadOperator`
- `Calculate`
- `PrintResult`

Tách mỗi nhiệm vụ thành method riêng thay vì viết toàn bộ trong `Main`.

## Bài 12 – Bài phỏng vấn

Tự trả lời bằng lời của mình:

1. Nếu một method có 15 tham số, bạn thấy vấn đề gì?
2. Khi nào dùng `out` thay vì trả về một giá trị?
3. Vì sao helper method thường để `private`?
4. Tại sao không nên lạm dụng `ref`?
5. Trong backend, Controller và Service thường chứa những method nào?

## Tiêu chí tự chấm

- [ ] Mỗi method có tên rõ nghĩa.
- [ ] Mỗi method chỉ làm một nhiệm vụ chính.
- [ ] Không lặp lại cùng một đoạn code.
- [ ] Chọn đúng kiểu trả về.
- [ ] Hiểu được dữ liệu bên ngoài có bị thay đổi hay không.
- [ ] Chạy được chương trình và `dotnet build` không có lỗi.

