namespace ALGORITHM;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] randomArr = new int[5];
        
        for (int i = 0; i < 5; i++)
        {
            randomArr[i] = random.Next(9000);
        }
        
        Select.SelectionSort(randomArr);
    }
}