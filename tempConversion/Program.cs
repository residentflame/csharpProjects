// 
int celsius;
double kelvin;
double fahrenheit;

Console.Write("Enter the amount of celsius: ");
celsius = Convert.ToInt32(Console.ReadLine());

kelvin = Math.Round(celsius + 273.15);
fahrenheit = Math.Round((celsius * 1.8) + 32);
Console.WriteLine($"Kelvin: {kelvin} ");
Console.WriteLine($"Fahrenheit: {fahrenheit} ");


