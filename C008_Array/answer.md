1. Array là gì?
- Trả lời : Array hay còn gọi là mảng, là nơi chứa các giá trị có cùng kiểu dữ liệu
2. Vì sao index của array bắt đầu từ 0?
- Trả lời : Vì vị trí đầu tiên của mảng được đánh dấu tại vị trí 0. 
3. Length cho biết điều gì?
- Trả lời : Length cho biết tổng số phần tử trong mảng. Length không phải index. Nếu mảng có Length bằng 4 thì index cuối cùng là 3, tức Length - 1.theo số thứ tự từ 1 
4. Khác nhau giữa for và foreach khi duyệt array?
- For thường dùng để tìm phần tử tại vị trí index và cập nhật index
- Foreach lấy các phần tử trong mảng ra ,dễ code , dễ quan sát
5. Vì sao i <= array.Length có thể gây lỗi?
- Vì trong vòng lặp i sẽ đại diện cho index, nếu i<=array.Length thì sẽ  bị báo lỗi exception do index đếm từ 0  và Length đếm từ 1>
6. Array khác List<T> ở điểm nào?
- Array và List<T> khác nhau ở việc :
+ Array được khởi tạo với giá trị ban đầu và không thể thêm bớt giá trị
+ List<T> sẽ linh hoạt hơn khi có thể thay đổi , thêm xóa các giá trị khi khởi tạo
7. `Array.Sort` khác `OrderBy` ở điểm nào?
- Cùng là sắp xếp nhưng Array.Sort là phương thức của Array còn OrderBy dùng trong LinQ
8. `Sum`, `Max`, `Min`, `Count` và `Where` dùng để làm gì?
- Các phương thức trên là phương thức của LinQ dùng để tính tống, tìm giá trị lớn nhất , tìm giá trị nhỏ nhất , đếm số phần tử , và where dùng để xét điều kiện
9. Vì sao nên học `for/foreach` trước LINQ?
- Học for/foreach để  hiểu bản chất của Array đối với vòng lặp
- Học Linq khi đã nắm chắc for/foreach , các phương thức của LINQ sẽ hô trợ các tác vụ trên mảng tiện lợi hơn




