using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtolAA.Sprint5.TaskReview.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutputFileTask7V10.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((char.IsUpper(line[i])) && (line[i] >= 'A') && (line[i] <= 'Z'))
                        {
                            strline += line[i].ToString().ToLower();
                        }
                        else
                        {
                            strline += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strline + Environment.NewLine);
                    strline = "";
                }

            }
            return pathSaveFile;
        }
    }
}