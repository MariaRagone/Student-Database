//arrays
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

bool search = true;

int choice = 0;
while (search)
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
            //foreach (string n in names)
            //Console.WriteLine(n);
            //break;
            break;
        }

        else
        {
            break;
        }

    }
    while (true)
    {
        Console.WriteLine($"Enter a student number: 0 - {names.Length - 1}");
        choice = int.Parse(Console.ReadLine());
        if (choice >= 0 && choice <= names.Length - 1)
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
    //ask to continue
    while (true)
    {
        Console.WriteLine($"Would you like to learn about another student? y/n");
        string answer = Console.ReadLine().ToLower().Trim();
        if (answer == "n")
        {
            Console.WriteLine($"Bye!");
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
//for (int i = 0; i < choice.Length; i++) //loops thru each value in array
//{
//    if (choice[i] == val2Input)
//    {
//        Console.WriteLine(i); //only displays the index location (prints "1" and "4")
//    }
//}