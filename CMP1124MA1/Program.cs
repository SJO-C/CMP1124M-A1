// See https://aka.ms/new-console-template for more information
class Program
{
    public Int32[] Recast2Ints (List<String> sharesUSortedstr)
    {
        Int32[] result = new Int32[sharesUSortedstr.Count];
        int tempCounter = 0;
        foreach (String i in sharesUSortedstr)
        {
            
            result[tempCounter] = Int32.Parse(i);
            tempCounter++;
        }
    }
    
    static void Main()
    {
        Console.WriteLine("Shares_1_256");
         String[] strShare1256 = System.IO.File.ReadAllLines(@"C:\Users\samue\OneDrive - University of Lincoln\Lectures\AlgoComplex-Y1\Assess-1\Share_1_256.txt");
        foreach (String str in strShare1256)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("Shares_2_256");
        String[] strShare2256 = System.IO.File.ReadAllLines(@"C:\Users\samue\OneDrive - University of Lincoln\Lectures\AlgoComplex-Y1\Assess-1\Share_2_256.txt");
        foreach (String str in strShare1256)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("Shares_3_256");
        String[] strShare3256 = System.IO.File.ReadAllLines(@"C:\Users\samue\OneDrive - University of Lincoln\Lectures\AlgoComplex-Y1\Assess-1\Share_3_256.txt");
        foreach (String str in strShare1256)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}