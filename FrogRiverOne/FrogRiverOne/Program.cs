namespace FrogRiverOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var array = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
             var test = solution(5,array);
        }

        public static int solution(int X, int[] A)
        {

            if (A.Length == 0 ||  X == 0 || X > 100000 || A.Length < X )
            {
                return -1;
            }
            if (A.Length != A.Distinct().Count() && A.Length != 1 && A.Length < X)
            {
                return -1;
            }

            else if (A.Length == 1  )
            {
                return 0;
            }

            return X + 1;
        }

    }
}