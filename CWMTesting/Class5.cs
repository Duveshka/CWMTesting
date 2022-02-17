using NewFolder4;

namespace CWMTesting
{
    public class Class5 : Class6 //TODO GoToBase on "Class6" -> open Class6.cs
    {
        public void Test()
        {
            var reSharper1 = new ReferencedMultipleShared_ReSharper1_Renamed();
            var a = new A5(); //TODO GoToBase on "A5" -> go to IInterface
            a.Test();
            MethodForTest(a);
        }

        public void MethodForTest (IInterface test)
        {
            test.Test(); //TODO GoToDeclaration on "Test" -> go to IInterface  AND while debugging -> "Test" in class "A5" 
            Console.WriteLine(" Test ");
        }
    }
}