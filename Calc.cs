using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sem_6
{


    internal class Calc : ICalc
    {
        public double Result { get; set; }
        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public event EventHandler<EventArgs> MyEvent;

            private void PrintEvent()
            {
            Console.Write("Result: ");
            MyEvent?.Invoke(this, new EventArgs());
            }

        public void Div(double x)
        {
            if (x != 0) { 
                Result /= x;
                PrintEvent();
                LastResult.Push(Result);
            }
            else
                throw new CalculatorDivideByZeroException("Ошибка: деление на ноль недопустимо");
                

        }

            public void Mul(double x)
            {
                Result *= x;
                PrintEvent();
                LastResult.Push(Result);
            }

        public void Sub(double x)
        {
            double res = Result - x;
            if (res >= 0)
            {
                Result = res;
                PrintEvent();
                LastResult.Push(Result);
            }
            else 
                throw new NegativNumberExeptions
                    ($"Результат не может быть меньше 0 по условию задания :р (у вас: {res})");
                
        }

            public void Sum(double x)
            {
                Result += x;
                PrintEvent();
                LastResult.Push(Result);
            }

            public void CancelLast()
            {
                if (LastResult.TryPop(out double res))
                {
                    Result = res;
                    Console.WriteLine("Canceled");
                    PrintEvent();
                }
                else
                {
                    Console.WriteLine("Невозможно отменить");
                }
            }    
    }

}
