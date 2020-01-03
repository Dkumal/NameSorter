using SortName.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortName
{
    class Program
    {
        static void Main(string[] args)
        {
            //string FileLocation = @"C:\Users\andika.r\source\repos\NameSorter\unsorted-names-list.txt";
            string FileLocation = "Files/unsorted-names-list.txt";
            SortingName sorting = new SortingName();
            sorting.SortList(FileLocation);

            string ex = Console.ReadLine();
            
        }
    }
}
