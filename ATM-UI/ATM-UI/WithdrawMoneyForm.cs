using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM;

namespace ATM_UI
{
    /// <summary>
    /// Форма, с помощью которой пользователь может снять средства
    /// </summary>
    public partial class WithdrawMoneyForm : Form
    {
        //Создаем глобальные переменные
        int Sum;
        int Banknote10 = 0;
        int Banknote50 = 0;
        int Banknote100 = 0;
        int Banknote200 = 0;
        int Banknote500 = 0;
        int Banknote1000 = 0;
        int Banknote2000 = 0;
        int Banknote5000 = 0;

        private Project _project = new Project();
        public ATMLogic _ATMLogic = new ATMLogic();

        public WithdrawMoneyForm()
        {
            InitializeComponent();
        }

        private void GiveOutButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            //Считываем данные из файла в переменную _project
            _project = ProjectManager.LoadFromFile(@"..\ATMCondition.txt");

            //Если файл отсутствует
            if (_project == null)
            {
                //Выводим сообщение о том, что банкомат не пополнялся
                DialogResult result = MessageBox.Show("Банкомат не пополнялся, продолжить?", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
            
            //Если выдаваемая сумма меньше 150 000
            if (Sum <= 150000)
            {
                ATMLogic atmLogic = new ATMLogic();               

                if (_project != null)
                {
                    //Создаем переменную, присваимваем ей значение
                    int SumCurrent = 0;

                    //Записываем в переменную CurrentLoadConditions содержимое списка ATMCondition
                    var CurrentLoadConditions = _project.ATMCondition;

                    //Проверяем достаточно ли полной суммы в банкомате
                    if (CurrentLoadConditions[0].TotalAvailabelAmount - Sum >= 0)
                    {             
                        //Проверяем достаточно ли купюр номиналом 10 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount10 - Banknote10 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount10 -= Banknote10;
                            SumCurrent += Banknote10;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 10.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                        }

                        //Проверяем достаточно ли купюр номиналом 50 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount50 - Banknote50 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount50 -= Banknote50;
                            SumCurrent += Banknote50;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 50.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                        }

                        //Проверяем достаточно ли купюр номиналом 100 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount100 - Banknote100 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount100 -= Banknote100;
                            SumCurrent += Banknote100;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                        }

                        //Проверяем достаточно ли купюр номиналом 200 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount200 - Banknote200 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount200 -= Banknote200;
                            SumCurrent += Banknote200;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 200.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                        }

                        //Проверяем достаточно ли купюр номиналом 500 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount500 - Banknote500 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount500 -= Banknote500;
                            SumCurrent += Banknote500;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 500.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                        }

                        //Проверяем достаточно ли купюр номиналом 1000 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount1000 - Banknote1000 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount1000 -= Banknote1000;
                            SumCurrent += Banknote1000;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 1000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                        }

                        //Проверяем достаточно ли купюр номиналом 2000 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount2000 - Banknote2000 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount2000 -= Banknote2000;
                            SumCurrent += Banknote2000;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 2000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();
                        }

                        //Проверяем достаточно ли купюр номиналом 5000 в банкомте
                        if (CurrentLoadConditions[0].AvailabelAmount5000 - Banknote5000 >= 0)
                        {
                            CurrentLoadConditions[0].AvailabelAmount5000 -= Banknote5000;
                            SumCurrent += Banknote5000;
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Недостаточно купюр номиналом 5000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Show();

                        }

                        //Вычитаем из полной суммы банкомата сумму, которую ввел пользователь при выдаче
                        CurrentLoadConditions[0].TotalAvailabelAmount -= SumCurrent;

                        //Передаем данные в абстрактный класс для проверки
                        _ATMLogic.AvailabelAmount10 = CurrentLoadConditions[0].AvailabelAmount10;
                        _ATMLogic.AvailabelAmount50 = CurrentLoadConditions[0].AvailabelAmount50;
                        _ATMLogic.AvailabelAmount100 = CurrentLoadConditions[0].AvailabelAmount100;
                        _ATMLogic.AvailabelAmount200 = CurrentLoadConditions[0].AvailabelAmount200;
                        _ATMLogic.AvailabelAmount500 = CurrentLoadConditions[0].AvailabelAmount500;
                        _ATMLogic.AvailabelAmount1000 = CurrentLoadConditions[0].AvailabelAmount1000;
                        _ATMLogic.AvailabelAmount2000 = CurrentLoadConditions[0].AvailabelAmount2000;
                        _ATMLogic.AvailabelAmount5000 = CurrentLoadConditions[0].AvailabelAmount5000;
                        _ATMLogic.TotalAvailabelAmount = CurrentLoadConditions[0].TotalAvailabelAmount;

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно средств.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();

                        //Передаем данные в абстрактный класс для проверки
                        _ATMLogic.AvailabelAmount10 = CurrentLoadConditions[0].AvailabelAmount10;
                        _ATMLogic.AvailabelAmount50 = CurrentLoadConditions[0].AvailabelAmount50;
                        _ATMLogic.AvailabelAmount100 = CurrentLoadConditions[0].AvailabelAmount100;
                        _ATMLogic.AvailabelAmount200 = CurrentLoadConditions[0].AvailabelAmount200;
                        _ATMLogic.AvailabelAmount500 = CurrentLoadConditions[0].AvailabelAmount500;
                        _ATMLogic.AvailabelAmount1000 = CurrentLoadConditions[0].AvailabelAmount1000;
                        _ATMLogic.AvailabelAmount2000 = CurrentLoadConditions[0].AvailabelAmount2000;
                        _ATMLogic.AvailabelAmount5000 = CurrentLoadConditions[0].AvailabelAmount5000;
                        _ATMLogic.TotalAvailabelAmount = CurrentLoadConditions[0].TotalAvailabelAmount;
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Нельзя выдать более 150 000", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
        }

        private void WithdrawGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Amount10Button_Click_1(object sender, EventArgs e)
        {
            Banknote10 += 10;
            Sum += 10;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void Amount50Button_Click(object sender, EventArgs e)
        {
            Banknote50 += 50;
            Sum += 50;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void Amount100Button_Click(object sender, EventArgs e)
        {
            Banknote100 += 100;
            Sum += 100;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void Amount200Button_Click(object sender, EventArgs e)
        {
            Banknote200 += 200;
            Sum += 200;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void Amount500Button_Click(object sender, EventArgs e)
        {
            Banknote500 += 500;
            Sum += 500;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void Amount1000Button_Click(object sender, EventArgs e)
        {
            Banknote1000 += 1000;
            Sum += 1000;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void Amount2000Button_Click(object sender, EventArgs e)
        {
            Banknote2000 += 2000;
            Sum += 2000;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void Amount5000Button_Click(object sender, EventArgs e)
        {
            Banknote5000 += 5000;
            Sum += 5000;
            string par = Convert.ToString(Sum);
            SumTextBox.Text = par;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void WithdrawMoneyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
