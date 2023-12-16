using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShtolAA.Sprint5.TaskReview.V10.Lib;

namespace Tyuiu.ShtolAA.Sprint5.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAddSave()
        {
            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint5.Review\Tyuiu.ShtolAA.Sprint5.TaskReview.V10\bin\Debug\InPutDataFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
