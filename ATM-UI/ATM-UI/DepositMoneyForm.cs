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
    public partial class DepositMoneyForm : Form
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

        public ATMLogic _ATMLogic = new ATMLogic();
        private Project _project = new Project();

        public DepositMoneyForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount10Button_Click(object sender, EventArgs e)
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

        private void InsertButton_Click(object sender, EventArgs e)
        {
            ATMLogic atmLogic = new ATMLogic();
            this.DialogResult = DialogResult.OK;

            //Записываем в переменную _project данные из файла
            _project = ProjectManager.LoadFromFile(@"..\ATMCondition.txt");

            //Если файл отсутствует
            if (_project == null)
            {
                //Проверяем вносимую сумму
                if (Sum <= 300000)
                {
                    //Проверка на кол-во вносимых купюр номиналом 10
                    if (Banknote10 <= 15000)
                    {
                        _ATMLogic.AvailabelAmount10 = Banknote10;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 10.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка на кол-во вносимых купюр номиналом 50
                    if (Banknote50 <= 15000)
                    {
                        _ATMLogic.AvailabelAmount50 = Banknote50;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 50.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка на кол-во вносимых купюр номиналом 100
                    if (Banknote100 <= 60000)
                    {
                        _ATMLogic.AvailabelAmount100 = Banknote100;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка на кол-во вносимых купюр номиналом 200
                    if (Banknote200 <= 60000)
                    {
                        _ATMLogic.AvailabelAmount200 = Banknote200;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 200.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка на кол-во вносимых купюр номиналом 500
                    if (Banknote500 <= 300000)
                    {
                        _ATMLogic.AvailabelAmount500 = Banknote500;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 500.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка на кол-во вносимых купюр номиналом 1000
                    if (Banknote1000 <= 600000)
                    {
                        _ATMLogic.AvailabelAmount1000 = Banknote1000;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 1000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка на кол-во вносимых купюр номиналом 2000
                    if (Banknote2000 <= 600000)
                    {
                        _ATMLogic.AvailabelAmount2000 = Banknote2000;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 2000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка на кол-во вносимых купюр номиналом 5000
                    if (Banknote5000 <= 750000)
                    {
                        _ATMLogic.AvailabelAmount5000 = Banknote5000;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 5000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    _ATMLogic.TotalAvailabelAmount = Sum;

                    //Передаем данные в класс atmLogic для проверки
                    atmLogic.AvailabelAmount10 = Banknote10;
                    atmLogic.AvailabelAmount50 = Banknote50;
                    atmLogic.AvailabelAmount100 = Banknote100;
                    atmLogic.AvailabelAmount200 = Banknote200;
                    atmLogic.AvailabelAmount500 = Banknote500;
                    atmLogic.AvailabelAmount1000 = Banknote1000;
                    atmLogic.AvailabelAmount2000 = Banknote2000;
                    atmLogic.AvailabelAmount5000 = Banknote5000;
                    atmLogic.TotalAvailabelAmount = Sum;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Нельзя вносить более 300 000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Show();
                }
            }


            //Если файл не отсутствует
            if (_project != null)
            {
                var CurrentLoadConditions = _project.ATMCondition;

                //Если сумма, хранящаяся в данкомате + сумма, вносимая пользователем меньше либо равно 300 000
                if (CurrentLoadConditions[0].TotalAvailabelAmount + Sum <= 300000)
                {
                    //Проверка наличия места в хранилище купюр номиналом 10
                    if (CurrentLoadConditions[0].AvailabelAmount10 + Banknote10 <= 15000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount10 += Banknote10;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 10.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка наличия места в хранилище купюр номиналом 50
                    if (CurrentLoadConditions[0].AvailabelAmount50 + Banknote50 <= 15000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount50 += Banknote50;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 50.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка наличия места в хранилище купюр номиналом 100
                    if (CurrentLoadConditions[0].AvailabelAmount100 + Banknote100 <= 60000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount100 += Banknote100;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка наличия места в хранилище купюр номиналом 200
                    if (CurrentLoadConditions[0].AvailabelAmount200 + Banknote200 <= 60000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount200 += Banknote200;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 200.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка наличия места в хранилище купюр номиналом 500
                    if (CurrentLoadConditions[0].AvailabelAmount500 + Banknote500 <= 300000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount500 += Banknote500;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 500.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка наличия места в хранилище купюр номиналом 1000
                    if (CurrentLoadConditions[0].AvailabelAmount1000 + Banknote1000 <= 600000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount1000 += Banknote1000;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 1000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка наличия места в хранилище купюр номиналом 2000
                    if (CurrentLoadConditions[0].AvailabelAmount2000 + Banknote2000 <= 600000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount2000 += Banknote2000;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 2000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();
                    }

                    //Проверка наличия места в хранилище купюр номиналом 5000
                    if (CurrentLoadConditions[0].AvailabelAmount5000 + Banknote5000 <= 750000)
                    {
                        CurrentLoadConditions[0].AvailabelAmount5000 += Banknote5000;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Недостаточно места в хранилище купюр номиналом 5000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Show();

                    }
                    CurrentLoadConditions[0].TotalAvailabelAmount += Sum;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Нельзя вносить более 300 000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Show();
                }

                //Передаем данные в абстрактный класс
                _ATMLogic.AvailabelAmount10 = CurrentLoadConditions[0].AvailabelAmount10;
                _ATMLogic.AvailabelAmount50 = CurrentLoadConditions[0].AvailabelAmount50;
                _ATMLogic.AvailabelAmount100 = CurrentLoadConditions[0].AvailabelAmount100;
                _ATMLogic.AvailabelAmount200 = CurrentLoadConditions[0].AvailabelAmount200;
                _ATMLogic.AvailabelAmount500 = CurrentLoadConditions[0].AvailabelAmount500;
                _ATMLogic.AvailabelAmount1000 = CurrentLoadConditions[0].AvailabelAmount1000;
                _ATMLogic.AvailabelAmount2000 = CurrentLoadConditions[0].AvailabelAmount2000;
                _ATMLogic.AvailabelAmount5000 = CurrentLoadConditions[0].AvailabelAmount5000;
                _ATMLogic.TotalAvailabelAmount = CurrentLoadConditions[0].TotalAvailabelAmount;

                //Передаем данные на проверку
                atmLogic.AvailabelAmount10 = CurrentLoadConditions[0].AvailabelAmount10;
                atmLogic.AvailabelAmount50 = CurrentLoadConditions[0].AvailabelAmount50;
                atmLogic.AvailabelAmount100 = CurrentLoadConditions[0].AvailabelAmount100;
                atmLogic.AvailabelAmount200 = CurrentLoadConditions[0].AvailabelAmount200;
                atmLogic.AvailabelAmount500 = CurrentLoadConditions[0].AvailabelAmount500;
                atmLogic.AvailabelAmount1000 = CurrentLoadConditions[0].AvailabelAmount1000;
                atmLogic.AvailabelAmount2000 = CurrentLoadConditions[0].AvailabelAmount2000;
                atmLogic.AvailabelAmount5000 = CurrentLoadConditions[0].AvailabelAmount5000;
                atmLogic.TotalAvailabelAmount = CurrentLoadConditions[0].TotalAvailabelAmount;
            }
        }

        private void DepositMoneyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
