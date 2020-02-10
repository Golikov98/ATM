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
    public partial class MainForm : Form
    {
        private Project _project = new Project();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainListBox.SelectedIndex == 0)
            {
                var depositMoney = new DepositMoneyForm();
                depositMoney.ShowDialog();
                if (depositMoney.DialogResult == DialogResult.OK)
                {
                    var _atmLogic = depositMoney._ATMLogic;                  
                    _project.ATMCondition.Insert(0, _atmLogic);


                    ProjectManager.SaveToFile(_project, @"..\ATMCondition.txt");

                }
            }
            else if (MainListBox.SelectedIndex == 1)
            {
                var withdrawForm = new WithdrawMoneyForm();
                withdrawForm.ShowDialog();
                if (withdrawForm.DialogResult == DialogResult.OK)
                {
                    var _atmLogic = withdrawForm._ATMLogic;
                    _project.ATMCondition.Insert(0, _atmLogic);

                    ProjectManager.SaveToFile(_project, @"..\ATMCondition.txt");
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(_project, @"..\ATMCondition.txt");
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ConditionButton_Click(object sender, EventArgs e)
        {
            ConditionForm conditionForm = new ConditionForm();
            conditionForm.ShowDialog();
        }
    }
}
