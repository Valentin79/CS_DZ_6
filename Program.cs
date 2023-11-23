namespace CS_Sem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            DoubleTryPars doubleTryPars = new DoubleTryPars();

            calc.MyEvent += Calc_MyEvent;

            string action = "";
            Console.WriteLine("Введите число: ");
            calc.Result = doubleTryPars.DoubleTryParse(Console.ReadLine());

            do
            {
                Console.WriteLine("Выберете действие: +, -, *, /, q - для выхода");
                action = Console.ReadLine();
                if (action == "+" || action == "-" || action == "*" || action == "/")
                {
                    Console.WriteLine("Введите число: ");
                    double n = doubleTryPars.DoubleTryParse(Console.ReadLine());
                    switch (action)
                    {
                            case "+": calc.Sum(n); continue;

                            case "*": calc.Mul(n); continue;

                            case "-":
                                try
                                {
                                    calc.Sub(n);
                                }
                                catch (NegativNumberExeptions ex)
                                {
                                Console.WriteLine(ex.Message);
                                }
                            Console.WriteLine($"Result: {calc.Result}");
                            continue;

                            case "/":
                                try {
                                    calc.Div(n);
                                }
                                catch (CalculatorDivideByZeroException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (CalculatorExeption ex)
                                {
                                    Console.WriteLine(ex);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }
                            Console.WriteLine($"Result: {calc.Result}");
                            continue;
                    } 
                }
                else if (!(action == "q" || action == ""))
                {
                    Console.WriteLine("Некорректный оператор");
                }
               

            }
            while (action != "q" && action != "");
            Console.WriteLine("Работа завершена");

        }


        private static void Calc_MyEvent(object? sender, EventArgs e)
        {
            if (sender is Calc)
                Console.WriteLine(((Calc)sender).Result);
        }
    }
}