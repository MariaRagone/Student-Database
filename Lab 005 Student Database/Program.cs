using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Transactions;
using System.Xml.Linq;

Console.WriteLine("Welcome to the Student Database.");
Console.WriteLine();
//ARRAYS 
string[] names = 
{ 
    "Justin Jones", 
    "Zach Buth", 
    "Omar Abdulla", 
    "Ethan Thomas", 
    "Joe Heath", 
    "Forrest Verellen", 
    "Doug Chu", 
    "Maya Araquil", 
    "Shane Chastain", 
    "Timothy Montague", 
    "Maria Ragone" 
};


for (int i = 0; i < names.Length; i++)
{
    names[i] = names[i].ToLower();
}
string[] towns = 
    { 
    "Columbus", 
    "Grand Rapids", 
    "Dearborn", 
    "Rolla", 
    "Howell", 
    "Traverse City, MI", 
    "Poughkeepsie", 
    "West bloomfield", 
    "Rochester Hills", 
    "Clio", 
    "Farmington Hills" 
};
string[] foods = 
    { 
    "Baja Blast", 
    "Pizza", 
    "Cheese Pizza", 
    "Hot Wings", 
    "Tacos", 
    "Spaghetti", 
    "Sushi", "" +
    "Sinigang", 
    "Pizza", 
    "Mole", 
    "Lasagna" 
};

//VARIABLES
bool search = true;
int choice = 0;
bool found = false;

while (search)
{
    Console.WriteLine("Do you want to search by name or number?");
    string nameOrNumber = Console.ReadLine().Trim().ToLower();

    if (nameOrNumber == "name")
    {
        Console.WriteLine("Enter a name to search.");
        string searchName = Console.ReadLine().Trim().ToLower();

        for (int n = 0; n < names.Length; n++) //loops thru each value in array
        {
            names[n] = names[n].ToLower(); //converts the array values to lowercase
            if (names[n] == searchName)
            {
                choice = n;
                //Console.WriteLine(choice); //only displays the index location (prints the location of the searchName input)
                //Console.WriteLine(names[n]); //displays the name of the searchName input
                while (true)
                {
                    Console.WriteLine($"Enter the category to display: Hometown or Favorite Food");
                    string category = Console.ReadLine().Trim().ToLower();
                    if (category == "hometown" || category == "town" || category == "home" || category == "h")
                    {
                        Console.WriteLine(towns[choice]);
                        break;
                    }
                    else if (category == "food" || category == "favorite" || category == "favorite food" || category == "f")
                    {
                        Console.WriteLine(foods[choice]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid choice. Please try again.");
                        continue;
                    }
                }
                //ask to continue viewing another student
                while (true)
                {
                    Console.WriteLine($"Would you like to learn about another student? y/n");
                    string answer = Console.ReadLine().ToLower().Trim();
                    if (answer == "n")
                    {
                        Console.WriteLine($"Bye!"); //exit the program
                        search = false;
                        break;
                    }
                    else if (answer == "y")
                    {
                        search = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please type 'y' or 'n'");
                    }
                }
            }
        }
        break;
    }
    else if (nameOrNumber == "number")
    {
        while (true)
        {
            Console.WriteLine($"Do you want to see a list of all the students? y/n");
            string nameList = (Console.ReadLine());
            if (nameList == "y")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i}. {names[i]}");
                }
                search = true;

                break;

            }
            else if (nameList == "n")
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid entry.");
            }
        }
        
        while (true)
        {
            Console.WriteLine($"Enter a student number: 0 - {names.Length - 1}");
            choice = int.Parse(Console.ReadLine());
            if (choice >= 0 && choice <= names.Length - 1) //make sure the user inputs a valid entry
            {
                Console.WriteLine(names[choice]);
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid entry.");
                search = true;
            }
        }
    }
    //search for the student

    
    while (true)
    {
        Console.WriteLine($"Enter the category to display: Hometown or Favorite Food");
        string category = Console.ReadLine().Trim().ToLower();
        if (category == "hometown" || category == "town" || category == "home" || category == "h")
        {
            Console.WriteLine(towns[choice]);
            break;
        }
        else if (category == "food" || category == "favorite" || category == "favorite food" || category == "f")
        {
            Console.WriteLine(foods[choice]);
            break;
        }
        else
        {
            Console.WriteLine("That is not a valid choice. Please try again.");
            continue;
        }
    }
    //ask to continue viewing another student
    while (true)
    {
        Console.WriteLine($"Would you like to learn about another student? y/n");
        string answer = Console.ReadLine().ToLower().Trim();
        if (answer == "n")
        {
            Console.WriteLine($"Bye!"); //exit the program
            search = false;
            break;
        }
        else if (answer == "y")
        {
            search = true;
            break;
        }
        else
        {
            Console.WriteLine("Please type 'y' or 'n'");
        }
    }
}


