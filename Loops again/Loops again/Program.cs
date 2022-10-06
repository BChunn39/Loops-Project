bool startAgain;
do
{
    Console.WriteLine("You have come to a locked door with a keypad. Please enter a 5 digit code.");
    string codeEntered;
    codeEntered = Console.ReadLine();
    if (codeEntered == "13579")
    {
        Console.WriteLine("The door opens! You are able to get in!");
        Environment.Exit(0);
    }
    if (codeEntered != "13579")
    {
        Console.WriteLine("The door clicks but dose not open. Perhaps another set of digits would work.");
    }

    Console.WriteLine("Would you like to enter another number (y/n)?");
    string input = Console.ReadLine();
    startAgain = input.ToLower() == "y";
}
while (startAgain == true);
Console.WriteLine("Thank you for playing!");