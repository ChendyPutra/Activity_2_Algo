





namespace Quicsort
{
    class Program
    {
        private int[]arr = new int[20];
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
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j)
                {
                    swap(i, j);
                    mov_count++;
                }
            }

            if (low < j)
            {
                swap(low, j);
                mov_count++;
            }

            q_sort(low, j - 1);

            q_sort(j + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n=====================");
            Console.WriteLine(" Sorted Array Elements ");
            Console.WriteLine("\n=====================");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of Comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of Data Movements: " + cmp_count);
        }
        int getsize()
        {
            return (n);
        }
    }
}