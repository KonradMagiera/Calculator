using System.Collections.Generic;

namespace Calculator
{
    class CalcLogic
    {

        public double CurrentValue { get; set; }
        public int Braces { get; set; }
        public CalcLogic()
        {
            CurrentValue = 0.0;
            Braces = 0;
        }

        public string Calculate(string expr)
        {
            Stack<double> values = new Stack<double>();
            Stack<string> operators = new Stack<string>();
            string[] temp = expr.Split(new char[0]);
            string[] elements = new string[temp.Length + 2];
            elements[0] = "(";
            elements[elements.Length - 1] = ")";
            for(int i = 0; i < temp.Length; i++)
            {
                elements[i + 1] = temp[i];
            }

            for(int i = 0; i < elements.Length; i++)
            {
                double value = 0;
                if(double.TryParse(elements[i], out value))
                {
                    values.Push(value);
                }
                else if(elements[i] == "+" || elements[i] == "-" || elements[i] == "*" || elements[i] == "/")
                {
                    operators.Push(elements[i]);
                }
                else if (elements[i] == ")")
                {
                    string op = "+";
                    double secondV = 0;
                    double firstV = 0;
                    if (operators.Count > 0 && values.Count > 1)
                    {


                        op = operators.Pop();
                        secondV = values.Pop();
                        firstV = values.Pop();

                        if (op == "+")
                        {
                            firstV += secondV;
                        }
                        else if (op == "-")
                        {
                            firstV -= secondV;
                        }
                        else if (op == "*")
                        {
                            firstV *= secondV;
                        }
                        else
                        {
                            if (secondV != 0)
                            {
                                firstV /= secondV;
                            }
                            else
                            {
                                return "SYNTAX ERROR";
                            }
                        }
                    }
                    values.Push(firstV);
                    CurrentValue = firstV;
                }
            }

            return CurrentValue.ToString();
        }

    }
}
