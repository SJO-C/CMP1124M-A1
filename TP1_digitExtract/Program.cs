// See https://aka.ms/new-console-template for more information

List<int> validCode = new();
int num1 = 147981;
int digit = new();
while (num1 >= 1)
{
    digit = num1 % 10;
    validCode.Add(digit);
    num1 = num1 / 10;
}


foreach(int i in validCode)
{
    Console.Write(i + ",");
}
