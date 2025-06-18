string? valuEntry;
bool validEntry = false;

Console.WriteLine("Enter you role name: Administrator, Manager or User");
do
{
    valuEntry = Console.ReadLine();

    if ((valuEntry != "Administrator") || (valuEntry != "Manager") || (valuEntry != "User") && (validEntry == true))
    {
        Console.WriteLine("The role name must be either Administrator, Manager or User.");
        Console.WriteLine("Please enter a valid role name:");
        validEntry = false;
    }
    else if ((valuEntry == "Administrator")|| (valuEntry == "Manager") || (valuEntry == "User") && (validEntry == false))
    {
        validEntry = true;
        Console.WriteLine($"You input value {valuEntry} has been accepted.");
    }
} while (validEntry == false);