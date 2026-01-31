    // Intro plus naming
Console.WriteLine("A stong brave warrior has been engaged in a fight with the villan " +
    "Ryoza to the death with the planet on the line. " +
    "What is the name of this couragous fighter?");
    // Fighter name stored
string fighterName = Console.ReadLine();

    // Follow up plus energy prompt
Console.WriteLine($"{fighterName} has a limited amount of energy left to beat Ryoza. " +
    $"How much power left do you belive you have to fight off Ryoza?");

    // Store energy amount
int remainingEnergy = int.Parse(Console.ReadLine());

    // Follow up plus prompt about if support was chosen
Console.WriteLine($"Before heading off for the fight of thier life, {fighterName} had the choice to bring " +
    $"support from the Druin fighters. Did {fighterName} bring them along?");
