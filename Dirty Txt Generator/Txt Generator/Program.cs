using System;
using System.IO;
using System.Threading;

namespace Txt_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", "SavedTexts"));
            int chosenTxt;
            string specificTxtPath;
            string userText;
            bool exit = false;


            while (exit == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("------TXT EDITOR MAIN MENU--------");
                Console.WriteLine("1) Overwrite text");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("2) CREATE new text");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3) Delete text content");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("4) Delete a hole text");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("5) Show a txt content");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("6) Exit");
                Console.Write("\nChoose an option:");
                var option = Console.ReadLine();

                if (!Directory.Exists(mainPath))
                {
                    Directory.CreateDirectory(mainPath);
                }
                var txtList = Directory.GetFiles(mainPath);

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        if (txtList.Length <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nNo txt files found. CREATE A NEW ONE");
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Choose a text file to edit by its id number");
                        Console.WriteLine("----Files List----");
                        for (int i = 0; i < txtList.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"{i}) {txtList[i].Replace(mainPath, "")}");
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n choose file: ");
                        chosenTxt = Convert.ToInt32(Console.ReadLine());
                        if (chosenTxt <= txtList.Length)
                        {
                            specificTxtPath = $"{txtList[chosenTxt]}";
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
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nContinue writting some text:  ");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            userText = Console.ReadLine();
                            using (StreamWriter sw = new StreamWriter(txtList[chosenTxt], true)) 
                            {
                                sw.WriteLine(userText);
                                sw.Close();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\nIncorrect txt id");
                            Thread.Sleep(500);
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Chose your new Txt name");
                        Console.Write("name: ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        string newTxtName = Console.ReadLine();
                        string newTxt = $"{mainPath}/{newTxtName}.txt";
                        if (!File.Exists(newTxt))
                        {
                            var myNewFile = File.Create(newTxt);
                            myNewFile.Close();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        if (txtList.Length <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nNo txt files found. CREATE A NEW ONE");
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Choose a text file to edit by its id number");
                        Console.WriteLine("----Files List----");
                        for (int i = 0; i < txtList.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"{i}) {txtList[i].Replace(mainPath, "")}");
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n choose file: ");
                        chosenTxt = Convert.ToInt32(Console.ReadLine());
                        if (chosenTxt <= txtList.Length)
                        {
                            specificTxtPath = $"{txtList[chosenTxt]}";
                            using (StreamWriter sw = new StreamWriter(specificTxtPath, false))
                            {
                                sw.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\nIncorrect txt id");
                            Thread.Sleep(500);
                        }
                        break;
                    case "4":
                        Console.Clear();
                        if (txtList.Length <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nNo txt files found. CREATE A NEW ONE");
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Choose a text file to id to DELETE it");
                        Console.WriteLine("----Files List----");
                        for (int i = 0; i < txtList.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"{i}) {txtList[i].Replace(mainPath, "")}");
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n choose file: ");
                        chosenTxt = Convert.ToInt32(Console.ReadLine());
                        if (chosenTxt <= txtList.Length)
                        {
                            specificTxtPath = $"{txtList[chosenTxt]}";
                            File.Delete(specificTxtPath);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\nIncorrect txt id");
                            Thread.Sleep(500);
                        }
                        break;
                    case "5":
                        Console.Clear();
                        if (txtList.Length <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nNo txt files found. CREATE A NEW ONE");
                            Thread.Sleep(1000);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Choose a text file to id to DELETE it");
                        Console.WriteLine("----Files List----");
                        for (int i = 0; i < txtList.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine($"{i}) {txtList[i].Replace(mainPath, "")}");
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n choose file: ");
                        chosenTxt = Convert.ToInt32(Console.ReadLine());
                        if (chosenTxt <= txtList.Length)
                        {
                            specificTxtPath = $"{txtList[chosenTxt]}";
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
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nPress Enter to continue");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\n\nIncorrect txt id");
                            Thread.Sleep(500);
                        }
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
