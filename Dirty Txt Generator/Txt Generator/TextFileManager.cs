using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Txt_Generator
{
    class TextFileManager
    {
        string mainPath;
        string[] txtList;
        public TextFileManager()
        {
            mainPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", "SavedTexts"));
            txtList = getFiles(mainPath);
        }

       
        private string[] getFiles(string mainPath) {
            if (!Directory.Exists(mainPath))
            {
                Directory.CreateDirectory(mainPath);
            }
            return Directory.GetFiles(mainPath);
        }
        public void menu() {
            string exit = "6", option;
            do
            {
                txtList = getFiles(mainPath);
                ConsoleDisplayer.displayMenu();
                option = Console.ReadLine();
                Console.Clear();
                executeMenuSeleccion(option);
            } while (option != exit);
        }
        private void executeMenuSeleccion(string option) {
            switch (option)
            {
                case "1":
                    overwriteText();
                    break;
                case "2":
                    createNewText();
                    break;
                case "3":
                    deleteTextContent();
                    break;
                case "4":
                    deleteTextFile();
                    break;
                case "5":
                    showTextContent();
                    break;
                default:
                    break;
            }
        }
        private void showTextContent()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to id to DELETE it", txtList, mainPath);
                selectTextAndExecutFuntion(ShowAnEspecificTextContent);
            }
        }

        private void deleteTextFile()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to id to DELETE it", txtList, mainPath);
                int chosenTxt = Convert.ToInt32(Console.ReadLine());
                if (chosenTxt <= txtList.Length)
                {
                    string specificTxtPath = $"{txtList[chosenTxt]}";
                    File.Delete(specificTxtPath);
                }
                else
                    ConsoleDisplayer.displayErrorMessage("\n\n\nIncorrect txt id", 500);
            }
        }

        private void deleteTextContent()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to edit by its id number", txtList, mainPath);
                selectTextAndExecutFuntion(deleteAnEspecificTextContent);
            }
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

        private void overwriteText()
        {
            if (txtList.Length <= 0)
                ConsoleDisplayer.displayErrorMessage("\n\nNo txt files found. CREATE A NEW ONE", 1000);
            else
            {
                ConsoleDisplayer.displayFilesListAndMessage("Choose a text file to edit by its id number", txtList, mainPath);
                selectTextAndExecutFuntion(overwriteAnEspecificText);
            }
            
        }

        private void selectTextAndExecutFuntion(Action<int, string[]> funtion)
        {
            int chosenTxt = Convert.ToInt32(Console.ReadLine());
            if (chosenTxt <= txtList.Length)
                overwriteAnEspecificText(chosenTxt, txtList);
            else
                ConsoleDisplayer.displayErrorMessage("\n\n\nIncorrect txt id", 500);
        }

        Action<int, string[]> overwriteAnEspecificText = (chosenTxt, txtList) =>
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
            ConsoleDisplayer.displayMessage("Chose your new Txt name", ConsoleColor.Cyan, true);
            ConsoleDisplayer.displayMessage("\nContinue writting some text:  ", ConsoleColor.DarkCyan, true);
            string userText = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(txtList[chosenTxt], true))
            {
                sw.WriteLine(userText);
                sw.Close();
            }
        };

        Action<int, string[]> deleteAnEspecificTextContent = (chosenTxt, txtList) =>
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


        Action<int, string[]> ShowAnEspecificTextContent = (chosenTxt, txtList) =>
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
    }
}
