using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortName.Library
{
    public class InputOutput
    {
        public void writeToText(string[] data)
        {
            //TextWriter textWriter = new StreamWriter("Files/sorted-names-list.txt");
            ////foreach(string s in data)
            ////{
            ////    textWriter.WriteLine(s);
            ////}
            //File.WriteAllLines("Files/sorted-names-list.txt", data);

            using (StreamWriter file = new StreamWriter("Files/sorted-names-list.txt"))
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
