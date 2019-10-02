using System;

namespace Utility
{
    public class ConsoleOperations:IConsoleService
    {
        public void Write(string content)
        {
           Console.WriteLine(content);
        }

        public string Read()
        {
            return Console.ReadLine();
        }
    }
}