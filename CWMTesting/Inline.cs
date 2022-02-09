using System.Drawing;

namespace CWMTesting;

public class Inline
{
    
}
//TODO Inline field
class Shape
{
    private const string ErrorMessage = "Something has failed";
    public void Draw(string s)
    {
        try { /*draw*/ }
        catch (Exception e)
        {
            Console.WriteLine("{0} : {1}", ErrorMessage, e);
        }
    }
}

//TODO Inline method

abstract class Shape2
{
    public void Draw()
    {
        try { /*draw*/ }
        catch (Exception e)
        {
            LogError(e);
        }
    }
    private static void LogError(Exception e)
    {
        File.WriteAllText(@"c:\Errors\Exception.txt", e.ToString());
    }
}

//TODO inline parameter pi
public class InlineParameter
{
    private double AreaOfCircle(double rad, double pi)
    {
        return pi * rad * rad;
    }

    public void Test()
    {
        var area = AreaOfCircle(10, Math.PI);
    }
    
    //TODO inline variable

    static string ReversedString(string input)
    {
        var chars = input.ToCharArray();
        Array.Reverse(chars);
        var reversed = new string(chars);
        return reversed;
    }
}

