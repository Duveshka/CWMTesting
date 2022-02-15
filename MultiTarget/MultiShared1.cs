using System;

namespace MultiTarget
{
    public class testfe
    {
        public string stringa { get; set; }
        public string LinkedDestinationFramework1 { get; set; }
    }
    public interface IMultiShared1 //TODO GoToImplementation -> go to "MultiShared1"
    {
    }

    public class MultiShared1 : IMultiShared1
    {
        private void InnerMethod1()
        {
            var t = 123;

            Console.WriteLine(t);

            Console.WriteLine();
        }

        public string Method1()
        {
            throw new NotImplementedException();
        }

        public string Method2()
        {
            throw new NotImplementedException();
        }

        public void Method3()
        {
            throw new NotImplementedException();
        }

        public void Method31()
        {
            throw new NotImplementedException();
        }

        public void Method32()
        {
            throw new NotImplementedException();
        }

        public void Method33()
        {
            throw new NotImplementedException();
        }

        public void Method34()
        {
            throw new NotImplementedException();
        }

        public void Method35()
        {
            throw new NotImplementedException();
        }

        public void Method36()
        {
            throw new NotImplementedException();
        }

        public void Method37()
        {
            throw new NotImplementedException();
        }

        public string Method4()
        {
            throw new NotImplementedException();
        }
    }
}