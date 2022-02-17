namespace CWMTesting;

public class Class3 : Class6 //TODO GoToimplementation -> tooltip with not found
{
    private void Test()
    {
        var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
    }
}

public interface IPub //TODO GoToImplementation -> popup with three classes //TODO ShowUsages
{
}

public interface IPub2 : IPub //TODO GoToBase on "IPub2" -> go to IPub
{
}

public interface IPub3 : IPub
{
}
//TODO GoToBase on "Iasb" -> show tooltip
public interface ISab //TODO GoToimplementation -> tooltip with not found 
{
}

public interface ISab2 : ISab
{
}

public class A : IPub
{
}