using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ShtolAA.Sprint5.TaskReview.V10.Lib;

namespace Tyuiu.ShtolAA.Sprint5.TaskReview.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Штоль А.А.| ИИПб-23-3 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: TaskReview                                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Штоль Александра Алексеевна | ИИПб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask7V10.txt (файл взять из архива   *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и        *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор символьных данных.Заменить *");
            Console.WriteLine("* все заглавные латинские буквы на строчные.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint5.Review\Tyuiu.ShtolAA.Sprint5.TaskReview.V10\bin\Debug\InPutDataFileTask7V10.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V10.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadLine();
        }
    }
}
