using System;
using System.IO;
using static System.Console;

namespace SwitchPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\re71688z\Code";
            Write("Press R for readonly and W for write: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            Stream s = null;

            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read);
            }
            else
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write);
            }

            // string message = string.Empty;
            // switch (s)
            // {
            //     case FileStream writeableFile when s.CanWrite:
            //         message = "The stream is a file that I can write to.";
            //         break;

            //     case FileStream readOnlyFile:
            //         message = "The stream is a read-only file.";
            //         break;

            //     case MemoryStream ms:
            //         message = "The stream is a memory address";
            //         break;

            //     default: // always evaluated last despite its current position
            //         message = "The stream is some other type.";
            //         break;
                
            //     case null:
            //         message = "The stream is null";
            //         break;
            // }
            // WriteLine(message);

            string message = s switch
            {
                FileStream when s.CanWrite => "The stream is a file that I can write to.",
                FileStream => "The stream is a read-only file.",
                MemoryStream => "The stream is a memory address",
                null => "The stream is null",
                _ => "The stream is some other type."
            };
            WriteLine(message);
        }
    }
}
