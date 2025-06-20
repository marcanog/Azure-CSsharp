// Vars 
string? petID = "";
string? petSpecies = "";
int petAge = 0;
string? petDescription = "";
string? petCharacteristics = "";
string? petName = "";
string? option = " ";

//Multimensional array to store pet information
string[,] ourAnimals = new string[10, 6]
{
    {"1","dog","5","Beagle","friendly","Max"},
    {"2","cat","4","Siamese","affectionate","Luna"},
    {"3","dog","1","Poodle","intelligent","Charlie"},
    {"4","cat","3","Bengal","energetic","Milo"},
    {"5","dog","2","Bulldog","calm","Rocky"},
    {"6","cat","5","Persian","lazy","Bella"},
    {"7","dog","4","Rottweiler","protective","Duke"},
    {"8","cat","1","Maine Coon","playful","Oliver"},
    {"9","dog","3","Pitbull","loyal","Buddy"},
    {"10","cat","2","Sphynx","curious","Lucy"}
};


//Menu option for user add a new pet
Console.WriteLine("Select an option: ");
Console.WriteLine("1. Display a list of pet's information for all our pets.");
Console.WriteLine("2. Add new pet information.");
Console.WriteLine("3. Update a pet information by ID.");
Console.WriteLine("Exit");
string? input = Console.ReadLine();
if (input == "" || input != "1" && input != "2" && input != "3" && input != "4")
{
    Console.WriteLine("Please select a valid option.");
    return;
}
option = input;
switch (option)
{
    case "1":
        //Display all pets information
        //Dataset sample to test the code
    for (int i = 0; i < ourAnimals.GetLength(0); i++)
    {
        petID = ourAnimals[i, 0];
        petSpecies = ourAnimals[i, 1];
        petAge = sbyte.Parse(ourAnimals[i, 2]);
        petDescription = ourAnimals[i, 3];
        petCharacteristics = ourAnimals[i, 4];
        petName = ourAnimals[i, 5];

        Console.WriteLine($"Pet ID: {petID}, Species: {petSpecies}, Age: {petAge}, Description: {petDescription}, Characteristics: {petCharacteristics}, Name: {petName}");
    }
        break;

    case "2":
        //Add new pet information
        string? searchID = "";
        Console.WriteLine("Enter the pet's ID to search for:");
        searchID = Console.ReadLine();

        for (int i = 0; i < ourAnimals.GetLength(0); i++)
        {
            if (ourAnimals[i, 0] == searchID)
            {
                // Console.WriteLine(ourAnimals[i, 0]);
                Console.WriteLine("Pet already exists with this ID. Please enter a different ID.");
            }
            else
            {
                Console.WriteLine("Enter the pet ID: ");
               string? PetID  = Console.ReadLine();
                if (string.IsNullOrEmpty(PetID))
                {
                    Console.WriteLine("Pet ID cannot be empty. Please enter a valid ID.");
                    continue;
                }
                petID = PetID;
            
                Console.WriteLine("Enter the pet species: ");
                string? PetSpecies = Console.ReadLine();
                if (string.IsNullOrEmpty(PetSpecies))
                {
                    Console.WriteLine("Pet species cannot be empty. Please enter a valid species.");
                    continue;
                }
                petSpecies = PetSpecies;

                int? PetAge = 0;
                Console.WriteLine("Enter the pet age: ");
                PetAge = int.Parse(Console.ReadLine()!);
                if (PetAge <= 0)
                {
                    Console.WriteLine("Pet age must be a positive number. Please enter a valid age.");
                    continue;
                }
                petAge = PetAge.Value;

                string? PetDescription = "";
                Console.WriteLine("Enter the pet description: ");
                petDescription = Console.ReadLine();
                if (string.IsNullOrEmpty(petDescription))
                {
                    Console.WriteLine("Pet description cannot be empty. Please enter a valid description.");
                    continue;
                }
                Console.WriteLine("Enter the pet characteristics: ");
                petCharacteristics = Console.ReadLine();
                if (string.IsNullOrEmpty(petCharacteristics))
                {
                    Console.WriteLine("Pet characteristics cannot be empty. Please enter valid characteristics.");
                    continue;
                }
                Console.WriteLine("Enter the pet name: ");
                petName = Console.ReadLine();
                if (string.IsNullOrEmpty(petName))
                {
                    Console.WriteLine("Pet name cannot be empty. Please enter a valid name.");
                    continue;
                }

            }
        }
        break;

    case "3":
        //Update a pet information by ID
        break;

    case "4":
        //Exit
        break;

}