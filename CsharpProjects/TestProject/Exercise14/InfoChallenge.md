# Challenge: Manage User Input

## Control Flow Statements

- **for statement**: Executes its body while a specified Boolean expression (the *condition*) evaluates to `true`.
- **foreach statement**: Enumerates the elements of a collection and executes its body for each element of the collection.
- **do-while statement**: Conditionally executes its body one or more times.
- **while statement**: Conditionally executes its body zero or more times.

In this challenge, you'll be presented with conditions for three separate coding projects. Each project will require you to implement an iteration code block using either a do-while or a while statement. You'll need to evaluate the specified conditions in order to choose between the do-while and while statements. You can switch after you start if your first choice isn't working out as well as you had hoped.

### Code project 1 - write code that validates integer input

Here are the conditions that your first coding project must implement:

- Your solution must include either a do-while or while iteration.
- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
- Inside the iteration block:
  + Your solution must use a Console.ReadLine() statement to obtain input from the user.
  + Your solution must ensure that the input is a valid representation of an integer.
  + If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
  + Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
- Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

1. Ensure that you have an empty Program.cs file open in Visual Studio Code.
   If necessary, open Visual Studio Code, and then complete the following steps to prepare a Program.cs file in the Editor:
    - On the File menu, select Open Folder.
    - Use the Open Folder dialog to navigate to, and then open, the CsharpProjects folder.
    - In the Visual Studio Code EXPLORER panel, select Program.cs.
    - On the Visual Studio Code Selection menu, select Select All, and then press the Delete key.

2. Write the code that implements each condition for code project 1.

3. Run your application and verify that your code validates user input based on the specified requirements.
   For example, when you run your application, it should reject input values such as "two" and "2", but it should accept an input value of "7".
   The example described above, the console output should look similar to the following:

```CSharp
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
```

### Code project 2 - write code that validates string input

Here are the conditions that your second coding project must implement:

- Your solution must include either a do-while or while iteration.
- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
- Inside the iteration block:
  - Your solution must use a Console.ReadLine() statement to obtain input from the user.
  - Your solution must ensure that the value entered matches one of the three role options.
  - Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
  - Your solution should use the ToLower() method on the input value to ignore case.
  - If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.

- Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

1. Comment out all of the code in the Visual Studio Code Editor panel
    - Select all of the code lines in the code editor
    - On the Edit menu, select Toggle Block Comment.

2. Write the code that implements each condition for code project 2.
3. Run your application and verify that your code validates user input based on the specified requirements.
   For example, when you run your application, it should reject an input value such as "Admin", but it should accept an input value of " administrator ".

The console output for this example should look similar to the following:

´´´CSharp
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
Administrator
Your input value (Administrator) has been accepted.
´´´

### Code project 3 - Write code that processes the contents of a string array

Here are the conditions that your third coding project must implement:
your solution must use the following string array to represent the input to your coding logic:
´´´CSharp
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
´´´

- Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

- Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.
- In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
- Your solution must include an inner do-while or while loop that can be used to process the myString variable.
- In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
- In the inner loop, your solution must not display the period character.
- In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.

1. Comment out all of the code in the Visual Studio Code Editor panel

2. Select all of the code lines in the code editor

    - On the Edit menu, select Toggle Block Comment.
    - Write the code that implements each condition listed for code project

3. Run your application and verify that your output meets the requirements.

If your code logic works correctly, your output should look similar to the following:
´´´CSharp
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
´´´
