// See https://aka.ms/new-console-template for more information
using System.Linq;

class Program
{
    
    
    public static void Main()
    {
        //Console.WriteLine("Shares_1_256");
        // String[] strShare1256 = System.IO.File.ReadAllLines(@"C:\Users\samue\OneDrive - University of Lincoln\Lectures\AlgoComplex-Y1\Assess-1\Share_1_256.txt");
        //foreach (String str in strShare1256)
        //{
        //    Console.WriteLine(str);
        //}
        //Console.WriteLine("Shares_2_256");
        //String[] strShare2256 = System.IO.File.ReadAllLines(@"C:\Users\samue\OneDrive - University of Lincoln\Lectures\AlgoComplex-Y1\Assess-1\Share_2_256.txt");
        //foreach (String str in strShare1256)
        //{
        //    Console.WriteLine(str);
        //}
        //Console.WriteLine("Shares_3_256");
        //String[] strShare3256 = System.IO.File.ReadAllLines(@"C:\Users\samue\OneDrive - University of Lincoln\Lectures\AlgoComplex-Y1\Assess-1\Share_3_256.txt");
        //foreach (String str in strShare1256)
        //{
        //    Console.WriteLine(str);
        //}


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


    public static int[] QuickSort(int[] sharesData)
    {
        int stepsTaken = 0;
        int sortPoint1 = 1;
        int sortPoint2 = sharesData.Length - 1;
        bool sorted = false;
        int tempVar;
        while (sorted == false)
        {
            stepsTaken++;

            int pivot = sharesData[0];
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
        }

        return sharesData;


    }
}