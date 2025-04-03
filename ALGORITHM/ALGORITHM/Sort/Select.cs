namespace ALGORITHM;

public class Select
{
    public static void SelectionSort(int[] numberArray)
    {
        for (int i = 0; i < numberArray.Length; i++)
        {
            for (int j = 1; j < numberArray.Length-1; j++)
            {
                int temp;
                if (numberArray[i] > numberArray[j])
                {
                    temp = numberArray[i];
                    numberArray[i] = numberArray[j];
                    numberArray[j] = temp;
                }
            }
        }

        for (int i = 0; i < numberArray.Length; i++)
        {
            Console.WriteLine(numberArray[i]);
        }
        
    }
}