# CS009 – Method trong C#

## 1. Method là gì?

Method là một nhóm câu lệnh được đặt tên để thực hiện một nhiệm vụ.

```csharp
static void SayHello()
{
    Console.WriteLine("Hello!");
}

SayHello();
```

Một method thường gồm:

```csharp
static int Add(int a, int b)
{
    return a + b;
}
```

- `static`: method thuộc về class, chưa cần tạo object.
- `int`: kiểu dữ liệu trả về.
- `Add`: tên method.
- `int a, int b`: tham số.
- `return`: trả kết quả về nơi gọi.

## 2. Method `void` và method có giá trị trả về

`void` nghĩa là method không trả về giá trị:

```csharp
static void PrintLine(string message)
{
    Console.WriteLine(message);
}
```

Method có giá trị trả về:

```csharp
static int Square(int number)
{
    return number * number;
}

int result = Square(5); // 25
```

Kiểu trả về phải khớp với giá trị sau `return`.

## 3. Phạm vi truy cập

```csharp
public class UserService
{
    public void CreateUser()
    {
        ValidateUser();
    }

    private void ValidateUser()
    {
        Console.WriteLine("Validating...");
    }
}
```

- `public`: code bên ngoài class có thể gọi.
- `private`: chỉ class đó được gọi. Đây là mức mặc định an toàn cho helper method.
- `protected`: class hiện tại và class con có thể gọi.

Ví dụ `protected`:

```csharp
class Animal
{
    protected void Eat()
    {
        Console.WriteLine("Eating");
    }
}

class Dog : Animal
{
    public void Feed()
    {
        Eat();
    }
}
```

## 4. Method trong class và `static`

```csharp
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

Calculator calculator = new Calculator();
int result = calculator.Add(2, 3);
```

Với method `static`:

```csharp
class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

int result = MathHelper.Add(2, 3);
```

`static` phù hợp khi method không cần dữ liệu riêng của từng object.

## 5. Tham số và đối số

```csharp
static string Introduce(string name, int age)
{
    return $"Tên: {name}, tuổi: {age}";
}

string text = Introduce("An", 20);
```

- `name`, `age` là tham số.
- `"An"`, `20` là đối số.

Named argument:

```csharp
string text = Introduce(age: 20, name: "An");
```

## 6. Method overloading

Overloading là nhiều method cùng tên nhưng khác danh sách tham số:

```csharp
static int Add(int a, int b)
{
    return a + b;
}

static double Add(double a, double b)
{
    return a + b;
}

static int Add(int a, int b, int c)
{
    return a + b + c;
}
```

C# chọn method phù hợp dựa vào đối số truyền vào.

Không được overload chỉ bằng kiểu trả về:

```csharp
// Không hợp lệ nếu chỉ khác kiểu trả về
static int GetValue() => 1;
// static string GetValue() => "one";
```

## 7. Tham trị

Với kiểu giá trị như `int`, method thường nhận một bản sao:

```csharp
static void ChangeNumber(int number)
{
    number = 100;
}

int value = 10;
ChangeNumber(value);
Console.WriteLine(value); // 10
```

`number` đổi thành `100`, nhưng `value` bên ngoài vẫn là `10`.

## 8. `ref`

`ref` cho phép method thay đổi biến gốc. Biến phải được gán trước:

```csharp
static void Increase(ref int number)
{
    number++;
}

int value = 10;
Increase(ref value);
Console.WriteLine(value); // 11
```

`ref` phải xuất hiện ở cả lúc khai báo và lúc gọi.

## 9. `out`

`out` dùng khi method cần trả thêm kết quả qua tham số:

```csharp
static bool TryDivide(int a, int b, out double result)
{
    if (b == 0)
    {
        result = 0;
        return false;
    }

    result = (double)a / b;
    return true;
}

if (TryDivide(10, 2, out double answer))
{
    Console.WriteLine(answer); // 5
}
```

Method bắt buộc phải gán giá trị cho biến `out` trước khi kết thúc.

## 10. `in`

`in` truyền biến theo tham chiếu nhưng chỉ đọc:

```csharp
static void PrintNumber(in int number)
{
    Console.WriteLine(number);
    // number = 20; // lỗi
}

int value = 10;
PrintNumber(in value);
```

Trong các bài cơ bản, bạn nên nắm chắc tham trị trước; `ref`, `out`, `in` dùng khi có lý do rõ ràng.

## 11. Tham chiếu với reference type

Với object, method có thể thay đổi dữ liệu bên trong object:

```csharp
class Counter
{
    public int Value { get; set; }
}

static void Increase(Counter counter)
{
    counter.Value++;
}

Counter counter = new Counter { Value = 10 };
Increase(counter);
Console.WriteLine(counter.Value); // 11
```

Điều này khác với việc gán lại biến tham chiếu:

```csharp
static void Replace(Counter counter)
{
    counter = new Counter { Value = 100 };
}
```

`Replace` không thay đổi object mà biến bên ngoài đang trỏ tới.

## 12. Quy tắc viết method tốt

- Một method nên làm một việc chính.
- Đặt tên thể hiện hành động: `CalculateTotal`, `ValidateEmail`, `GetUserById`.
- Không viết method quá dài.
- Hạn chế dùng quá nhiều tham số; có thể gom thành class hoặc object request.
- Chọn access modifier hẹp nhất có thể.
- Không lạm dụng `ref`; ưu tiên trả về object hoặc tuple khi dễ đọc hơn.

## 13. Liên hệ với backend

Trong backend, method thường đại diện cho một hành động:

```csharp
public User GetUserById(int id)
{
    // tìm user trong database rồi trả về
    throw new NotImplementedException();
}
```

Ví dụ phân lớp thường gặp:

- Controller method nhận HTTP request.
- Service method xử lý nghiệp vụ.
- Repository method truy vấn database.

## 14. Câu hỏi phỏng vấn

1. Method là gì và tại sao cần dùng method?
2. Khác nhau giữa parameter và argument?
3. `void` có nghĩa gì?
4. `public`, `private`, `protected` khác nhau thế nào?
5. Method `static` khác method instance thế nào?
6. Method overloading là gì?
7. Có thể overload chỉ bằng kiểu trả về không? Vì sao?
8. Tham trị khác tham chiếu thế nào?
9. `ref` và `out` khác nhau điểm nào?
10. Khi nào nên tách code thành một method riêng?

