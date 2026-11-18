using System.ComponentModel.Design;
using System.Data;

Console.WriteLine("Dãy số từ 1 -> 10");
for(int i =0 ; i<=10 ; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-----------------------------------------------");
int a =2;
while(a<=20)
{
    if(a%2 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}

Console.WriteLine("-----------------------------------------------");
int tong =0 ;
for(int i=0 ; i <=100 ; i ++)
{
    tong +=i;
}
Console.WriteLine("Tổng các số từ 1->100 là :" + tong);
Console.WriteLine("-----------------------------------------------");
int b= 10;
while(b > 0)
{
    Console.WriteLine(b);
    if(b ==1)
    {
        Console.WriteLine ("Start");
    }
    b--;
}

Console.WriteLine("-----------------------------------------------");
int luaChon;
do
{   
    Menu:
    Console.WriteLine("1.Xin Chào!");
    Console.WriteLine("2.In thông tin");
    Console.WriteLine("0.Thoát");
    Console.WriteLine ("Nhập lựa chọn:");
    if (!int.TryParse(Console.ReadLine(), out luaChon))
    {
        Console.WriteLine("Vui Lòng nhập số !!");
        continue;
    }
    if (luaChon ==0 )
        break;
    switch(luaChon)
    {
        case 1 :
        Console.WriteLine("Xin chào bạn !!");
        break;
        case 2 :
        Console.WriteLine("Name: Joshep");
        Console.WriteLine("Age: 20");
        break;
        default:
        Console.WriteLine("Vui lòng chọn số bên trên .");
        goto Menu;
    }

}while(true);

Console.WriteLine("-----------------------------------------------");
int chiaHetChoBay=0;
for(int i = 1 ; i<=100 ; i ++)
{
    if(i % 7 ==0)
    {
         chiaHetChoBay = i;
    break;
    }
   
}
Console.WriteLine("Số đầu tiên chia hết cho 7 là: "+ chiaHetChoBay);
 Console.WriteLine("-----------------------------------------------");
Console.WriteLine ("In các số từ 1 -> 10 bỏ 5 :");
for(int i =1 ; i<=10 ; i ++)
{
    if(i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}
 Console.WriteLine("-----------------------------------------------");

for(int row =1 ; row <=5 ; row++)
{
    for(int col =1; col <=row; col ++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}