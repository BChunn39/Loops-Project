Console.WriteLine("You are running down a hall away from a creature. You come to a door with a key pad. Press in a 5 diget number.");
int keyCodeNumber = (13579);
int codeEntered = Convert.ToInt32(Console.ReadLine());
int guessCount= 1;
int guessLimit = 5;
bool outOfGuesses =false;
while(!outOfGuesses)
{
     if (codeEntered == keyCodeNumber)
    {
        Console.WriteLine($"The door clicks open and you slam it behind you. Nothing seems to be able to get through the door. You are safe and did it in {guessCount}");
        break;
    }
    else if (guessCount < guessLimit)
    {
        Console.WriteLine("The door rattles but dose not open. You hear a footstep getting closer. Enter in a diffrent 5 diget number.");
        codeEntered = Convert.ToInt32(Console.ReadLine());
        guessCount++;
    }
   
    else
    {
        outOfGuesses = true;
        Console.WriteLine("You hear the footsteps stop and something grabs you. Everything goes dark. You lose.");
    }
}

