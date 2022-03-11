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
