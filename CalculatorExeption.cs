using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sem_6
{
    internal class CalculatorExeption: Exception
    {
        public CalculatorExeption()
        {

        }
        public CalculatorExeption(string error) : base(error)
        {

        }
    }
}
