# Ghi chú cài đặt môi trường C#

## 1. Extension đã xác nhận

### C# Dev Kit

- Publisher: Microsoft
- Mục đích: hỗ trợ IntelliSense, quản lý project, build, debug và test C#/.NET trong VS Code.
- Trạng thái: **Đã xác nhận đang hoạt động**.
- Bằng chứng: VS Code hiển thị thông báo C# Dev Kit đã cài khi chạy lệnh `\.NET: Generate Assets for Build and Debug`.

### C# extension

- Publisher: Microsoft
- Mục đích: syntax highlighting, IntelliSense, điều hướng code và phân tích lỗi C#.
- Trạng thái: **C# Dev Kit tự cài như dependency**.

### .NET Install Tool

- Publisher: Microsoft
- Mục đích: hỗ trợ C# extension/C# Dev Kit phát hiện và cài .NET SDK cần thiết.
- Trạng thái: **Dependency của C# extension/C# Dev Kit**.

## 2. Extension bổ sung đã cài

### Error Lens

- Hiển thị lỗi ngay trên dòng code.
- Hữu ích cho người mới học.
- Trạng thái: **Đã cài**.

### REST Client

- Gọi và kiểm tra HTTP API trực tiếp trong VS Code qua file `.http`.
- Sẽ dùng khi học ASP.NET Core Web API.
- Trạng thái: **Đã cài**.

### GitLens

- Xem lịch sử thay đổi của từng dòng code.
- Xem commit, diff và người đã sửa code.
- Sẽ dùng khi học Git và làm project.
- Trạng thái: **Đã cài**.

## 3. .NET SDK đã cài

```text
.NET SDK: 10.0.404
Target Framework của project: net10.0
```

Kiểm tra bằng:

```powershell
dotnet --version
dotnet --list-sdks
```

## 4. Các lệnh .NET đã sử dụng

### Xem trợ giúp

```powershell
dotnet new -h
dotnet new console -h
```

### Xem template project

```powershell
dotnet new list
```

### Tạo Console App

```powershell
dotnet new console -n CS001_HELLOWORD
```

### Build project

```powershell
dotnet build
```

Build code C# và tạo output DLL/EXE.

### Chạy project

```powershell
dotnet run
```

Thường sẽ build nếu cần rồi chạy ứng dụng.

### Publish bản Release

```powershell
dotnet publish -c Release
```

Output thường nằm trong:

```text
bin\Release\net10.0\publish\
```

## 5. Command Palette đã sử dụng

### `.NET: Generate Assets for Build and Debug`

- Dùng để tạo hoặc chuẩn bị cấu hình build/debug cho VS Code.
- Với C# Dev Kit hiện tại, VS Code khuyến nghị dùng dynamic configuration.
- Vì vậy không nhất thiết xuất hiện thư mục `.vscode`.

### `Developer: Reload Window`

- Dùng để reload lại cửa sổ VS Code sau khi cài extension hoặc khi extension chưa load đúng.

### `Debug: Add Configuration`

- Dùng khi muốn tạo cấu hình debug thủ công như `launch.json`.
- Chưa cần dùng nếu C# Dev Kit tự nhận diện project và F5 hoạt động.

## 6. Project hiện tại

```text
D:\Course C#\CS001_HELLOWORD\
├── Program.cs
├── CS001_HELLOWORD.csproj
├── bin\
└── obj\
```

- `Program.cs`: code C# nguồn.
- `CS001_HELLOWORD.csproj`: cấu hình project.
- `bin`: kết quả build/publish.
- `obj`: file trung gian do .NET SDK tạo.

