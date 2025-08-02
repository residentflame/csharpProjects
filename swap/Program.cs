// Variable declarations
int firstNum;
int secondNum;
int temp;

// Prompt for the 1st number:
Console.Write("Input the First Number: ");
firstNum = Convert.ToInt32(Console.ReadLine());

// Prompt for the 2nd number:
Console.Write("Input the Second Number: ");
secondNum = Convert.ToInt32(Console.ReadLine());

// Conversions
temp = firstNum;
firstNum = secondNum;
secondNum = temp;
Console.WriteLine($"First Number: {firstNum}, Second Number: {secondNum}.");