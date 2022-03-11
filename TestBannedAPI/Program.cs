public class MyObject
{
    public static implicit operator bool(MyObject obj)
    {
        return obj != null;
    }

    public static void AMethod(MyObject obj)
    {
        Console.WriteLine("hi");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var myObj = new MyObject();
        MyObject.AMethod(myObj);
        if (myObj)
        {
            Console.WriteLine("test 1");
        }
        Console.WriteLine("test");
    }
}
