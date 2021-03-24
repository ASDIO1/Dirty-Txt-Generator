using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace Txt_Generator
{
    class ConsoleDisplayer
    {
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
        static public void displayFileTextContent(string specificTxtPath)
        {
            Console.WriteLine("Actual content:\n");
            using (StreamReader streamReader = File.OpenText(specificTxtPath))
            {
                string textLine = streamReader.ReadLine();
                do
                {
                    ConsoleDisplayer.displayMessage(textLine, ConsoleColor.Magenta, true);
                    textLine = streamReader.ReadLine();
                } while (isTextLineFilled(textLine));
            }
        }
        static private bool isTextLineFilled(string textLine)
        {
            return textLine != null;
        }
    }
}
