// int a,b ;

// Console.BackgroundColor = ConsoleColor.Yellow;
// Console.WriteLine("Chương trình cộng trừ nhân chia hai số");
// Console.ResetColor();
// Console.WriteLine("Nhập số thứ nhất: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Nhập số thứ hai: ");
// b= int.TryParse(Console.ReadLine(), out b) ? b : 1;
// Console.WriteLine("Tổng hai sô {0} và {1} là: {2}", a, b, a + b);
// Console.WriteLine("Hiệu hai sô {0} và {1} là: {2}", a, b, a - b);
// Console.WriteLine("Tích hai sô {0} và {1} là: {2}", a, b, a * b);
// Console.WriteLine("Thương hai sô {0} và {1} là: {2}", a, b, a / b); 
// Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
// Console.WriteLine("Nhấn phím bất kỳ để thoát chương trình");
// Console.ReadKey();  

// int x =2; 
// x +=10;
// Console.WriteLine("Giá trị của x là: {0}", x);

// int c = 5;
// int d= 2+ c++;

// int e =5;
// int f = 2 + ++e;
// Console.WriteLine("Giá trị của c là: {0}", c);
// Console.WriteLine("Giá trị của d là: {0}", d);
// Console.WriteLine("Giá trị của e là: {0}", e);
// Console.WriteLine("Giá trị của f là: {0}", f);

//bài 1
// using System.ComponentModel.DataAnnotations;

// int a ,b ;
// a=15 ; b =4 ;
// Console.WriteLine("Tổng là :{0}", a + b);
// Console.WriteLine("Hiệu là :{0}", a - b);
// Console.WriteLine("Tích là :{0}", a * b);
// Console.WriteLine("Thương là :{0}", a / b);
// Console.WriteLine("Phần dư là :{0}", (double)a % b);

// //Bài 2 
// double chieuDai = 12.5;
// double chieuRong = 4.2;
// Console.WriteLine("Chu vi hình chữ nhật là {0}", (chieuDai+chieuRong)*2);
// Console.WriteLine("Diện tích hình chữ nhật là {0}", chieuDai*chieuRong);

// //Bài 3
// double celius = 30;
// Console.WriteLine("Fahrenheit = {0}", celius * 9 / 5 + 32);

// //Bài 4 
// int number = 37; 
// if (number %2 == 0)
// {
//     Console.WriteLine(number + " là số chẵn");

// }else
// {
//     Console.WriteLine(number + " là số lẻ");
// }

// //Bai 5 
// int x =10 ;
//  Console.WriteLine(x++);
// Console.WriteLine(x);
// Console.WriteLine(++x);
// Console.WriteLine(x--);
// Console.WriteLine(--x);
// Console.WriteLine("KQ1:"+ 10);
// Console.WriteLine("KQ2:"+ 11);
// Console.WriteLine("KQ3:"+ 12);
// Console.WriteLine("KQ4:"+ 12);
// Console.WriteLine("KQ5:"+ 10);

// //Bai 6 
// double math = 8.5;
// double physics = 7.0;
// double chemistry = 9.0;
// double average = (math + physics + chemistry) / 3;
// Console.WriteLine("Điểm trung bình là: {0}", average);

// //Bai 7
// int age = 20;
// bool hasCard = true;
//  if (age >=18 && hasCard)
// {
//     Console.WriteLine("Được phép vào ");
// }else
// {
//     Console.WriteLine("Không được phép vào");
// }

// //Bai8 
// int score = 7 ;
// string c = (score >=5) ? "Đậu" : "Rớt";
// Console.WriteLine(c);

// Console.WriteLine("Bài tập 9 ");
// double Score = 8.5;
// bool hasCompletedHomework = false;
// string Diem = (Score >= 8 && hasCompletedHomework ) ? "Gioi"
//  : (Score < 8 && Score >= 6.5 && hasCompletedHomework )? "Khá"
//   : (Score < 6.5 && Score >= 5 && hasCompletedHomework ) ? "Trung Bình"
//    : (Score < 5 && hasCompletedHomework ) ? "Yếu" : "Cần hoàn thành bài tập";

//    Console.WriteLine(Diem);

// Console.WriteLine("Bài tập 10");
// float n= 10,m= 3.5f, k=2;
// float max = (n>m)? (n>k) ? n : k :(m>k) ? m : k ;

// tường minh : 
// if (n> m )
// {
//     if(n>k)
//     {
//         max = n;
//     }
//     else
//     {
//         max = k;
//     }
// }else
// {
//     if(m>k )
//     {
//         max = m;
//     }
//     else
//     {
//         max = k ;
//     }
// }

bool kq;
bool a = true;
bool b = false;
kq = !(a || b);

Console.WriteLine(kq);