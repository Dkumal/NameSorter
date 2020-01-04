using SortName.BLL;
using SortName.Model;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortName.Library;

namespace SortName
{
    class Program
    {
        static void Main(string[] args)
        {
            //string FileLocation = @"C:\Users\andika.r\source\repos\NameSorter\unsorted-names-list.txt";
            ResultModel result = new ResultModel();
            string Dir = ConfigurationSettings.AppSettings.Get("Folder");
            string FileLocation = Dir + "/unsorted-names-list.txt";
            SortingName sorting = new SortingName();
            result = sorting.SortList(FileLocation);
            InputOutput io = new InputOutput();

            io.writeToText(result.Content);
            io.PrintToScreenConsole(result.Content);

            //string ex = Console.ReadLine();

        }
    }
}
