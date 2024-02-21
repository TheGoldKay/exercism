// See https://aka.ms/new-console-template for more information

using Xunit;

void Main1()
{
    var num1 = 100;
    int num2 = 100;
    Assert.Equal(num1, num2);
    Assert.Equal(num1.GetType(), num2.GetType());
    Console.WriteLine("All Tests Passed!");
    float n = 1.23f;
    var ns = (int)n;
    bool t = true;
    // var ts = (int)t;
    //Console.WriteLine($"{ts}");
}

void Main2()
{
  string a1 = "as";
  char a2 = 'a';
  var a3 = $"{a2}";
  Console.WriteLine(a1.GetType());
  Console.WriteLine(a2.GetType());
  Console.WriteLine(a3.GetType());
}

//Main1();
Main2();