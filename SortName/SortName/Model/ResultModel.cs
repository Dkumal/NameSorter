using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortName.Model
{
    public class ResultModel
    {
        public bool IsFailed { get; set; }
        public string ErrorMessage { get; set; }
        public dynamic Content { get; set; }
    }
}
