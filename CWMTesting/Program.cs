
using CWMTesting;
using NewFolder4;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("dada");
Console.WriteLine("fwaf");
var f = 500;
var a = new Class5();
a.Test();

var b = new Class12();
b.Test2();

var c = new Testik();
c.Test2();

var part1 = new Partial1();
var part2 = new Partial1();
part1.Inter1(); //TODO GoToDeclaration on "Inter1" -> go to partial class "Partial1"
part2.Inter();
part2.Test();

var class4 = new Class4();
class4.Test();

var ReferencedMultipleSharedVs1 = new ReferencedMultipleShared_VS1();
ReferencedMultipleSharedVs1.Method2(1);

ReferencedMultipleSharedVs1.Name2_Renamed = "Jane Doe";

var moveStaticMethod1 = ReferencedMultipleShared_VS1.MoveStaticMethod1(1);

var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
var reSharper2 = new ReferencedMultipleShared_ReSharper2();
var reSharper2_1 = new ReferencedMultipleShared_ReSharper2();
var reSharper4 = new ReferencedMultipleShared_ReSharper4_Renamed();
reSharper4.Method2(null); //TODO GoToImplementation -> to the declaration of this method
reSharper4.Method1();

internal class MyClass : IInterface1
{
    public string Name { get; set; }
   
    public void huf(string a, string b)
    {
        Console.WriteLine(a+a);
        
        Console.WriteLine("fesfefesffesfs");
        
        Console.WriteLine();
        string s = "vlalfe";
        int[] array;
    }

    public void gf()
    {
        string a1 = null;
        string b1 = null;
        huf(a1,b1);
    }
}

public interface IInterface1
{
    public class ForIfWhile
    {
        public void Foo(string input)
        {
            
        }
        public void a()
        {
            int a = 5;

            //TODO if, while, for statements here
            if (a == 6)
            {

            }
            else
            {
                a += 1;
            }

            while (a == 6)
            {
                a += 10;
                break;
            }

            for (var i = 1; i<100; i++ )
            {
                i += 10;
            }
        }
    }
}
