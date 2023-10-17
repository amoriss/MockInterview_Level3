namespace MockInterview_Level3;

internal class Program
{
    public static int[] FindTwoHighest(int[] arr)
    {
        var result = new int[2] { 0, 0 };
        // code goes here  
        return result;

    }
    static void Main()
    {
        var testResult = FindTwoHighest(new int[] { 1, 2, 2, 2, 3, 3 });
        PrintTest(testResult, "[3, 2]");
        testResult = FindTwoHighest(new int[] { 3, 4, 5, 2, 4, 5, 10 });
        PrintTest(testResult, "[10, 5]");
        testResult = FindTwoHighest(new int[] { -1, 0, 3, 0, 3, 0 });
        PrintTest(testResult, "[3, 0]");
        testResult = FindTwoHighest(new int[] { 1, 2, 2, 2, 3, 3 });
        PrintTest(testResult, "[3, 2]");
    }

    public static void PrintTest(int[] arr, string expected)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i <= arr.Length - 2)
            {
                Console.Write(", ");
            }
        }
        Console.Write("]   Expected: ");
        Console.WriteLine(expected);
    }
}
