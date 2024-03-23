namespace APBD_1;

public class MathOperations
{

    public MathOperations()
    {
        
    }
    
    public static void Main(string[] args)
    {
        
    }
    
    public static float count(int[] ints)
    {
        float counter = 0;
        foreach (var digit in ints)
        {
            counter += digit;
        }

        return counter/ints.Length;
    }

    public static int max(int[] ints)
    {
        if (ints.Length == 0)
        {
            Console.WriteLine("Provided array is empty. Returned '-1'");
            return -1;
        }
        else if (ints.Length == 1)
        {
            return ints[0];
        }
        else
        {
            int maxValue = ints[0];
            foreach (var digit in ints)
            {
                if (digit > maxValue)
                {
                    maxValue = digit;
                }
            }
            return maxValue;
        }
    }
    
}