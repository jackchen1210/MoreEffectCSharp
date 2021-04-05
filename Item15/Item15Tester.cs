namespace Item15
{
    public class Item15Tester
    {
        public void Main()
        {
            Test test = new Test2();
            //test.Tester();
        }
    }

    internal interface ITestInterface
    {
        void Tester();
    }

    internal class Test : ITestInterface
    {
        void ITestInterface.Tester()
        {
            System.Console.WriteLine("Tester");
        }
    }

    internal class Test2 : Test
    {

    }
}