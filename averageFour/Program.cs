//
int numbOne;
int numbTwo;
int numbThree;
int numbFour;
int numbSum;
int numbAvg;

// Inputs

Console.Write("Please enter the first number: ");
numbOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
numbTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the third number: ");
numbThree = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the fourth number: ");
numbFour = Convert.ToInt32(Console.ReadLine());


// Operations

numbSum = numbOne + numbTwo + numbThree + numbFour;

numbAvg = numbSum / 4;


// Printing 

Console.WriteLine($"The average of {numbOne}, {numbTwo}, {numbThree}, {numbFour} is: {numbAvg}");