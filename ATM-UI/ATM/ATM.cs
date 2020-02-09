using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
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
                if (_availabelAmount10<5000)
                {
                    if (AvailabelAmount10 == 10)
                    {
                        _availabelAmount10 += AvailabelAmount10;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_availabelAmount50 < 5000)
                {
                    if (AvailabelAmount50 == 50)
                    {
                        _availabelAmount50 += AvailabelAmount50;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_availabelAmount100 < 20000)
                {
                    if (AvailabelAmount100 == 100)
                    {
                        _availabelAmount100 += AvailabelAmount100;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_availabelAmount200 < 20000)
                {
                    if (AvailabelAmount200 == 200)
                    {
                        _availabelAmount200 += AvailabelAmount200;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_availabelAmount500 < 100000)
                {
                    if (AvailabelAmount500 == 500)
                    {
                        _availabelAmount500 += AvailabelAmount500;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_availabelAmount1000 < 200000)
                {
                    if (AvailabelAmount1000 == 1000)
                    {
                        _availabelAmount1000 += AvailabelAmount1000;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_availabelAmount2000 < 200000)
                {
                    if (AvailabelAmount2000 == 2000)
                    {
                        _availabelAmount2000 += AvailabelAmount2000;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_availabelAmount5000 < 250000)
                {
                    if (AvailabelAmount5000 == 5000)
                    {
                        _availabelAmount5000 += AvailabelAmount5000;
                    }
                    else { throw new ArgumentException("Неверная купюра!"); }
                }
                else { throw new ArgumentException("Достигнут предел хранимых купюр!"); }
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
                if (_totalAvailabelAmount < 800000)
                {
                    TotalAvailabelAmount += _availabelAmount10 + _availabelAmount50 + _availabelAmount100 + _availabelAmount200 +
                        _availabelAmount500 + _availabelAmount1000 + _availabelAmount2000 + _availabelAmount5000;

                    _totalAvailabelAmount = TotalAvailabelAmount;
                }
                else { throw new ArgumentException("Достигнута предельная сумма!"); }
            }
        }
    }
}
