using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Txt_Generator
{
    class TextOrderExecutor
    {

        public Action<int, string[]> overwriteAnEspecificText = (chosenTxt, txtList) =>
        {
            string specificTxtPath = $"{txtList[chosenTxt]}";
            Console.WriteLine("Actual content:\n");
            using (StreamReader sr = File.OpenText(specificTxtPath))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            ConsoleDisplayer.displayMessage("\nContinue writting some text:  ", ConsoleColor.DarkCyan, true);
            string userText = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(txtList[chosenTxt], true))
            {
                sw.WriteLine(userText);
                sw.Close();
            }
        };

        public Action<int, string[]> deleteAnEspecificTextContent = (chosenTxt, txtList) =>
        {
            if (chosenTxt <= txtList.Length)
            {
                string specificTxtPath = $"{txtList[chosenTxt]}";
                using (StreamWriter sw = new StreamWriter(specificTxtPath, false))
                {
                    sw.WriteLine("");
                }
            }
            else
                ConsoleDisplayer.displayErrorMessage("\n\n\nIncorrect txt id", 500);
        };

        public Action<int, string[]> ShowAnEspecificTextContent = (chosenTxt, txtList) =>
        {
            if (chosenTxt <= txtList.Length)
            {
                string specificTxtPath = $"{txtList[chosenTxt]}";
                Console.WriteLine("Actual content:\n");
                using (StreamReader sr = File.OpenText(specificTxtPath))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        ConsoleDisplayer.displayMessage(s, ConsoleColor.Magenta, true);
                    }
                }
                ConsoleDisplayer.displayMessage("\nPress Enter to continue", ConsoleColor.Cyan, true);
                Console.ReadLine();
            }
            else
                ConsoleDisplayer.displayErrorMessage("\n\n\nIncorrect txt id", 500);
        };

        public Action<int, string[]> DeleteAnEspecificTextFile = (chosenTxt, txtList) =>
        {
            if (chosenTxt <= txtList.Length)
            {
                string specificTxtPath = $"{txtList[chosenTxt]}";
                File.Delete(specificTxtPath);
            }
            else
                ConsoleDisplayer.displayErrorMessage("\n\n\nIncorrect txt id", 500);
        };
    }
}
