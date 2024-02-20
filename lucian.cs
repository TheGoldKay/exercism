void testing(){
   int n1 = 1;
   var n2 = 1;
   Console.WriteLine(n1 == n2); 
   Console.WriteLine(n1.GetType());
}

public class Test
{
    int num;
    public Test(int num)
    {
        this.num = num;
    }
    public int sub(int x, int y)
    {
        return x-y;
    }
}

//testing()
var test = new Test(10);
Test test2 = new Test(11);
//Console.WriteLine(test.GetType() == test2.GetType()) // should return true
Console.WriteLine(test.sub(1, 2)); // returns -1
Console.WriteLine(test.sub(y:1, x:2)); // returns 1

// The Exercism.io Challenge

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int elapsed)
    {
        return 40 - elapsed;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int elapsed)
    {
        return elapsed + layers * 2;
    }
}
