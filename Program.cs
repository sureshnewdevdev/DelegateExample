using System.ComponentModel;

namespace ConsoleApp1
{
    public class Person
    {
        public int x { get; set; }
        public MyDelegateAdd MyDelegateAdd { get; set; }
    }

    public delegate int MyDelegateAdd(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegateAdd myDelegateAdd = new MyDelegateAdd(Add);

            myDelegateAdd(10, 20);
            int x = 10; // --- Memory allocated and value assigned

            int y = myDelegateAdd(100,900);

        }

        private static int AddTwoNUmbers(int x, int y)
        {
            return x + y;
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
