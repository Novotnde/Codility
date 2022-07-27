namespace OddOccurrencesInArray 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 2,9, 2,2,2 };

       
            if(nums.Length <= 1)
            {
                Console.WriteLine("0");
            }
            else if(nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                for (var i = 0; i < nums.Length; i++)
                {
                    var num = nums.Count(s => s == nums[i]);

                    if (num == 1)
                    {
                        Console.WriteLine(nums[i]);

                    }
                }
            }
          
        }
    }

}