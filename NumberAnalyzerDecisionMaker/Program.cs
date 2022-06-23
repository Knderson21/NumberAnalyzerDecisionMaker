//Ask user for name and number

Console.WriteLine("Howdy partner. What is your name?:");
string name = Console.ReadLine();

bool runProgram = true;

while (runProgram == true) //the ==true here is redundant, bc runProgram alone already is true above
{




    //create choice before loop to use it outside of loop
    int number = 0;


    //while true is an infinite loop
    while (true)
    {
        Console.WriteLine("Please enter a number between 1 and 100: ");
        number = int.Parse(Console.ReadLine());
        if (number >= 1 && number <= 100)
        {
            //if condition is met, this breaks out of infinite loop
            break;
        }
    }


    //take different actions and give output

    //odd and less than 60
    if (number % 2 == 1 && number < 60)
    {
        Console.WriteLine(name + ", " + number + " is odd and less than 60.");
    }

    //even and between 2 to 24
    else if (number % 2 == 0 && number >= 2 && number <= 24)
    {
        Console.WriteLine(name + ", this number is even and less than 25");
    }

    //even and between 26 to 60
    else if (number % 2 == 0 && number >= 26 && number <= 60)
    {
        Console.WriteLine(name + ", this number is even between 26 and 60 inclusive");
    }

    //even and more than 60
    else if (number % 2 == 0 && number > 60)
    {
        Console.WriteLine(name + ", this number is even and greater than 60.");
    }

    //odd and greater than 60
    else if (number % 2 == 1 && number > 60)
    {
        Console.WriteLine(name + ", " + number + " is odd and greater than 60.");
    }

    //get out of loop
    Console.WriteLine("Would you like to continue? y/n");
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower().Trim() == "y")
    {
        //doesnt do anything yet
    }
    else if (loopChoice.ToLower().Trim() == "n")
    {
        runProgram = false;
    }
}