using System;
using Utility;

namespace YatzyTest
{
    public class ConsoleOperationsStub : IConsoleService
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }

        public string Read()
        {
            return "0";
        }
    }
}