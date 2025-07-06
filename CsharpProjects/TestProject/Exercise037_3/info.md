# Exercise - Complete a challenge activity using the debugger

In this challenge, you're provided with a code sample that isn't producing the expected result. You need to use breakpoints and the VARIABLES section of the RUN AND DEBUG view to help you figure out the issues.

1. Enter the following code sample into the Visual Studio Code Editor:

````Csharp
/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

ChangeValue(x);

Console.WriteLine(x);

void ChangeValue(int value) 
{
    value = 10;
}
`````
