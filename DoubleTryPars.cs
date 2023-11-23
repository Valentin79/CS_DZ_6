using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sem_6
{
    internal class DoubleTryPars
    {
        public double DoubleTryParse(string str)
        {

            try
            {
                double res = double.Parse(str);
                if (res >= 0)
                {
                    return res;
                }
                else
                {
                    Console.WriteLine("Вводить отрицательные числа нельзя по условию задачи :р");
                    return 0;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Введено не число ({str})") ;
                return 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
