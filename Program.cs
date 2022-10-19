





namespace Quicsort
{
    class Program
    {
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter The Number Of Elements In The Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can Have Maximum 20 Elements \n");
            }
            Console.WriteLine("\n==================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n==================");

            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
    }
}