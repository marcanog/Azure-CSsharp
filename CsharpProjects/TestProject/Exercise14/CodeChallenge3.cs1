string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string mySentence = "";
string myStringf = "";
int periodLocation = 0;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf('.');
    myStringf = myString;
    do
    {
        mySentence = myStringf.Remove(periodLocation);
        myStringf = myStringf.Substring(periodLocation + 1);
        myStringf = myStringf.TrimStart();
        Console.WriteLine(mySentence);
        periodLocation = myStringf.IndexOf('.');

    } while (periodLocation != -1);
    mySentence = myStringf.Trim(); // Last sentence without a period
    Console.WriteLine(mySentence);
}