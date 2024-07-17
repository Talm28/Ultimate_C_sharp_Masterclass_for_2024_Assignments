
List<string> todoList = new List<string>();

void PrintOptions()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

bool InputCheck(string input, string inputToCheck)
{
    if(input.ToUpper() == inputToCheck.ToUpper())
        return true;
    return false;
}

void SeeOption()
{
    int listCount = todoList.Count;
    if(listCount == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    for(int i=0 ; i < listCount ; i++)
    {
        Console.WriteLine($"{i + 1}. {todoList[i]}");
    }
    return;
}

void AddOption()
{
    string userInput;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        userInput = Console.ReadLine();

    }while(!InputValidityCheck(userInput));
    todoList.Add(userInput);
}
bool InputValidityCheck(string input)
{
    if(input == "" || input ==null)
        {
            Console.WriteLine("The description cannot be empty.");
            return false;
        }
        else if(todoList.Contains(input))
        {
            Console.WriteLine("The description must be unique.");
            return false;
        }
        else
        {
            Console.WriteLine($"TODO successfully added: {input}");
            return true;
        }
}

List<string> RemoveOption(List<string> todoList)
{
    int listCount = todoList.Count;
    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        SeeOption();
        if(listCount == 0)
            return todoList;
    }while(!IndexValidityCheck(out index));

    Console.WriteLine($"TODO removed: {todoList[index - 1]}");
    todoList.RemoveAt(index - 1);
    return todoList;
}
bool IndexValidityCheck(out int index)
{
    string userInput = Console.ReadLine();
    if(userInput == "" || userInput == null)
    {
        Console.WriteLine("Selected index cannot be empty.");
        index = 0;
        return false;
    }
    else
    {
        if(int.TryParse(userInput, out index) && (index < 1 || index > todoList.Count))
        {
            Console.WriteLine("The given index is not valid.");
            return false;
        }
    }
    return true;
}

bool isEnded = false;
Console.WriteLine("Hello!");
do
{
    PrintOptions();
    string userInput = Console.ReadLine();

    if(InputCheck(userInput, "s")) // See option
    {
        SeeOption();
    }
    else if(InputCheck(userInput, "a")) // Add option
    {
        AddOption();
    }
    else if(InputCheck(userInput, "r")) // Remove option
    {
        todoList = RemoveOption(todoList);
    }
    else if(InputCheck(userInput, "e")) // Exit option
    {
        isEnded = true;
    }
    else
    {
        Console.WriteLine("Incorrect input");
    }
}while(!isEnded);