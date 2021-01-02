using System;
using System.Diagnostics;
using System.IO;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt"))); 
            //                                              ^ Write to a text file in the project folder.
            
            Trace.AutoFlush = true;
            //    ^ TextWriter is buffered, so this option calls 
            //      Flush() on all listeners after writing.

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");
        }
    }
}
