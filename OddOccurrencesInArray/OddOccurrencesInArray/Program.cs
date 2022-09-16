namespace OddOccurrencesInArray 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 42 };
            solution(A);
        }

        public static int solution(int[] A)
        {
            if (A.Length < 1)
            {
                return 0;
            }
            else if (A.Length == 1)
            {
                return (A[0]);
            }
            else
            {
                for (var i = 0; i < A.Length; i++)
                {
                    var num = A.Count(s => s == A[i]);

                    if (num == 1)
                    {
                        return (A[i]);

                    }
                }
            }
            return 0;
        }
    }

}
