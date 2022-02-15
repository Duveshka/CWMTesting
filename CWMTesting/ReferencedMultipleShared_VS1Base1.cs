namespace CWMTesting;

internal class ReferencedMultipleShared_VS1Base1
{
    public string Name1 { get; set; }
    public string Name2_Renamed { get; set; }

    public void Method1()
    {
        Method2(1);
    }

    public void Method2(int parameter212)
    {
        foreach (var s
                 in new List<string>()) Console.WriteLine(s);

        NewMethod();
    }

    private static void NewMethod()
    {
        var shape = new Shape();
        shape.Method1("");
        var reSharper4 = new ReferencedMultipleShared_ReSharper4_Renamed();
        reSharper4.Method2(new InClassName1(InClassName.CreateInstance(null)));
    }
}

public class InClassName1
{
    public InClassName1(InClassName inClassName)
    {
        InClassName = inClassName;
    }

    public InClassName InClassName { get; }
}

public class ReferencedMultipleShared_ReSharper4_Renamed
{
    public void Method1()
    {
        var s = "";
    }

    public void Method2(InClassName1 inClassName1)
    {
    }
}