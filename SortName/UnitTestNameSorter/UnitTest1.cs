using System;
using SortName.BLL;
using SortName.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestNameSorter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            SortingName sort = new SortingName();
            ResultModel result = new ResultModel();

            result = sort.SortList("D:/master/New folder/SortName/SortName/Files/unsorted-names-list.txt");

            Assert.AreEqual(false, result.IsFailed);
        }
    }
}
