// See https://aka.ms/new-console-template for more information
using System.Linq;

class Program
{
    public int[] Recast2Ints (List <string> sharesUSortedStr)
    {
        int[] result = new int[] { };
        List<int> list = sharesUSortedStr.ConvertAll<int>(s => Int32.Parse(s));

        //for (int i = 0; i < sharesUSortedStr.Length; i++)
        //{
        //    result[i] = Int32.Parse(sharesUSortedStr[i]);
        //}

        return result;
    }
    
    static void Main()
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

        List <string> shares1_256 = System.IO.File.ReadAllLines(@"./shares_1_256.txt")


        Console.WriteLine();
        Console.ReadKey();
    }
}