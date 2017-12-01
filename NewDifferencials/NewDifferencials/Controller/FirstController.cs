using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewDifferencials.Model;

namespace NewDifferencials.Controller
{
    public class FirstController:IController
    {
        private List<P> Pi;
        private List<P> Pij;

        public override ResultContainer Calculate(IDataContainer dataContainer)
        {
            if (!(dataContainer is FirstDataContainer))
            {
                throw new Exception("Неверный тип контейнера");
            }
            FirstDataContainer data = (FirstDataContainer) dataContainer;
            double H = data.Time/data.TimeSteps;

            FirstConstructor constuctor = new FirstConstructor();
            constuctor.CreateModel(data.ModelComponents, data.Lambda, data.Mu, data.Mui, H);
            Pi = constuctor.Pi;
            Pij = constuctor.Pij;

            ResultContainer result = new ResultContainer();
            double error = 0;
            for (int i = 0; i <= data.TimeSteps; i++)
            {
                result.Times.Add(H*i);
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

        protected override void CalculateK1()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK1();
                Pij[k].CalculateK1();
            }
            Pi[Pi.Count - 1].CalculateK1();
        }

        protected override void CalculateK2()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK2();
                Pij[k].CalculateK2();
            }
            Pi[Pi.Count - 1].CalculateK2();
        }

        protected override void CalculateK3()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK3();
                Pij[k].CalculateK3();
            }
            Pi[Pi.Count - 1].CalculateK3();
        }

        protected override void CalculateK4()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK4();
                Pij[k].CalculateK4();
            }
            Pi[Pi.Count - 1].CalculateK4();
        }

        protected override void CalculateNextValue()
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
