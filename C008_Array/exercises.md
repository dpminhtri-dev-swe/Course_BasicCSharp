# Bài tập C008: Mảng trong C#

Làm trong Program.cs của project C008_Array.

## Bài 1 — In phần tử

Tạo mảng:

```csharp
int[] numbers = { 5, 10, 15, 20, 25 };
```

In tất cả phần tử bằng for.

## Bài 2 — In ngược

In mảng từ phần tử cuối về phần tử đầu.

Kết quả:

```text
25 20 15 10 5
```

## Bài 3 — Tính tổng và trung bình

Tạo mảng điểm, tính tổng và điểm trung bình.

## Bài 4 — Tìm max và min

Tìm phần tử lớn nhất và nhỏ nhất mà không dùng hàm Max hoặc Min.

## Bài 5 — Đếm theo điều kiện

Đếm có bao nhiêu số chẵn và bao nhiêu số lẻ trong mảng.

## Bài 6 — Tìm phần tử

Cho mảng số và một giá trị cần tìm. Dùng vòng lặp để kiểm tra giá trị đó có tồn tại không.

Ví dụ:

```text
Can tim: 15
Ket qua: Tim thay tai index 2
```

## Bài 7 — Cập nhật phần tử

Cho mảng số. Tăng mỗi phần tử lên 10 rồi in mảng mới.

## Bài 8 — Tạo mảng mới

Array có kích thước cố định. Hãy tạo một mảng mới chỉ chứa các số khác 0 từ mảng ban đầu.

## Bài 9 — Mảng 2 chiều

Tạo ma trận 2 hàng, 3 cột và dùng vòng lặp lồng nhau để in ra dạng bảng.

## Bài 10 — Phương thức của Array

Với mảng `{ 30, 10, 20, 40 }`, hãy thử lần lượt:

- `Array.Sort`.
- `Array.Reverse`.
- `Array.IndexOf`.
- `Array.Resize`.

Ghi lại mảng trước và sau mỗi phương thức.

## Bài 11 — LINQ cơ bản

Thêm `using System.Linq;` nếu project chưa tự nhận namespace, sau đó dùng LINQ để:

- Tính tổng bằng `Sum`.
- Tìm lớn nhất bằng `Max`.
- Tìm nhỏ nhất bằng `Min`.
- Tính trung bình bằng `Average`.
- Đếm số chẵn bằng `Where` kết hợp `Count`.
- Tạo mảng mới chỉ chứa số chẵn bằng `Where` và `ToArray`.

## Bài 12 — Trả lời bằng file

Tạo `answers.md` và trả lời 9 câu hỏi phỏng vấn ở cuối `array-lesson.md`.

## Khi gửi bài

Gửi:

1. Program.cs.
2. answers.md.
3. Kết quả chạy chương trình.
4. Bài nào khó nhất và lý do.

