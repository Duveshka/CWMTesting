namespace CWMTesting;

public class ReferencedMultipleShared_ReSharper2
{
    public string S { get; set; }

    public string S1 { get; set; }

    public string S2 { get; set; }

    public string S3 { get; set; }

    private void t()
    {
        var referencedMultipleSharedReSharper1Renamed = new ReferencedMultipleShared_ReSharper1_Renamed();
        referencedMultipleSharedReSharper1Renamed.Method1();

        var tt = 123;
        Console.WriteLine(tt);

        // aaaaaaaaaaaaaaa
    }


    public static string MehtodToMove()
    {
        var mehtodToMove = "null";

        var someRenamedMethod = SomeRenamedMethod(); //comment


        //meth
        return mehtodToMove;
    }

    private static string SomeRenamedMethod()
    {
        Console.WriteLine("test");
        return null;
    }
}