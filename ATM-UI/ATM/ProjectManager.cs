using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ATM
{
    /// <summary>
    /// Класс ProjectManager содержащий методы SaveToFile и LoadFromFile
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Метод, сериализующий объект в файл
        /// </summary>
        /// <param name="ATMCondition"></param>
        /// <param name="ProjectList"></param>
        public static void SaveToFile(Project ATMCondition, string ProjectList)
        {
            //Записываем в строку ProjectList результат сериализации объекта ATMCondition
            ProjectList = JsonConvert.SerializeObject(ATMCondition, Formatting.Indented);

            //Указываем путь к файлу, в котором будем хранить данные
            StreamWriter SW = new StreamWriter(new FileStream(@"..\ATMCondition.txt", FileMode.Create, FileAccess.Write));

            //Записываем данные из ProjectList в файл по указанному пути
            SW.Write(ProjectList);

            //Закрываем файл
            SW.Close();
        }

        /// <summary>
        /// Метод, который десериализует объект
        /// </summary>
        /// <param name="ProjectList"></param>
        /// <returns></returns>
        public static Project LoadFromFile(string ProjectList)
        {
            try
            {
                //Создаем переменную, в которую помещаем результат десериализации
                Project project = null;

                //Создаем результат десериализации
                JsonSerializer serializer = new JsonSerializer();

                //открываем поток для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(@"..\ATMCondition.txt")) 
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
                return project;
            }
            catch
            {
                return null;
            }
        }
    }
}
