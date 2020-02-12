using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM;
using NUnit.Framework;

namespace ATMUnitTests
{
    /// <summary>
    /// Класс ATMLogicUnitTest, содержащий Unit-тесты для тестирования класса ATMLogic
    /// </summary>
    [TestFixture]
    public class ATMLogicUnitTest
    {
        [Test(Description = "Позитивный тест геттера AvailabelAmount10")]
        public void TestAvailabelAmount10Get_CorrectValue()
        {
            var expected = 10;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount10 = expected;
            var actual = atmLogic.AvailabelAmount10;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount10 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount10")]
        public void TestAvailabelAmount10Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount10 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 15100");
        }

        [Test(Description = "Позитивный тест геттера AvailabelAmount50")]
        public void TestAvailabelAmount50Get_CorrectValue()
        {
            var expected = 50;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount50 = expected;
            var actual = atmLogic.AvailabelAmount50;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount50 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount50")]
        public void TestAvailabelAmount50Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount50 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 15100");
        }

        [Test(Description = "Позитивный тест геттера AvailabelAmount100")]
        public void TestAvailabelAmount100Get_CorrectValue()
        {
            var expected = 100;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount100 = expected;
            var actual = atmLogic.AvailabelAmount100;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount100 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount100")]
        public void TestAvailabelAmount100Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount100 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 61000");
        }

        [Test(Description = "Позитивный тест геттера AvailabelAmount200")]
        public void TestAvailabelAmount200Get_CorrectValue()
        {
            var expected = 200;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount200 = expected;
            var actual = atmLogic.AvailabelAmount200;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount200 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount200")]
        public void TestAvailabelAmount200Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount200 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 61000");
        }

        [Test(Description = "Позитивный тест геттера AvailabelAmount500")]
        public void TestAvailabelAmount500Get_CorrectValue()
        {
            var expected = 500;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount500 = expected;
            var actual = atmLogic.AvailabelAmount500;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount500 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount500")]
        public void TestAvailabelAmount500Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount500 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 301000");
        }

        [Test(Description = "Позитивный тест геттера AvailabelAmount1000")]
        public void TestAvailabelAmount1000Get_CorrectValue()
        {
            var expected = 1000;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount1000 = expected;
            var actual = atmLogic.AvailabelAmount1000;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount1000 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount1000")]
        public void TestAvailabelAmount1000Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount1000 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 601000");
        }

        [Test(Description = "Позитивный тест геттера AvailabelAmount2000")]
        public void TestAvailabelAmount2000Get_CorrectValue()
        {
            var expected = 2000;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount2000 = expected;
            var actual = atmLogic.AvailabelAmount2000;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount2000 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount2000")]
        public void TestAvailabelAmount2000Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount2000 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 602000");
        }

        [Test(Description = "Позитивный тест геттера AvailabelAmount5000")]
        public void TestAvailabelAmount5000Get_CorrectValue()
        {
            var expected = 5000;
            var atmLogic = new ATMLogic();
            atmLogic.AvailabelAmount5000 = expected;
            var actual = atmLogic.AvailabelAmount5000;

            Assert.AreEqual(expected, actual, "Геттер AvailabelAmount5000 возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения AvailabelAmount5000")]
        public void TestAvailabelAmount5000Set_CorrectValue()
        {
            var UncorrectValue = 1000000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.AvailabelAmount5000 = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 755000");
        }

        [Test(Description = "Позитивный тест геттера TotalAvailabelAmount")]
        public void TestTotalAvailabelAmountGet_CorrectValue()
        {
            var expected = 5000;
            var atmLogic = new ATMLogic();
            atmLogic.TotalAvailabelAmount = expected;
            var actual = atmLogic.TotalAvailabelAmount;

            Assert.AreEqual(expected, actual, "Геттер TotalAvailabelAmount возвращает неправильное имя заметки");
        }

        [Test(Description = "Присвоение неверного значения TotalAvailabelAmount")]
        public void TestTotalAvailabelAmountSet_CorrectValue()
        {
            var UncorrectValue = 2500000;
            var atmLogic = new ATMLogic();

            Assert.Throws<ArgumentException>(() => { atmLogic.TotalAvailabelAmount = UncorrectValue; },
               "Должно возникать исключение, если сумма банкнот больше 2400000");
        }
    }
}
