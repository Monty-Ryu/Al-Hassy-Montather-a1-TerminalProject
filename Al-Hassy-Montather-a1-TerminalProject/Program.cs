    // Intro plus naming
using System;
using System.ComponentModel.Design;

Console.WriteLine("A stong brave warrior has been engaged in a fight with the villan " +
    "Ryoza to the death with the planet on the line.\n" +
    "What is the name of this courageous fighter?");
    // Fighter name stored
string fighterName = Console.ReadLine();
Console.WriteLine();

    // Follow up plus energy prompt
Console.WriteLine($"{fighterName} has a limited amount of energy left to beat Ryoza.\n" +
    $"How much power left do you believe they have to fight off Ryoza?");

    // Store energy amount
int remainingEnergy = int.Parse(Console.ReadLine());
Console.WriteLine();

    // Follow up plus prompt about if support was chosen
Console.WriteLine($"Before heading off for the fight of thier life, {fighterName} had the choice to bring\n" +
    $"support from the Drazko fighters or go at it alone, thinking it'd be less restrictive.\nDid {fighterName} bring them along?");
    
    // Support respoinse vaule saved
string drazkoSupport = Console.ReadLine();
Console.WriteLine();

    // Enemy  + suppport energy establised 
int ryozaEnergy = 1000;
int drazkoSupportEnergy = 500;

    // Check if response is true or not
if (drazkoSupport == "Yes" || drazkoSupport == "yes")
{
    if (remainingEnergy + drazkoSupportEnergy > ryozaEnergy)
    {
        // Enough total energy, inform of win
        Console.WriteLine("Well done! You and your team manage to beat the fierce Ryoza!");
    }
    else
    {
        // Not enough combined energy, inform of loss
        Console.WriteLine($" Oh nooooooooooooo!!! {fighterName} and team Drazko did not have enough energy to beat Ryoza.");
    }
}

else if (remainingEnergy >  ryozaEnergy)
{
        Console.WriteLine($"Well done! {fighterName}s resolve and energy was enough to defeat the villanous Ryoza!!");
        
}

else
{
    
}