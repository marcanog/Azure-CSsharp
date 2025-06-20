
string? petID = "";
string? petSpeciesInput = "";
sbyte petAge = 0; //Pet age in years
string? petDescription = "";
string? petNickname = "";
bool exit = false;
string option = "";

int maxPets = 8;
string[,] ourAnimals = new string[maxPets, 6];

Console.WriteLine("Welcome to the Contoso Pets application!");
do
{
    Console.WriteLine("please enter a pet ID");
    petID = Console.ReadLine()!;

    if (petID == "" || petID == null)
    {
        Console.WriteLine("You must enter a pet ID.");
        continue;
    }
    Console.WriteLine("Please enter the pet species (dog/cat):");
    petSpeciesInput = Console.ReadLine();
    if (petSpeciesInput != "dog" && petSpeciesInput != "cat")
    {
        Console.WriteLine("You must enter a valid pet species (dog/cat).");
        continue;
    }

    Console.WriteLine("Please enter the pet age (in years):");
    if (!sbyte.TryParse(Console.ReadLine(), out petAge))
    {
        Console.WriteLine("You must enter a valid pet age.");
        continue;
    }

    Console.WriteLine("Please enter the pet description:");
    petDescription = Console.ReadLine()!;

    Console.WriteLine("Please enter the pet nickname:");
    petNickname = Console.ReadLine()!;

    Console.WriteLine($"Pet ID: {petID}");
    Console.WriteLine($"Pet Species: {petSpeciesInput}");
    Console.WriteLine($"Pet Age: {petAge}");
    Console.WriteLine($"Pet Description: {petDescription}");
    Console.WriteLine($"Pet Nickname: {petNickname}");

    Console.WriteLine("Do you want to add another pet? (yes/no)");
    option = Console.ReadLine()!;
    if (option != "yes")
    {
        exit = true;
    }

} while (exit == true);