namespace WBTreeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Test1();
        }

        public static void Test1()
        {
            Random rnd = new Random();

            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(rnd.Next());
            }

            Tree a = new Tree();
            a.AddRange(list);
            Console.WriteLine("Height {0}", a.Height());
            Console.WriteLine("Balance {0}", a.BalanceCount());
            a.InOrder();
            a.Clear();
        }
    }
}
