using System;
using System.Web;

public class XssExample
{
    public void DisplayUserInput(string userInput)
    {
        // Displaying the user input directly on a webpage
        Console.WriteLine("User input: " + userInput);
        // In a real application, this would be injected into a web page, leading to XSS
        string safeOutput = HttpUtility.HtmlEncode(userInput);
        Console.WriteLine("Encoded output: " + safeOutput);
    }
}
