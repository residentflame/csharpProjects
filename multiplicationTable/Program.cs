Console.Write("Enter a number: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"This is the multiplication table of {userNum}\n");
        int product;
        for (int j =1; j <= 10; j++)
        {
            product = userNum * j;
            Console.WriteLine($"{userNum} x {j}: {product}");
        }