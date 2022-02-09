namespace CWMTesting;

public class CodeCompletion
{
    public enum Items
    {
        First,
        Second,
        Third,
        blabla
    }

    public string A { get; set; }
    public string B { get; set; }
    public string K { get; set; }

    public List<string> list { get; set; }
    public string S { get; set; }

    public void Te()
    {
        list.Add("item");
        var a = Items.Second;
    }

    public static void AddItem()
    {
    }

    public bool testReturn()
    {
        return false;
    }
}

public partial class Partclass
{
    public void recurs()
    {
        recurs();
    }
}

public partial class Partclass
{
}