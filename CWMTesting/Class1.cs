namespace CWMTesting;

public class Class1 //TODO GoToImplementation -> open "Class4" 
{
    public void Test()
    {
        var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
        reSharper1.Method1();
    }
}

public class Class12
{
    public void Test2()
    {
        var a = new Request();
        MethodForTest(a);
    }

    public void MethodForTest(IDisposable test)
    {
        test.Dispose(); //TODO GoToDeclaration on "Dispose" -> Go to IDisposable AND while debugging ->Navigate to method 'Dispose" in class "Request"
    }

    private void Test(int number, UserService serviceProvider)
    {
        using var request = new Request();

        request.Add();

        static void Test2(int other)
        {
            Console.WriteLine(other);
        }

        serviceProvider.GetRequiredService();

        var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
    }
}

internal class Request : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("netadada");
    }

    public void Add()
    {
        throw new NotImplementedException();
    }
}

internal class UserService
{
}

public static class ServiceProviderExtensions
{
    public static void GetRequiredService<T>(this T serviceProvider)
    {
    }
}