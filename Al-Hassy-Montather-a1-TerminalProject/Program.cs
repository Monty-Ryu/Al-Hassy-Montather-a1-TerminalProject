// Intro plus naming
// Fighter name stored
Console.WriteLine("A stong brave warrior has been engaged in a fight with the villan Ryoza to the death with the planet on the line.\n" +
    "What is the name of this courageous fighter?");

Console.WriteLine();
string fighterName = Console.ReadLine();
Console.WriteLine();

// Follow up plus energy prompt
// Store energy amount
Console.WriteLine($"{fighterName} has a limited amount of energy left to beat Ryoza.\n" +
    $"How much power left do you believe they have to fight off Ryoza?");

Console.WriteLine();
int remainingEnergy = int.Parse(Console.ReadLine());
Console.WriteLine();

// Follow up plus prompt about if support was chosen
// Support response vaule saved
Console.WriteLine($"Before heading off for the fight of thier life, " +
    $"{fighterName} had the choice to bring support from the Drazko fighters or go at it alone, thinking it'd be less restrictive. " +
    $"Did {fighterName} bring them along?");
    
Console.WriteLine();
string drazkoSupport = Console.ReadLine();
Console.WriteLine();

// Enemy + suppport energy establised 
// Check if response is true or not
int ryozaEnergy = 1000;
int drazkoSupportEnergy = 500;

if (drazkoSupport == "Yes" || drazkoSupport == "yes")
{
    // Enough total energy to pass  check. Inform of win
    if (remainingEnergy + drazkoSupportEnergy > ryozaEnergy)
    {
        Console.WriteLine($"Well done! {fighterName} and the team have manage to beat the fierce Ryoza!");
    }
    else
    {
        // Not enough total energy to pass check. Inform of loss 
        Console.WriteLine($"Oh nooooooooooooo!!! {fighterName} and team Drazko did not have enough energy to beat Ryoza.");
    }
}
        // Check if player energy is greater than enemy. Inform of win
else if (remainingEnergy > ryozaEnergy)
{
    Console.WriteLine($"Well done! {fighterName}s resolve and remaining energy was enough to defeat the villanous Ryoza!!");
        
}

        // No correct response given or other checks fail. Inform player of loss
else
{
    Console.WriteLine($"Oh nooooooooo!!! {fighterName}s remaining energy was overestimated and has lost to the villanous Ryoza!!");
}