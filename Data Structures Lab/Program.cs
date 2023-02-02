Console.WriteLine("Hello and welcome to the Word Mirror, which reverses anything you submit.");
Console.Write("Please enter a word: ");
string input = Console.ReadLine().Trim();

Console.WriteLine(StringReverse(input));

static string StringReverse(string input)
{
    Stack<char> myStack = new Stack<char>();
    string reverseinput = "";
        foreach(char w in input)
    {
        myStack.Push(w);
    }
        foreach(char c in myStack)
    {
        reverseinput += c;
    }
    return reverseinput;
}

Console.ReadLine();