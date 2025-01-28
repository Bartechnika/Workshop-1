using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

internal class Program
{
    // Task 1
    private static void Main(string[] args)
    {
        int[] randomNumbers = GenerateRandomInts(1, 1000, 100);

        int[] freq = ComputeHistogram(randomNumbers);
        DisplayHistogram(freq);

        Console.WriteLine($"Array length : {randomNumbers.Length}");
        int sum = ComputeSum(randomNumbers);
        Console.WriteLine($"Sum: {sum}");

        int[] sortedNumbers = InsertionSort(randomNumbers);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Task 2
    private static int[] GenerateRandomInts(int min, int max, int len)
    {
        int[] arr = new int[len];
        Random rnd = new Random();
        for (int i = 0; i < len; i++)
        {
            arr[i] = rnd.Next(min, max);
        }

        return arr;
    }

    // Task 3
    private static int ComputeSum(int[] arr)
    {
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        return sum;
    }

    // Task 4
    private static int[] ComputeHistogram(int[] arr)
    {
        int binCount = 27;
        int binSize = (1000-1) / binCount;
        int[] bins = new int[binCount];
        foreach(int i in arr)
        {
            int index = (i - arr.Min()) / (binSize);
            bins[index]++;
        }

        return bins;
    }

    private static void DisplayHistogram(int[] arr)
    {
        int count = 0;
        foreach(int i in arr)
        {
            string height = new string('-', i);
            Console.WriteLine($"{count+1} : {height}");
            count += 1;
        }
    }

    // Task 5
    private static int[] InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                }
            }
        }

        return arr;
    }
}