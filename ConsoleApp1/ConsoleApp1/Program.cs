using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sprint1Method();
        }

        static void Sprint1Method()
        {
            Console.WriteLine("Here be text!");

            string messageText = "This is some text!";
            string messageSenderName = "Walter Pease";
            DateTime messageTimeSent = DateTime.Today;
            Message newMessage = new Message(messageText, messageSenderName, messageTimeSent);
        }
    }
}
