using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CharacterReordering
{
    public static void Main(string[] args)
    {
        char[] input = "ABCDEFGHIJ".ToCharArray();
        int ordering = 7;
        char[] output = orderByAlgorithm(input, ordering);
        Console.WriteLine("\n" + new string(output) + "\n");  // Expected output format

        // Wait for user input before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }

    public static char[] orderByAlgorithm(char[] input, int ordering)
    {
        List<char> inputList = new List<char>(input);
        List<char> outputList = new List<char>();

        int currentIndex = 0;
        int nonHyphenCount = 0;

        while (inputList.Count > 0)
        {
            currentIndex = (currentIndex + ordering - 1) % inputList.Count;
            outputList.Add(inputList[currentIndex]);
            inputList.RemoveAt(currentIndex);
            nonHyphenCount++;

            if (nonHyphenCount % 3 == 0 && inputList.Count > 0)
            {
                outputList.Add('-');
            }
        }

        return outputList.ToArray();
    }
}
