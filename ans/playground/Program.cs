// See https://aka.ms/new-console-template for more information

using Xunit;

void Main()
{
    var num1 = 100;
    int num2 = 100;
    Assert.Equal(num1, num2);
    Assert.Equal(num1.GetType(), num2.GetType());
    Console.WriteLine("All Tests Passed!");
    float n = 1.23f;
    var ns = (int)n;
    bool t = true;
    var ts = (int)t;
    Console.WriteLine($"{ts}");
}


Main();