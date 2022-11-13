using Milestone3;
using System.Net;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


{
    #region TriangleArea

    //Write methods that calculate the surface of a triangle by given:
    // Side and an altitude to it;
    // Three sides; Two sides and
    // an angle between them.Use System.Math.

    Triangle triangle1 = new Triangle(2, 4);
    Console.WriteLine("The area of this triangle (using 1 side and altitude) is " + triangle1.surfaceArea);


    Triangle triangle2 = new Triangle(2, 4, 3);
    Console.WriteLine("The area of this triangle (using three sides) is " + triangle2.surfaceArea);


    Triangle triangle3 = new Triangle(2, 4, 30);
    Console.WriteLine("The area of this triangle (using two sides and the angle between them) is " + triangle3.surfaceArea);
    #endregion


    #region StringIntAddition

    //You are given a sequence of positive integer values written into a string,
    //separated by spaces.
    //Write a function that reads these values from a given string
    //and calculates their sum. Example:
    // string = "43 68 9 23 318" => result = 461


    string numbers = "123 451 234 5";
    int total = 0;
    int num;
    string numbersMiniString = "";
    int minisum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        char y = numbers[i];

        //pass in all numbers string on the main string into another string until a space bar character is encountered 
        if (char.IsWhiteSpace(y))
        {

            {

                if (numbersMiniString.Length == 0)
                    continue;

                if (int.TryParse(numbersMiniString.ToString(), out num))
                {
                    minisum += num;
                }

            }
            //add all of this numbers in the mini string into the total value
            total += minisum;
            ResetnumbersMiniString();
        }

        numbersMiniString += y;
    }
    Console.WriteLine("the sum of string {0} is {1}", numbers, total);

    void ResetnumbersMiniString()
    {
        numbersMiniString = "";
    }
    #endregion


    #region Downloading files strings from the internet

    //Write a program that downloads a file from the Internet
    //(e.g. http://www.anysite.org/img/anysiteimage.jpg) and
    //stores it in the current directory.
    //Find in Google how to download files in C#.
    //Be sure to catch all exceptions and to free any
    //used resources in the finally block.

    string remoteUri = "http://www.contoso.com/library/homepage/images/";
    string fileName = "ms-banner.gif", myStringWebResource = null;

    // Create a new WebClient instance.
    using (WebClient myWebClient = new WebClient())
    {
        myStringWebResource = remoteUri + fileName;
        // Download the Web resource and save it into the current filesystem folder.
        myWebClient.DownloadFile(myStringWebResource, fileName);
    }
    #endregion

    #region Sorting words in a list in alphabetical order
    //Write a program that reads a list of words,
    //separated by spaces
    //and prints the list in an alphabetical order.


    string word;
    List<string> wordArray = new List<string>();
    Console.WriteLine("Enter the word: ");
    word = Console.ReadLine();
    string newWord = "";


    // put all the words in the string in a list 
    for (int i = 0; i < word.Length; i++)
    {
        char z = numbers[i];


        if (char.IsWhiteSpace(z))
        {

            if (newWord.Length == 0)
                return;
            wordArray.Add(newWord);
        }
        newWord += z;

    }

    wordArray.Sort();
    foreach (string ss in wordArray)
        Console.WriteLine("\n\t ..." + ss);
    Console.ReadLine();
    #endregion


    #region
    //Write a program that extracts from a given HTML file its title (if available), and its body text without the HTML tags. Example:
    //< html >
    // < head >< title > News </ title ></ head >
    // < body >< p >< a href = "http://hackcity.io" > Hackcity </ a > aims to provide free real-world practical training for young people who want to turn into skillful.NET software engineers.</ p ></ body >
    //</ html >




    String text = "";
    String content = File.ReadAllText(dataDir + "Test2.html");
    // Create an instance of HTML document
    var document = new HTMLDocument(content, "");

    // The second way of gathering text elements from document by using custom method
    text = GetContent(document.Body);

    File.WriteAllText("Test.txt", text);

    // The third way of gathering text elements from document by using TextContent property
    text = document.Body.TextContent;

    File.WriteAllText("Test.txt", text);



    static string GetContent(Aspose.Html.Dom.Node node)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var n in node.ChildNodes)
        {
            if (n.NodeType == Aspose.Html.Dom.Node.ELEMENT_NODE)
                sb.Append(GetContent(n));
            else if (n.NodeType == Aspose.Html.Dom.Node.TEXT_NODE)
                sb.Append(n.NodeValue);
        }
        return sb.ToString();
    }

    #endregion
}
