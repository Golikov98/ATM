using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATMLogic
    {
        private int _availabelAmount10;

        public int AvailabelAmount10
        {
            get
            {
                return _availabelAmount10;
            }
            set
            {
                _availabelAmount10 = value;
                if (AvailabelAmount10<=15100)
                {
                    _availabelAmount10 = AvailabelAmount10;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номиналом 10!"); }
            }
        }

        private int _availabelAmount50;

        public int AvailabelAmount50
        {
            get
            {
                return _availabelAmount50;
            }
            set
            {
                _availabelAmount50 = value;
                if (AvailabelAmount50 <= 15100)
                {
                    _availabelAmount50 = AvailabelAmount50;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номиналом 50!"); }
            }
        }

        private int _availabelAmount100;

        public int AvailabelAmount100
        {
            get
            {
                return _availabelAmount100;
            }
            set
            {
                _availabelAmount100 = value;
                if (AvailabelAmount100 <= 61000)
                {
                    _availabelAmount100 = AvailabelAmount100;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номинамол 100!"); }
            }
        }

        private int _availabelAmount200;

        public int AvailabelAmount200
        {
            get
            {
                return _availabelAmount200;
            }
            set
            {
                _availabelAmount200 = value;
                if (AvailabelAmount200 <= 61000)
                {
                    _availabelAmount200 = AvailabelAmount200;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номиналом 200!"); }
            }
        }

        private int _availabelAmount500;

        public int AvailabelAmount500
        {
            get
            {
                return _availabelAmount500;
            }
            set
            {
                _availabelAmount500 = value;
                if (AvailabelAmount500 <= 301000)
                {
                    _availabelAmount500 = AvailabelAmount500;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номиналом 500!"); }
            }
        }

        private int _availabelAmount1000;

        public int AvailabelAmount1000
        {
            get
            {
                return _availabelAmount1000;
            }
            set
            {
                _availabelAmount1000 = value;
                if (AvailabelAmount1000 <= 601000)
                {
                    _availabelAmount1000 = AvailabelAmount1000;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номиналом 1000!"); }
            }
        }

        private int _availabelAmount2000;

        public int AvailabelAmount2000
        {
            get
            {
                return _availabelAmount2000;
            }
            set
            {
                _availabelAmount2000 = value;
                if (AvailabelAmount2000 <= 602000)
                {
                    _availabelAmount2000 = AvailabelAmount2000;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номиналом 2000!"); }
            }
        }

        private int _availabelAmount5000;

        public int AvailabelAmount5000
        {
            get
            {
                return _availabelAmount5000;
            }
            set
            {
                _availabelAmount5000 = value;
                if (AvailabelAmount5000 <= 755000)
                {
                    _availabelAmount5000 = AvailabelAmount5000;
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр номиналом 5000!"); }
            }
        }

        private int _totalAvailabelAmount;

        public int TotalAvailabelAmount
        {
            get
            {
                return _totalAvailabelAmount;
            }
            set
            {
                _totalAvailabelAmount = value;
                if (TotalAvailabelAmount <= 2400000)
                {
                    _totalAvailabelAmount = TotalAvailabelAmount;
                }
                else { throw new ArgumentException("Достигнута предельная сумма!"); }
            }
        }
    }
}
