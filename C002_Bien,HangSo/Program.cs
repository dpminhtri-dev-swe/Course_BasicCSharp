/// <summary>
/// Chuơng trình tính tổng hai số nguyên
/// </summary>
int a, b, tong ; 
Console.WriteLine("Enter first number: ");
if(!Int32.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return;
}

Console.WriteLine("Enter second number: ");
if(!Int32.TryParse(Console.ReadLine(), out b))
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
    return;
}
tong = a + b;
Console.WriteLine("The sum of {0} and {1} is: {2}", a, b, tong);

