using System;
using System.IO;
using System.Configuration;

namespace SortName.Library
{
    public class InputOutput
    {
        public void writeToText(string[] data)
        {
            string Dir = ConfigurationSettings.AppSettings.Get("Folder");
            using (StreamWriter file = new StreamWriter(Dir + "/sorted-names-list.txt"))
            {
                foreach(string s in data)
                {
                    file.WriteLine(s);
                }
            }
        }

        public void PrintToScreenConsole(string[] data)
        {
            foreach(string s in data)
            {
                Console.WriteLine(s);
            }
        }
    }
}
