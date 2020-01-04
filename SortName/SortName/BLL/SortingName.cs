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
        public ResultModel SortList(string FileLocation)
        {

            try
            {
                Converter c = new Converter();
                InputOutput io = new InputOutput();

                List<FullNameModel> NameList = c.getFullNameFromText(FileLocation);
                List<NameModel> nameModels = c.GetLastNameOnly(NameList);

                nameModels = nameModels.OrderBy(x => x.LastName).ThenBy(z => z.GivenName).ToList();
                string[] sortedList = c.ConvertToStringArray(nameModels);
                

                return new ResultModel
                {
                    IsFailed = false,
                    ErrorMessage = "Sorting Succeed",
                    Content = sortedList
                };
            }
            catch (Exception ex)
            {
                return new ResultModel {
                    IsFailed = true,
                    ErrorMessage = ex.Message,
                    Content = null
                };
            }
            
        }
    }
}
