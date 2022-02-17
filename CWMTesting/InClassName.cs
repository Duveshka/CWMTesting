namespace CWMTesting;

public class InClassName
{
    private InClassName(string s)
    {
        S = s;
    }

    public string S { get; }

    public static InClassName CreateInstance(string s)
    {
        return new InClassName(s);
    }
}

public class Location
{
    public string locationName; //TODO ShowUsages

    public Location(string name) => Name = name;

    public string Name
    {
        get => locationName;
        set 
            => locationName = value;
    }

    public async Task<Location> Name2 ()
    {
        Location i = null;
        return i;
    }
}

public class TestForLocation
{

    public Location a = new Location("fdwe");

    public void Test()
    {
        a.locationName = null;
        a.Name2();
    }
}