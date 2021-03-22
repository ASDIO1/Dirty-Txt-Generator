using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Txt_Generator
{
    class TextFileManager
    {

        private string mainPath;
        private TextOrderExecutor textOrderExecutor;
        private string[] txtList;
        public TextFileManager()
        {
            mainPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", "SavedTexts"));
            txtList = GetFiles(mainPath);
            textOrderExecutor = new TextOrderExecutor();
        }
        private void createNewText()
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
        private void DeleteTextContent()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to edit by its id number", txtList, mainPath);
                SelectTextAndExecuteOrder(textOrderExecutor.deleteAnEspecificTextContent);
            }
        }
        private void DeleteTextFile()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to id to DELETE it", txtList, mainPath);
                SelectTextAndExecuteOrder(textOrderExecutor.DeleteAnEspecificTextFile);
            }
        }
        private void ExecuteMenuSeleccion(string option) {
            switch (option)
            {
                case "1":
                    OverwriteText();
                    break;
                case "2":
                    createNewText();
                    break;
                case "3":
                    DeleteTextContent();
                    break;
                case "4":
                    DeleteTextFile();
                    break;
                case "5":
                    ShowTextContent();
                    break;
                default:
                    break;
            }
        }
        private string[] GetFiles(string mainPath)
        {
            if (!Directory.Exists(mainPath))
                Directory.CreateDirectory(mainPath);
            return Directory.GetFiles(mainPath);
        }
      
        public void Menu()
        {
            string exit = "6", option;
            do
            {
                txtList = GetFiles(mainPath);
                ConsoleDisplayer.displayMenu();
                option = Console.ReadLine();
                Console.Clear();
                ExecuteMenuSeleccion(option);
            } while (option != exit);
        }
        private void OverwriteText()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to edit by its id number", txtList, mainPath);
                SelectTextAndExecuteOrder(textOrderExecutor.overwriteAnEspecificText);
            }
        }
        private void ShowTextContent()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to id to DELETE it", txtList, mainPath);
                SelectTextAndExecuteOrder(textOrderExecutor.ShowAnEspecificTextContent);
            }
        }
        private void SelectTextAndExecuteOrder(Action<int, string[]> funtion)
        {
            int chosenTxt = Convert.ToInt32(Console.ReadLine());
            if (chosenTxt <= txtList.Length)
                funtion(chosenTxt, txtList);
            else
                ConsoleDisplayer.displayErrorMessage("\n\n\nIncorrect txt id", 500);
        }
    }
}
