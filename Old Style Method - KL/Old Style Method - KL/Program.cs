namespace Old_Style_Method___KL
{
    internal class Program
    {
        // Field or instance variable
        static int myAddResult;
        static void Main(string[] args)
        {
            myAddResult = AddTwoValuesSecond(5, 8);
            Console.WriteLine($"Result of second adding example is {myAddResult}");

            Console.ReadKey();
        }

        static int AddTwoValuesSecond(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }
    }
}