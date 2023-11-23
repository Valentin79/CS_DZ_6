using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sem_6
{
    internal class NegativNumberExeptions: Exception
    {
        public NegativNumberExeptions()
        {

        }
        public NegativNumberExeptions(string error) : base(error)
        {

        }
    }
}
