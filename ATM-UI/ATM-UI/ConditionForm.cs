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
    public partial class ConditionForm : Form
    {
        private Project _project = new Project();

        public ConditionForm()
        {
            InitializeComponent();
        }

        private void CashLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bancnot10TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bancnot50TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bancnot100TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bancnot200TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bancnot500TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bancnot1000TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bancnot2000TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bancnot5000TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalSumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConditionForm_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.LoadFromFile(@"..\ATMCondition.txt");
            if (_project != null)
            {
                var CurrentValueList = _project.ATMCondition;
                string textValueTotal = Convert.ToString(CurrentValueList[0].TotalAvailabelAmount);
                TotalSumTextBox.Text = textValueTotal;
                string textValue5000 = Convert.ToString(CurrentValueList[0].AvailabelAmount5000);
                Bancnot5000TextBox.Text = textValue5000;
                string textValue2000 = Convert.ToString(CurrentValueList[0].AvailabelAmount2000);
                Bancnot2000TextBox.Text = textValue2000;
                string textValue1000 = Convert.ToString(CurrentValueList[0].AvailabelAmount1000);
                Bancnot1000TextBox.Text = textValue1000;
                string textValue500 = Convert.ToString(CurrentValueList[0].AvailabelAmount500);
                Bancnot500TextBox.Text = textValue500;
                string textValue200 = Convert.ToString(CurrentValueList[0].AvailabelAmount200);
                Bancnot200TextBox.Text = textValue200;
                string textValue100 = Convert.ToString(CurrentValueList[0].AvailabelAmount100);
                Bancnot100TextBox.Text = textValue100;
                string textValue50 = Convert.ToString(CurrentValueList[0].AvailabelAmount50);
                Bancnot50TextBox.Text = textValue50;
                string textValue10 = Convert.ToString(CurrentValueList[0].AvailabelAmount10);
                Bancnot10TextBox.Text = textValue10;
            }
            else
            {
                string textValueTotal = Convert.ToString('0');
                TotalSumTextBox.Text = textValueTotal;
                string textValue5000 = Convert.ToString('0');
                Bancnot5000TextBox.Text = textValue5000;
                string textValue2000 = Convert.ToString('0');
                Bancnot2000TextBox.Text = textValue2000;
                string textValue1000 = Convert.ToString('0');
                Bancnot1000TextBox.Text = textValue1000;
                string textValue500 = Convert.ToString('0');
                Bancnot500TextBox.Text = textValue500;
                string textValue200 = Convert.ToString('0');
                Bancnot200TextBox.Text = textValue200;
                string textValue100 = Convert.ToString('0');
                Bancnot100TextBox.Text = textValue100;
                string textValue50 = Convert.ToString('0');
                Bancnot50TextBox.Text = textValue50;
                string textValue10 = Convert.ToString('0');
                Bancnot10TextBox.Text = textValue10;
            }
        }
    }
}
