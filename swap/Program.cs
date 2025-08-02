// Variable declarations
int firstNum;
int secondNum;
int temp;
int firstSwap;

Console.Write("Input the First Number ");
firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Second Number: ");
secondNum = Convert.ToInt32(Console.ReadLine());

temp = firstNum;
firstNum = secondNum;
secondNum = temp;
Console.WriteLine($"First Number: {firstNum}, Second Number: {secondNum}.");