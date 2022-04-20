// See https://aka.ms/new-console-template for more information
class Program
{
    public Int32[] Recast2Ints (List<String> sharesUSortedStr)
    {
        Int32[] result = new Int32[sharesUSortedStr.Count];
        int tempCounter = 0;
        foreach (String i in sharesUSortedStr)
        {
            
            result[tempCounter] = Int32.Parse(i);
            tempCounter++;
        }
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

        String [] strShare1_256 = System.IO.File.ReadAllLines(@"C:\Users\samue\OneDrive - University of Lincoln\Lectures\AlgoComplex-Y1\Assess-1\Share_1_256.txt");
        Int32[] shares1256USortedStr = Recast2Ints(strShare1_256.ToList());


        Console.WriteLine();
        Console.ReadKey();
    }
}