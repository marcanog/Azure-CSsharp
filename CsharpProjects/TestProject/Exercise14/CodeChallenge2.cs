string? valuEntry;
bool validEntry = false;

Console.WriteLine("Enter you role name: Administrator, Manager or User");
do
{
    valuEntry = Console.WriteLine();
    if (valuEntry != "Administrator" || valuEntry != "Manager" || valuEntry != "User")
    {
        Console.WriteLine("The role name must be either Administrator, Manager or User.");
        console.WriteLine("Please enter a valid role name:");
        validEntry = false;
    }
    else
    {
        validEntry = true;
        Console.WriteLine($"You input vale {valuEntry} has been accepted.");
    }
} while (isvalid == false);