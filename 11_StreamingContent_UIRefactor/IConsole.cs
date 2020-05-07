using System;

namespace _11_StreamingContent_UIRefactor
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Write(string s);
        void Clear();
        string ReadLine();
        ConsoleKeyInfo ReadKey();
    }
}
