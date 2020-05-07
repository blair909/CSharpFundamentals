using System;
using System.Collections.Generic;
using System.Text;

namespace _11_StreamingContent_UIRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsole console = new ReaLConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
