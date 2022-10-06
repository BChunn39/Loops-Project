Console.WriteLine("You come to a Keypad. Please enter your 5 digit code.");
int keyCodeNumber = (13579);
int codeEntered = Convert.ToInt32(Console.ReadLine());
while (codeEntered != keyCodeNumber)
{
    Console.WriteLine("The keypad buzzes and the door dose not open. Please enter another 5 digit number");
    codeEntered = Convert.ToInt32(Console.ReadLine());
}

   if (codeEntered == keyCodeNumber)
{
    Console.WriteLine($"The Keypad clicks and opens. The correct number was {keyCodeNumber}. Thank you for playing.");
    Console.ReadLine();
}