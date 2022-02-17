namespace CWMTesting;

public partial class Partial1 : Interface1 //TODO GoToDerived on "Interface1"
{
    public void Inter()
    {
        Console.WriteLine("Partial");
    }
    public void Test()  //TODO GoToDerived -> tooltip not found
    {
        var a = new Partial1();
        MethodForTest(a);
    }

    public void MethodForTest(Interface1 test)
    {
        test.Inter();
    }
}
class Class17 : IPub
{
}

class Test171 : IPub
{

}