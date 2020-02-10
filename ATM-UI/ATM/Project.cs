using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ATM
{
    /// <summary>
    /// Класс проекта
    /// </summary>
    [Serializable]
    public class Project
    {
        public List<ATMLogic> ATMCondition = new List<ATMLogic>();
    }
}
