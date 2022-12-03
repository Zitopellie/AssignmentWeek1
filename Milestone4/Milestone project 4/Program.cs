using Milestone_project_4;

GSM gsmPhone = new GSM();

Console.WriteLine(gsmPhone.color);
Console.ReadLine();



Books book1 = new Books("GoodBoy", "Aremu", "A.a. JOhnson", 2019, 2042344443);
Books book2 = new Books("BadBoy", "Karimu", "J.J Okocha", 2002, 384027547);

List<Books> bookList = new List<Books>
{
    book1, book2
};
Library Library1= new Library("First Library", bookList);

Library1.SearchBytitlestring("BadBoy");
Library1.DeleteBook("GoodBoy");
Console.ReadLine();


//Write a program that reads a list of words from
//a file words.txt and finds how many times each of
//the words is contained in another file test.txt.
//The result should be written in the file result.txt
//and the words should be sorted by the number of their
//occurrences in descending o
//rder. Handle all possible exceptions in your methods


var list = File.ReadAllLines("Try3.csv");
foreach (string line in File.ReadAllLines("Try3.csv"))

{
    string[] parts = line.Split(' ');
    foreach (string part in parts)
    {

        var q = list.GroupBy(x => x)
            .Select(g => new { Value = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count);
        foreach (var x in q)
        {
            Console.WriteLine("{0}", part + " Count:" + x.Count);
        }
    }
}

//Write a program that replaces all occurrences of the
//substring "start" with the substring "finish"
//in a text file. Ensure it will work with large
//files (e.g. 100 MB)

 void EditorialControl()
{
    string fileName;
    string lineReadFromFile;


    Console.WriteLine("");
    // Ask for the name of the file to be read
    Console.Write("Which file do you wish to read? ");
    fileName = Console.ReadLine();
    Console.WriteLine("");

    // Open the file for reading
    StreamReader fileReader = new StreamReader("C:\\Users\\Greg\\Desktop\\Programming Files\\story.txt");

    // Read the lines from the file and display them
    // until a null is returned (indicating end of file)
    lineReadFromFile = fileReader.ReadLine();

    Console.WriteLine("Please enter the word you wish to edit out: ");
    string editWord = Console.ReadLine();

    while (lineReadFromFile != null)
    {
        Console.WriteLine(lineReadFromFile);
        lineReadFromFile = fileReader.ReadLine();
    }

    String text = File.ReadAllText("C:\\Users\\Greg\\Desktop\\Programming Files\\story.txt");
    fileReader.Close();

    StreamWriter fileWriter = new StreamWriter("C:\\Users\\Greg\\Desktop\\Programming Files\\story.txt", false);
    string newText = text.Replace("start", "finish");
    fileWriter.WriteLine(newText);
    fileWriter.Close();