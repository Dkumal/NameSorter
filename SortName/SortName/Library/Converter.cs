using SortName.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortName.Library
{
    public class Converter
    {
        public List<FullNameModel> getFullNameFromText(string filePath)
        {
            string strdata = File.ReadAllText(filePath);

            string[] rowdata = strdata.Split("\r\n\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<FullNameModel> emplist = new List<FullNameModel>();
            foreach (string sturecord in rowdata)
            {
                FullNameModel Emp = new FullNameModel();
                string[] splitdata = strdata.Split(
                    new[] { "\r\n", "\r", "\n" },
                    StringSplitOptions.None
                    );
                Emp.FullName = sturecord.Split(' ');
                Emp.counterIndex = Emp.FullName.Count();
                emplist.Add(Emp);
            }

            return emplist;
        }

        public List<NameModel> GetLastNameOnly(List<FullNameModel> data)
        {
            List<NameModel> nameModels = new List<NameModel>();

            for (int i = 0; i < data.Count(); i++)
            {
                NameModel xxx = new NameModel();
                int index = data[i].counterIndex;
                xxx.GivenName = GetFirstName(data[i]);
                xxx.LastName = data[i].FullName[(index - 1)].ToString();
                xxx.Index = i;
                nameModels.Add(xxx);
            }

            return nameModels;
        }

        private string GetFirstName(FullNameModel data)
        {
            string GivenName = string.Empty;

            for(int i =0; i < data.counterIndex - 1; i++)
            {
                GivenName += data.FullName[i] + " ";
            }

            return GivenName;
        }

        public string[] ConvertToStringArray(List<NameModel> data)
        {
            string[] result= new string[data.Count];
            int counter = 0;
            foreach(NameModel nm in data)
            {
                result[counter] = string.Concat(nm.GivenName, " ", nm.LastName);
                counter++;
            }

            return result;
        }
    }
}
