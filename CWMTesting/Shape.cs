using System.Drawing;
using MultiTarget;

namespace CWMTesting;

internal class Shape
{
    public Point Pivot { set; get; }

    public void Method1(string s)
    {
        //throw new NotImplementedException();
    }


    public class Foo
    {
        public string Prop { get; set; }
    }

    public class Bar
    {
        public void meth()
        {
            var f = new Foo
            {
                Prop = ""
            };
        }
    }

    private interface IA
    {
        void M(string superTractor2000);
    }

    private interface IB : IA
    {

    }

    internal class SortablePropertyDescriptorXxx : IComparable
    {
        protected internal PropertyDescriptor _propertyDescriptor;
        protected int _sortOrder;

        private GeneralSettings generalSettings;

        public SortablePropertyDescriptorXxx(int sortOrder, PropertyDescriptor propertyDescriptor)
        {
            _sortOrder = sortOrder;
            _propertyDescriptor = propertyDescriptor;
        }


        public SortablePropertyDescriptorXxx(bool a) : this(1, null)
        {
            if (a)
            {
            }
            else
            {
                Console.WriteLine("");
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        private void Test11()
        {
            var multiShared1 = new MultiShared1();
            multiShared1.Method4();
        }

        private void Test(List<string> list)
        {
            list.Where(x => x == string.Empty).FirstOrDefault();
        }

        internal class PropertyDescriptor
        {
        }
    }
}

internal class GeneralSettings
{
}