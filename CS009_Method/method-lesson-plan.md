# Giáo án CS009 – Method trong C#

## 1. Mục tiêu bài học

Sau bài này, bạn có thể:

- Giải thích method là gì và vì sao cần chia chương trình thành các method.
- Khai báo, gọi method và truyền tham số.
- Phân biệt giá trị trả về `void`, `int`, `string`, `bool` và kiểu khác.
- Hiểu phạm vi truy cập `public`, `private`, `protected`.
- Tạo method trong class.
- Dùng method overloading.
- Phân biệt truyền tham trị và tham chiếu với `ref`, `out`, `in`.
- Đọc và viết method theo phong cách phù hợp với backend C#.

## 2. Nội dung theo video

### Chương 1 – Khái niệm về method

- Method là một khối lệnh có tên, thực hiện một nhiệm vụ cụ thể.
- Method giúp tránh lặp code, dễ đọc, dễ kiểm thử và dễ bảo trì.
- Phân biệt method declaration và method invocation.

### Chương 2 – Cú pháp và phạm vi truy cập

- Cú pháp tổng quát:

```csharp
[access_modifier] [static] return_type MethodName(parameters)
{
    // thân method
    return value;
}
```

- `public`: có thể gọi từ nơi khác.
- `private`: chỉ dùng bên trong class khai báo nó.
- `protected`: class khai báo và class kế thừa có thể dùng.
- Nếu không ghi access modifier trong class member, mặc định thường là `private`.

### Chương 3 – Khai báo method trong class

- Method nên có một trách nhiệm rõ ràng.
- Tên method thường dùng PascalCase: `CalculateTotal()`.
- Tham số dùng camelCase: `unitPrice`.
- Method `static` có thể gọi qua tên class mà không cần tạo object.
- Method không `static` cần object để gọi.

### Chương 4 – Method overloading

- Nhiều method có cùng tên nhưng khác danh sách tham số.
- Có thể khác số lượng tham số hoặc kiểu dữ liệu tham số.
- Không thể overload chỉ bằng cách đổi kiểu trả về.

### Chương 5 – Truyền tham số

- Tham số là biến ở phần khai báo method.
- Đối số là giá trị truyền vào khi gọi method.
- Tham số mặc định và named arguments.

### Chương 6 – Tham chiếu và tham trị

- Kiểu giá trị thường được truyền theo giá trị: method nhận bản sao.
- `ref`: biến phải được khởi tạo trước khi truyền vào; method có thể thay đổi biến gốc.
- `out`: không cần khởi tạo trước; method bắt buộc gán giá trị trước khi kết thúc.
- `in`: truyền tham chiếu chỉ đọc, không cho method thay đổi giá trị.
- Với reference type, cần phân biệt thay đổi object và gán lại biến tham chiếu.

## 3. Lộ trình học đề xuất

1. Đọc phần khái niệm và tự viết 3 method `void`.
2. Viết method có giá trị trả về.
3. Thử gọi method từ `Main`.
4. Viết class `Calculator` để luyện access modifier và overloading.
5. Làm bài tập tham trị, `ref`, `out`, `in`.
6. Trả lời câu hỏi phỏng vấn trong `answer.md`.
7. Chạy `dotnet build` và tự giải thích từng method trong code.

## 4. Tiêu chí hoàn thành

- [ ] Giải thích được method bằng lời của mình.
- [ ] Tự viết được method có và không có giá trị trả về.
- [ ] Phân biệt được `public`, `private`, `protected`.
- [ ] Tự viết được ít nhất một overload.
- [ ] Giải thích được sự khác nhau giữa tham trị, `ref`, `out`, `in`.
- [ ] Hoàn thành toàn bộ bài tập và không có lỗi build.

