namespace PermCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var array = new int[] { 1,2,3};
            var test = solution(array);
        }

        public static int solution(int[] A)
        {
            if(A.Length == 0 || A.Length == 1 && A[0] != 1) 
            { 
                return 0;
            }
            else
            {
                var sorted = A.OrderBy(x => x).ToArray();

                for(int i = 0; i< sorted.Length; i++)
                {
                    var n2 = sorted[0];
                    var n = sorted[i];

                    if(i > 0)
                    {
                        if(n2 + i != n)
                        {
                            return 0;
                        }
                    }
                }
                return 1;
            }
        }

    }
}