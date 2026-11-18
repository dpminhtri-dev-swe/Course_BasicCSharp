# Tổng hợp bài Switch-Case và Menu

## 1. Nhập số an toàn bằng TryParse

Parse có thể gây lỗi nếu người dùng nhập chữ. TryParse kiểm tra trước khi chuyển đổi:

    float a;

    while (true)
    {
        Console.Write("Nhập số a: ");

        if (float.TryParse(Console.ReadLine(), out a))
            break;

        Console.WriteLine("Vui lòng nhập số hợp lệ!");
    }

Khi nhập đúng, TryParse trả về true và thoát vòng lặp bằng break. Khi nhập sai, chương trình báo lỗi rồi quay lại đầu vòng lặp.

## 2. Nhập lại nhiều giá trị

Có thể áp dụng cùng cách cho số b:

    float b;

    while (true)
    {
        Console.Write("Nhập số b: ");

        if (float.TryParse(Console.ReadLine(), out b))
            break;

        Console.WriteLine("Vui lòng nhập số hợp lệ!");
    }

Nếu phải nhập nhiều số, nên tạo một hàm dùng chung:

    static float NhapSo(string thongBao)
    {
        while (true)
        {
            Console.Write(thongBao);

            if (float.TryParse(Console.ReadLine(), out float ketQua))
                return ketQua;

            Console.WriteLine("Vui lòng nhập số hợp lệ!");
        }
    }

Sử dụng:

    float a = NhapSo("Nhập số a: ");
    float b = NhapSo("Nhập số b: ");

## 3. Nhập lựa chọn menu

Lựa chọn menu thường là số nguyên:

    int luaChon;

    if (!int.TryParse(Console.ReadLine(), out luaChon))
    {
        Console.WriteLine("Vui lòng nhập số nguyên!");
        return;
    }

Nếu muốn nhập sai thì hiện menu lại, đặt đoạn nhập trong vòng lặp và dùng continue.

## 4. Cấu trúc switch-case

switch dùng để chọn một nhánh dựa trên giá trị của biến:

    switch (luaChon)
    {
        case 1:
            Console.WriteLine("Thực hiện phép cộng");
            break;

        case 2:
            Console.WriteLine("Thực hiện phép trừ");
            break;

        case 3:
            Console.WriteLine("Thực hiện phép nhân");
            break;

        case 4:
            Console.WriteLine("Thực hiện phép chia");
            break;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ");
            break;
    }

break kết thúc case hiện tại. default chạy khi không có case nào phù hợp.

## 5. Chương trình menu lặp lại

Muốn người dùng tính nhiều lần, đặt menu trong do...while:

    int luaChon;

    do
    {
        Console.WriteLine();
        Console.WriteLine("1. Cộng");
        Console.WriteLine("2. Trừ");
        Console.WriteLine("3. Nhân");
        Console.WriteLine("4. Chia");
        Console.WriteLine("0. Thoát");
        Console.Write("Nhập lựa chọn: ");

        if (!int.TryParse(Console.ReadLine(), out luaChon))
        {
            Console.WriteLine("Vui lòng nhập số nguyên!");
            continue;
        }

        if (luaChon == 0)
        {
            Console.WriteLine("Đã thoát chương trình.");
            break;
        }

        float a = NhapSo("Nhập số a: ");
        float b = NhapSo("Nhập số b: ");

        switch (luaChon)
        {
            case 1:
                Console.WriteLine("Tổng = " + (a + b));
                break;

            case 2:
                Console.WriteLine("Hiệu = " + (a - b));
                break;

            case 3:
                Console.WriteLine("Tích = " + (a * b));
                break;

            case 4:
                if (b == 0)
                    Console.WriteLine("Không thể chia cho 0!");
                else
                    Console.WriteLine("Thương = " + (a / b));
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }
    while (luaChon != 0);

## 6. continue, break và return

- continue: bỏ qua lượt hiện tại và quay lại lượt lặp tiếp theo.
- break: thoát khỏi vòng lặp hoặc switch gần nhất.
- return: thoát khỏi hàm hoặc kết thúc chương trình.

Ví dụ:

    while (true)
    {
        if (!float.TryParse(Console.ReadLine(), out float so))
        {
            Console.WriteLine("Nhập sai!");
            continue;
        }

        Console.WriteLine("Đã nhập đúng.");
        break;
    }

## 7. goto trong menu

goto có thể nhảy về một nhãn:

    Menu:
    Console.WriteLine("Nhập lựa chọn:");

    if (!int.TryParse(Console.ReadLine(), out int luaChon))
    {
        Console.WriteLine("Nhập sai!");
        goto Menu;
    }

    if (luaChon == 0)
        return;

goto dùng được, nhưng với menu nên ưu tiên do...while hoặc while vì dễ đọc và dễ bảo trì hơn.

## 8. Các lỗi cần tránh

### Dùng sai placeholder

Nếu truyền ba giá trị thì chỉ được dùng {0}, {1}, {2}:

    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

Dùng {3} sẽ gây FormatException.

### Đảo tên phép tính

- case 3 với a * b là phép nhân, phải ghi Tích.
- case 4 với a / b là phép chia, phải ghi Thương.

### Chia cho 0

Luôn kiểm tra b trước khi chia:

    if (b == 0)
        Console.WriteLine("Không thể chia cho 0!");
    else
        Console.WriteLine(a / b);
