using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Txt_Generator
{
    class ConsoleDisplayer
    {
        static public void displayMenu()
        {
            Console.Clear();
            displayMessage("------TXT EDITOR MAIN MENU--------", ConsoleColor.Yellow, true);
            displayMessage("1) Overwrite text", ConsoleColor.Yellow, true);
            displayMessage("2) CREATE new text", ConsoleColor.DarkYellow, true);
            displayMessage("3) Delete text content", ConsoleColor.Yellow, true);
            displayMessage("4) Delete a hole text", ConsoleColor.DarkYellow, true);
            displayMessage("5) Show a txt content", ConsoleColor.Yellow, true);
            displayMessage("6) Exit", ConsoleColor.DarkYellow, true);
            displayMessage("\nChoose an option:", ConsoleColor.DarkYellow);
        }

        static public void displayMessage(string message, ConsoleColor color, bool jumpToTheNextLine = false)
        {
            Console.ForegroundColor = color;
            Console.Write($"{message}" + (jumpToTheNextLine ? "\n" : ""));
        }

        static public void displayFilesList(string[] txtList, string mainPath)
        {
            Console.WriteLine("----Files List----");
            for (int i = 0; i < txtList.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{i}) {txtList[i].Replace(mainPath, "")}");
            }
        }

        static public void displayErrorMessage(string errorMesage, int sleepTime)
        {
            displayMessage(errorMesage, ConsoleColor.Red, true);
            Thread.Sleep(sleepTime);
        }

        static public void displayFilesListAndMessage(string message, string[] txtList, string mainPath)
        {
            displayMessage("Choose a text file to edit by its id number", ConsoleColor.Cyan, true);
            displayFilesList(txtList, mainPath);
            displayMessage("\nChoose file:", ConsoleColor.Cyan);
        }
    }
}
