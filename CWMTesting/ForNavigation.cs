namespace NewFolder4;

public interface IInterface //TODO GoToDerived
{
    void Test();
}

public class A5 : IInterface
{
    public void Test()
    {
        var t = 1;
        Console.WriteLine("Tadada"); //TODO GoToImplementation -> to the method in Console.cs 
    }
}

public class A6 : IInterface //TODO GoToBase on "A6" -> Go to IInterface
{
    public void Test() //TODO ShowUsages
    {
        throw new NotImplementedException();
    }
}

public class Testik
{
    public void MethodForTest(IInterface test)
    {
        test.Test(); //TODO GoToDeclaration on "Test" -> go to IInterface AND while debugging -> "Test" in class "A5" 
    }

    public void Test2()
    {
        var a = new A5();
        MethodForTest(a); //TODO GoToType -> open void
    }
}
abstract class AbsCla  //TODO GoToimplementation -> tooltip with not found
{
    public abstract int fe();
}