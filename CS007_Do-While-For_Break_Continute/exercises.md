# Bài tập: Vòng lặp và điều khiển vòng lặp

Làm trong `Program.cs` của project `CS007_Do-While-For_Break_Continute`.

## Bài 1 — In số bằng `for`

In các số từ 1 đến 10.

## Bài 2 — In số chẵn

In các số chẵn từ 2 đến 20.

## Bài 3 — Tính tổng

Tính tổng các số từ 1 đến 100 bằng `for`.

Kết quả cần có:

```text
Tong = 5050
```

## Bài 4 — Đếm ngược bằng `while`

Dùng `while` để in từ 10 về 1, sau đó in:

```text
Start!
```

## Bài 5 — Menu bằng `do while`

Tạo menu chạy ít nhất một lần:

```text
1. Xin chao
2. In thong tin
0. Thoat
```

Menu lặp lại cho đến khi người dùng chọn `0`.

## Bài 6 — Tìm số đầu tiên chia hết cho 7

Duyệt từ 1 đến 100. Khi gặp số đầu tiên chia hết cho 7, in số đó rồi dùng `break`.

## Bài 7 — Bỏ qua số 5

In các số từ 1 đến 10 nhưng không in số 5. Dùng `continue`.

## Bài 8 — Tam giác dấu sao

Dùng vòng lặp lồng nhau để in:

```text
*
**
***
****
*****
```

## Bài 9 — Trace bằng tay

Không chạy code trước, hãy đoán output:

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 2)
    {
        continue;
    }

    if (i == 4)
    {
        break;
    }

    Console.WriteLine(i);
}
```

## Bài 10 — Trả lời bằng file

Tạo file `answers.md` và trả lời 5 câu hỏi phỏng vấn ở cuối `lesson.md`. Ghi thêm output của bài 9 và giải thích vì sao output có kết quả đó.

## Khi gửi bài

Gửi cho thầy:

1. `Program.cs`.
2. `answers.md`.
3. Kết quả chạy chương trình.
4. Bài nào bạn thấy khó nhất và vì sao.

