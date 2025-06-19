
# Learning objectives

In this module, you'll practice how to:
Use Visual Studio Code to develop a C# console application that uses a combination of selection and iteration statements to implement logical workflows in accordance with supplied application data and user interactions.
Evaluate the underlying conditions and make an informed decision when choosing between if-elseif-else and switch statements, and between foreach, for, while, and do iteration statements.
Scope variables at an appropriate level within an application.

## Prerequisites

Experience using Visual Studio Code to develop, build, and run C# console applications that include console I/O and access the methods of .NET classes
Experience using C# code to evaluate conditional expressions and manage variable scope inside and outside of code blocks
Experience using if-elseif-else and switch-case statements in C# to match a variable or expression against several possible outcomes
Experience using foreach, for, do, and while statements in C# to loop through a block of code and access elements of array variables

[Guided project - Develop conditional branching and looping structures in C#](https://learn.microsoft.com/en-us/training/modules/guided-project-develop-conditional-branching-looping/2-prepare)

### Exercise 1

In this exercise, you review the code in the Starter project, perform some code clean-up tasks, and then start adding features to your application. The tasks that you complete during this exercise are:

1. Code review: review the contents of the Program.cs file.
2. Sample data: convert the if-elseif-else structure to switch-case structure that improves readability.
3. Menu loop: enclose the main menu and menu item selection in a loop that iterates until the user enters "exit".
4. Menu selections: write the code for a switch-case structure that establishes separate code branches for each menu option.
5. Code branches: write placeholder within the menu item branches that provides user feedback until app features are developed.
6. Verification test: perform verification tests for the code that you develop in this exercise.

Your application will use boolean expressions, selection statements and iteration statesments to implement the features of a design specification. As you develop the application, you'll need to scope variables at the appropiate level.

#### Project overview

You're working on the Contoso Pets Application, an app that helps place pets in new homes. The specifications for your application are:

* Create a C# console application.
* Store application data in a multidimensional string array name OurAnimals.
* The OurAnimals array includes the following "pet characteritics" for each animal:
        + Pet ID #.
        + Pet species (cat or dog).
        + Pet age (years).
        + A description of the pet's physical condition/characteristics.
        + A description of the pet's personality.
        + The pet's nickname.
* Implement a sample dataset that represents dogs and cats currently in your care.
* Display menu options to acces the main features of the application.
* The main features enable the following tasks.
        + List the pet information for all animal in the OurAnimals array.
        + Add new animals to the OurAnimal array. The following conditions apply:
                - The pets species (dog or cats) must be entered when a new animal is added to the OruAnimals array.
                - A pet ID must be programmatically generated. when a new animal is added to the OurAnimals array.
                - Some physical characteristics for a pet may be unknown until a veterinarian's examination. For example: age, breed, and neutered/spayed status.
                - An animal's nickname and personality may be unknown when a pet first arrives.
        + Ensure animal ages and physical descriptions are complete. This may be required after a veterinarian's examination.
        + Ensure animal nicknames and personality descriptions are complete (this action can occur after the team gets to know a pet).
        + Edit an animal’s age (if a pet's birth date is known and the pet has a birthday while in our care).
        + Edit an animal’s personality description (a pet may behave differently after spending more time in our care).
        + Display all cats that meet user specified physical characteristics.
        + Display all dogs that meet user specified physical characteristics.
An intial version of the app has already been completed. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:
* The code declares variables used to collect and process pet data and menu item selections.
* The code declares the ourAnimals array.
* The code uses a for loop around an if-elseif-else construct to populate the ourAnimals array with a sample dataset.
* The code displays the following main menu options for user selection:
        1. List all of our current pet information.
        2. Assign values to the ourAnimals array fields.
        3. Ensure animal ages and physical descriptions are complete.
        4. Ensure animal nicknames and personality descriptions are complete.
        5. Edit an animal’s age.
        6. Edit an animal’s personality description.
        7. Display all cats with a specified characteristic.
        8. Display all dogs with a specified characteristic.

    Enter menu item selection or type "EXIT" to exit the program.
* The code reads the user's menu item selection and displays a message echoing their selection.
