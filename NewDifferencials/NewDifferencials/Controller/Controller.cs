using System;
using System.Collections.Generic;
using NewDifferencials.Model;

namespace NewDifferencials.Controller
{
    public class Controller
    {
        private List<P> Pi;
        private List<P> Pij;

        protected void CalculateNextStep()
        {
            CalculateK1();
            CalculateK2();
            CalculateK3();
            CalculateK4();
            CalculateNextValue();
        }

        public ResultContainer Calculate(DataContainer dataContainer)
        {
            if (!(dataContainer is DataContainer))
            {
                throw new Exception("Неверный тип контейнера");
            }

            double H = dataContainer.Time / dataContainer.TimeSteps;

            Constructor constuctor = new Constructor();
            constuctor.CreateModel(dataContainer.ModelComponents, dataContainer.Lambda, dataContainer.Mu, dataContainer.Mui, H);
            Pi = constuctor.Pi;
            Pij = constuctor.Pij;

            ResultContainer result = new ResultContainer();
            double error = 0;

            for (int i = 0; i <= dataContainer.TimeSteps; i++)
            {
                result.Times.Add(H * i);
                result.Values.Add(Pi[Pi.Count - 1].CurrentValue);

                double Summ = 0;
                for (int j = 0; j < Pij.Count; j++)
                {
                    Summ += Pi[j].CurrentValue + Pij[j].CurrentValue;
                }
                error += Math.Abs(1 - Summ - Pi[Pi.Count - 1].CurrentValue);
                result.Errors.Add(error);

                CalculateNextStep();
            }

            return result;
        }

        protected void CalculateK1()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK1();
                Pij[k].CalculateK1();
            }

            Pi[Pi.Count - 1].CalculateK1();
        }

        protected void CalculateK2()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK2();
                Pij[k].CalculateK2();
            }

            Pi[Pi.Count - 1].CalculateK2();
        }

        protected void CalculateK3()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK3();
                Pij[k].CalculateK3();
            }

            Pi[Pi.Count - 1].CalculateK3();
        }

        protected void CalculateK4()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK4();
                Pij[k].CalculateK4();
            }

            Pi[Pi.Count - 1].CalculateK4();
        }

        protected void CalculateNextValue()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateNextValue();
                Pij[k].CalculateNextValue();
            }

            Pi[Pi.Count - 1].CalculateNextValue();
        }
    }
}
