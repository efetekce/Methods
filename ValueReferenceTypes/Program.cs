namespace ValueReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int n1 = 10;
            int n2 = 30;
            n1 = n2;
            n2 = 1;
            Console.WriteLine(n1);
            // int, decimal, float, double, bool are primitive value types.

            // array, class, interface are reference types.
            int[] a1 = new int[] { 10, 20, 30 };
            int[] a2 = new int[] { 100, 200, 300 };
            a1 = a2;
            a2[0] = 999;
            foreach (int element in a1)
            {
                Console.WriteLine(element);
            }
        }
    }
}