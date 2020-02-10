using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ATM;

namespace ATMUnitTest
{
    class ProjectManagerUnitTest
    {
        [Test(Description = "Позитивный тест метода SaveToFile и метода LoadFromFile")]
        public void ProjectManagerSaveToFileTest()
        {
            ATMLogic atmLogic = new ATMLogic();
            Project project = new Project();

            atmLogic.AvailabelAmount10 = 10;
            atmLogic.AvailabelAmount50 = 50;
            atmLogic.AvailabelAmount100 = 100;
            atmLogic.AvailabelAmount200 = 200;
            atmLogic.AvailabelAmount500 = 500;
            atmLogic.AvailabelAmount1000 = 1000;
            atmLogic.AvailabelAmount2000 = 2000;
            atmLogic.AvailabelAmount5000 = 5000;
            atmLogic.TotalAvailabelAmount = 8860;

            project.ATMCondition.Insert(0, atmLogic);

            //Вызываем SaveToFile из класса ProjectManager
            ProjectManager.SaveToFile(project, @"..\ATMCondition.txt");

            //Записываем данные из файла в переменную "project" при помощи метода LoadFromFile
            project = ProjectManager.LoadFromFile(@"..\ATMCondition.txt");

            ATMLogic item = new ATMLogic();

            //Записываем данные из списка ATMCondition в переменную "item"
            item = project.ATMCondition[0];

            var Count10 = atmLogic.AvailabelAmount10;
            var Count10Load = item.AvailabelAmount10;
            Assert.AreEqual(Count10, Count10Load, "Если не возникает исключения, то тест пройден");

            var Count50 = atmLogic.AvailabelAmount50;
            var Count50Load = item.AvailabelAmount50;
            Assert.AreEqual(Count50, Count50Load, "Если не возникает исключения, то тест пройден");

            var Count100 = atmLogic.AvailabelAmount100;
            var Count100Load = item.AvailabelAmount100;
            Assert.AreEqual(Count100, Count100Load, "Если не возникает исключения, то тест пройден");

            var Count200 = atmLogic.AvailabelAmount200;
            var Count200Load = item.AvailabelAmount200;
            Assert.AreEqual(Count200, Count200Load, "Если не возникает исключения, то тест пройден");

            var Count500 = atmLogic.AvailabelAmount500;
            var Count500Load = item.AvailabelAmount500;
            Assert.AreEqual(Count500, Count500Load, "Если не возникает исключения, то тест пройден");

            var Count1000 = atmLogic.AvailabelAmount1000;
            var Count1000Load = item.AvailabelAmount1000;
            Assert.AreEqual(Count1000, Count1000Load, "Если не возникает исключения, то тест пройден");

            var Count2000 = atmLogic.AvailabelAmount2000;
            var Count2000Load = item.AvailabelAmount2000;
            Assert.AreEqual(Count2000, Count2000Load, "Если не возникает исключения, то тест пройден");

            var Count5000 = atmLogic.AvailabelAmount5000;
            var Count5000Load = item.AvailabelAmount5000;
            Assert.AreEqual(Count5000, Count5000Load, "Если не возникает исключения, то тест пройден");

            var TotalCount = atmLogic.TotalAvailabelAmount;
            var TotalCounLoad = item.TotalAvailabelAmount;
            Assert.AreEqual(TotalCount, TotalCounLoad, "Если не возникает исключения, то тест пройден");

            project.ATMCondition.Clear();

            System.IO.File.Delete(@"..\ATMCondition.txt");
        }
    }
}
