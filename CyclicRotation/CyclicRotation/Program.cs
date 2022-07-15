namespace CyclicRotation
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World lets moves some elemets in arrays up!");
            int[] items = new[] { 3, 8, 9, 7, 6 };
            int rounds = 3;
            Solution(items, rounds);
        }

        public static void Solution(int[] A, int K)
        {
            var lenght = A.Length;
            for (int i = 0; i < K; i++)
            {
                int numToMove = A[lenght - 1];
                int newIndex = 0;
                int oldIndex = A.Length - 1;
               
                Array.Copy(A, 0, A, newIndex + 1, oldIndex - newIndex);
                A[0] = numToMove;
            }
        }
    }
}