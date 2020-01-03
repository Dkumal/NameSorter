using SortName.Library;
using SortName.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortName.BLL
{
    public class SortingName
    {
        public void SortList(string FileLocation)
        {
            Converter c = new Converter();
            InputOutput io = new InputOutput();

            List<FullNameModel> NameList = c.getFullNameFromText(FileLocation);
            List<NameModel> nameModels = c.GetLastNameOnly(NameList);

            nameModels = nameModels.OrderBy(x => x.LastName).ThenBy(z => z.GivenName).ToList();
            string[] sortedList = c.ConvertToStringArray(nameModels);
            io.writeToText(sortedList);
            io.PrintToScreenConsole(sortedList);
        }
    }
}
