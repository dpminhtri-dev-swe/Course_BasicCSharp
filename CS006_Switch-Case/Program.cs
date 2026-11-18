using System.ComponentModel.Design;

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Bài 1 : Cho 2 số a,b nhập từ bàn phím dùng switch case để chọn các phép tính ");
Console.ResetColor();

float a, b;
int luaChon;
while (true)
{
    Console.WriteLine("Nhập số a :");
    if(float.TryParse(Console.ReadLine(), out a))
     break;
    Console.WriteLine("Vui lòng  nhập số!!!");

}
while (true)
{
    Console.WriteLine("Nhập số b :");
    if(float.TryParse(Console.ReadLine(), out b))
     break;
    Console.WriteLine("Vui lòng  nhập số!!!");

}

do
{
    Menu:
    Console.WriteLine("Các phép tính:");
    Console.WriteLine("1.Cộng");
    Console.WriteLine("2.Trừ");
    Console.WriteLine("3.Nhân");
    Console.WriteLine("4.Chia");
    Console.WriteLine("Nhập lựa chọn của bạn :");
    if (!Int32.TryParse(Console.ReadLine(), out luaChon))
    {
        Console.WriteLine("Vui lòng nhập số nguyên");
        continue;
    }
    if (luaChon == 0)
    {
        Console.WriteLine("Bạn đã thoát chương trình ");
        break;
    }
    switch (luaChon)
    {
        case 1:
            Console.WriteLine("Tổng hai số {0} và {1} là {2}", a, b, a + b);
            break;
        case 2:
            Console.WriteLine("Hiệu hai số {0} và {1} là {2}", a, b, a - b);
            break;
        case 3:
            Console.WriteLine("Thương hai số {0} và {1} là {2}", a, b, a * b);
            break;
        case 4:
            if (b != 0)
            {
                Console.WriteLine("Tích hai số {0} và {1} là {2}", a, b, a / b);

            }
            else
            {
                Console.WriteLine("Không thể chia cho 0");
            }

            break;
           
        default:
            Console.WriteLine("Vui lòng chon số bên trên");
            goto Menu;
    

    }
}while(true);