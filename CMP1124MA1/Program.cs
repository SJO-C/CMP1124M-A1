// See https://aka.ms/new-console-template for more information
using System.Linq;

class Program
{
    
    
    public static void Main()
    {
        

        string[] shares1_256 = System.IO.File.ReadAllLines(@"./Share_1_256.txt");
        string[] shares2_256 = System.IO.File.ReadAllLines(@"./Share_2_256.txt");
        string[] shares3_256 = System.IO.File.ReadAllLines(@"./Share_3_256.txt");
        int[] arry1 = Recast2Ints(shares1_256);
        int[] arry2 = Recast2Ints(shares2_256);
        int[] arry3 = Recast2Ints(shares3_256);
        Console.WriteLine("The first values of each unsorted array:");
        //Console.WriteLine(arry1[255] + " " + arry2[255] + " " + arry2[255] + " ");
        Console.Write("Select the array you want to search: 1, 2 or 3 ONLY.\n> ");
        string strUserChoice = Console.ReadLine();
        int intUserChoice = 0;
        try
        {
             intUserChoice = System.Convert.ToInt32(strUserChoice);
        }
        catch (ArgumentNullException)
        {
            ;
            
        }

        int[] arryChoice = new int[258];
        
        if (intUserChoice == 1)
        {
            arryChoice = arry1;
        }
        else if (intUserChoice == 2)
        {
            arryChoice = arry2;
        }
        else if (intUserChoice == 3)
        {
            arryChoice = arry3;
        }
        else
        {
            ;
        }

        Console.WriteLine("For BubbleSort press B, for a QuickSort that doesn't work in the slightest, press Q.");

        ConsoleKeyInfo m = Console.ReadKey();
        int[] sortedD = arryChoice;
        if (m.Key == ConsoleKey.B)
        {
            sortedD = BubbleSort(arryChoice);
        }
        else if (m.Key == ConsoleKey.Q)
        {
            sortedD = QuickSort(arryChoice);
        }
        else { Environment.Exit(0); }

        for (int D = 0; D <= 256; D = D + 10)
        {
            Console.WriteLine(sortedD[D]);
        }
        int[] revSortedD = new int[256];
        for (int E = sortedD.Length - 1; E >= 0; E--)
        {
            revSortedD[E] = sortedD[E];
        }
        Console.WriteLine("In descending order:");
        for (int F = 0; F <= 256; F = F + 10)
        {
            Console.WriteLine(revSortedD[F]);
        }
        //Console.WriteLine(arryChoice);
        Console.Write("Enter your number to search for using a Linear Search.> ");
        int intUserFind = System.Convert.ToInt32(Console.ReadLine());
        int findWlLinear = LinearSearch(intUserFind, arryChoice);
        //Console.Beep();
        

        Console.WriteLine();
        //Console.ReadKey();
    }

    public static int[] Recast2Ints(string[] sharesUSortedStr)
    {
        int[] result = Array.ConvertAll(sharesUSortedStr, (s) => Int32.Parse(s));

        //List<int> list = sharesUSortedStr.ConvertAll<int>(s => Int32.Parse(s));

        //for (int i = 0; i < sharesUSortedStr.Length; i++)
        //{
        //    result[i] = Int32.Parse(sharesUSortedStr[i]);
        //}

        return result;
    }

    public static int LinearSearch(int searchDatum, int[] arraySearched)
    {
        int stepsTaken = 0;
        int[] posLocates = new int[258];
        

        foreach (int i in arraySearched)
        {
            //Console.WriteLine(i);
            
            if (searchDatum == i)
            {
                Console.WriteLine("Found in List.");
                posLocates[stepsTaken] = 1; 
            }
            else
            {
                //Console.WriteLine("Not Found.");
                posLocates[stepsTaken] = 0;
            }
            stepsTaken = stepsTaken + 1;

            //Console.WriteLine(stepsTaken);
        }
        //foreach (int i in posLocates)
        //{
        //    Console.WriteLine(i);
        //}

        int foundPoss = posLocates.Where(p => p == 1).Count();
        Console.WriteLine("Found in " + foundPoss + " location(s).");

        bool posFinders = false;
        int[] listOfPos;

        while (posFinders == false)
        {
            
        }

        return 1;
    }

    public static int[] BubbleSort(int[] sharesData)
    {
        int stepsTaKen = 0;
        int arryLen = sharesData.Length;
        for (int iter2 = 0; iter2 < arryLen -1; iter2++)
        {
            for (int iter3 = 0; iter3 < arryLen - iter2 - 1; iter2++)
            {
                if (sharesData[iter3] > sharesData[iter3 + 1])
                {
                    stepsTaKen++;
                    int tempVar = sharesData[iter3];
                    sharesData[iter3] = sharesData[iter3 + 1];
                    sharesData[iter3 + 1] = tempVar;
                }
            }
        }
        Console.WriteLine("This took " + stepsTaKen + " to complete.");
        foreach (int k in sharesData)
        {
            Console.WriteLine(k);
        }
        return sharesData;
    }

    public static int[] QuickSort(int[] sharesData)
    {
        int stepsTaken = 0;
        int sortPoint1 = 0;
        int iter = 0;
        int sortPoint2 = sharesData.Length -1;
        bool sorted = false;
        int tempVar;
        int pivot = sharesData[0];
        while (sorted == false)
        {
            stepsTaken++;
            pivot = sharesData[iter];
            
            if (sharesData[sortPoint1] > sharesData[sortPoint2])
            {
                tempVar = sharesData[sortPoint2];
                sharesData[sortPoint2] = sharesData[sortPoint1];
                sharesData[sortPoint1] = tempVar;
            }
            else { sorted = true; }
            sortPoint1++;
            sortPoint2--;
            sharesData.Append(stepsTaken);
            return sharesData;
            iter++;
        }
        foreach (int k in sharesData)
        {
            Console.WriteLine(k);
        }

        return sharesData;


    }
}