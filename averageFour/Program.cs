int count = 0;
int sum = 0;
string userinput;
int[] numbersArray = new int[100];


while (true)
{
    Console.WriteLine("Please enter a number (Or type '0' to exit): ");
    userinput = Console.ReadLine();

    // This block of code checks if the user inputs 0
    if (int.TryParse(userinput, out int number))
    {
        if (number == 0)
        {
            break;
        }
        // Checks if the count value is less than 100 and adds value to the numbers array
        if (count < 100)
        {
            numbersArray[count] = number;
            sum += number;
            count++;
        }
        else
        {
            Console.WriteLine("Maximum of 100 numbers reached");
        }

    }
}
// Math calulations
if (count > 0)
{
    double average = (double)sum / count;
    Console.WriteLine($"The average is: {average}");
}
else
{
    Console.WriteLine("No numbers were entered. :(");
}


