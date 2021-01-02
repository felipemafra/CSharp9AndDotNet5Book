﻿using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

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

            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(displayName: "PacktSwitch", 
              description: "This switch is set  via a JSON config.");
            
            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLine(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
        }
    }
}
