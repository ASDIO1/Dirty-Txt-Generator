using System;
using System.IO;
using System.Threading;

namespace Txt_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileManager manager = new TextFileManager();
            manager.menu();
        }
    }
}
