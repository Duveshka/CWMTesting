namespace CWMTesting;

public class Converting
{
    
}
abstract class Abstract
{

}

public static class TestForExtensionsToStatic
{
    public static void DoSomething(this string s)
    {
    
    }
    private static void Test(string str)
    {
        str.DoSomething();
    }  
}

class PropertyToMethod
{
    public string Faculty { set; get; }
}

