namespace MissingInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 4, 5, 6, 2 };
            var test = solution( array);
        }

        public static int solution(int[] A)
        {
            if (A.Length == 0 || A.Length == 1 && (A[0] > 1 || A[0] == 0))
            {
                return 1;
            }
            // if negative
            if (A[0] < 0 && A[0] == -1)
            {
                return 1;
            }
            else
            {
                var orderArr = A.OrderBy(x => x).Distinct().ToArray();
                var lenght = orderArr.Length - 1;
                var lastNum = orderArr[lenght];
                var firstNum = orderArr[0];

                if (firstNum != 1)
                {
                    return 1;
                }

                if (lastNum == orderArr.Length)
                {
                    return lastNum + 1;
                }

                for (var i = 0; i < orderArr.Length; i++)
                {
                    if (orderArr[i] == firstNum)
                    {
                        firstNum++;
                    }

                    else if (orderArr[i] != firstNum)
                    {
                        return firstNum;
                    }
                }

            }
            return 0;
        }
    }
}