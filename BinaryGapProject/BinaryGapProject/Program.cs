namespace BinaryGapProject 
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to count its largest binary gap.");
            var binaryRepre = Console.ReadLine();
            if(binaryRepre != null)
            {
                Console.WriteLine(ComputeLargestBinaryGap(Convert.ToString(binaryRepre,2);));
            }
            else
            {
                Console.WriteLine("Over");
            }
        }

        private static int ComputeLargestBinaryGap(string number)
        {

            int count = 0;
            int countMax = 0;

            for (int i = 0; i < number.Length; i++)
            {

                if (number[i] == '0')
                {
                    count++;
                }
                else
                {
                    countMax = Math.Max(countMax, count);
                    count = 0;
                }
            }

            return countMax;
        }
    }
}
