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
        int[] arry1 = Recast2Ints(shares1_256);
        Console.WriteLine(arry1);

        Console.WriteLine();
        Console.ReadKey();
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

    public static int[] QuickSort(int[] sharesData)
    {
        




    }
}