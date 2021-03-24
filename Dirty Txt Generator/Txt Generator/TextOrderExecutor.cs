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
            ConsoleDisplayer.displayFileTextContent(specificTxtPath);
            ConsoleDisplayer.displayMessage("\nContinue writting some text:  ", ConsoleColor.DarkCyan, true);
            string userText = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(txtList[chosenTxt], true))
            {
                sw.WriteLine(userText);
                sw.Close();
            }
        };

        public void createNewText(string mainPath)
        {
            ConsoleDisplayer.displayMessage("Chose your new Txt name", ConsoleColor.Cyan, true);
            ConsoleDisplayer.displayMessage("name: ", ConsoleColor.Cyan);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string newTxtName = Console.ReadLine();
            string newTxt = $"{mainPath}/{newTxtName}.txt";
            if (!File.Exists(newTxt))
            {
                var myNewFile = File.Create(newTxt);
                myNewFile.Close();
            }
        }

        public Action<int, string[]> deleteAnEspecificTextContent = (chosenTxt, txtList) =>
        {
            string specificTxtPath = $"{txtList[chosenTxt]}";
            using (StreamWriter sw = new StreamWriter(specificTxtPath, false))
            {
                sw.WriteLine("");
                sw.Close();
            }
        };

        public Action<int, string[]> ShowAnEspecificTextContent = (chosenTxt, txtList) =>
        {
            string specificTxtPath = $"{txtList[chosenTxt]}";
            ConsoleDisplayer.displayFileTextContent(specificTxtPath);
            ConsoleDisplayer.displayMessage("\nPress Enter to continue", ConsoleColor.Cyan, true);
            Console.ReadLine();
        };

        public Action<int, string[]> DeleteAnEspecificTextFile = (chosenTxt, txtList) =>
        {
            string specificTxtPath = $"{txtList[chosenTxt]}";
            File.Delete(specificTxtPath);
        };

        
    }
}
