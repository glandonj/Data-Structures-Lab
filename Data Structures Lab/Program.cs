Console.WriteLine("Hello and welcome to the Word Jumbler, which reverses any single word you submit.");
Console.Write("Please enter a word or phrase: ");
string input = Console.ReadLine().Trim();
string[] wordlist = input.Split(" ");

foreach (string word in wordlist)
{
    Console.Write($"{StringReverse(word)} ");
}


//method
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