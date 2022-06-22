//Ask user for name and number

Console.WriteLine("Howdy partner. What is your name?:");
string name = Console.ReadLine();

Console.WriteLine("Please enter a number between 1 and 100: ");
int number = int.Parse(Console.ReadLine());


    //take different actions and give output
    if (number % 2 == 1 && number < 60)
    {
        Console.WriteLine(name + ", " + number + " is odd and less than 60.");
    }
    else if (number % 2 == 0 && number >= 2 && number <= 24)
    {
        Console.WriteLine(name + ", this number is even and less than 25");
    }
    else if (number % 2 == 0 && number >= 26 && number <= 60)
    {
        Console.WriteLine(name + ", this number is even and greater than 60.");
    }
    else if (number % 2 == 1 && number > 60)
    {
        Console.WriteLine(name + ", this number is odd and greater than 60.");
    }
