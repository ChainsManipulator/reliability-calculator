using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewDifferencials.Model;

namespace NewDifferencials.Controller
{
    public class ThirdController:IController
    {
        private List<P> Pi;
        private List<P> Pij;
        private List<P> Pji;
        private List<P> Pik;
        private List<P> Pil;

        public override ResultContainer Calculate(IDataContainer dataContainer)
        {
            if (!(dataContainer is ThirdDataContainer))
            {
                throw new Exception("Неверный тип контейнера");
            }
            ThirdDataContainer data = (ThirdDataContainer)dataContainer;
            double H = data.Time / data.TimeSteps;

            ThirdConstructor constuctor = new ThirdConstructor();
            constuctor.CreateModel(data.ModelComponents, data.Lambda, data.Mu, data.e, data.v, data.Mu1, data.Mu2, data.Mu3, data.Mu4, H);
            Pi = constuctor.Pi;
            Pij = constuctor.Pij;
            Pji = constuctor.Pji;
            Pik = constuctor.Pik;
            Pil = constuctor.Pil;

            ResultContainer result = new ResultContainer();
            double error = 0;
            for (int i = 0; i <= data.TimeSteps; i++)
            {
                result.Times.Add(H * i);
                result.Values.Add(Pi[Pi.Count - 1].CurrentValue);

                double Summ = 0;
                for (int j = 0; j < Pij.Count; j++)
                {
                    Summ += Pi[j].CurrentValue + Pij[j].CurrentValue + Pji[j].CurrentValue + Pik[j].CurrentValue +
                            Pil[j].CurrentValue;
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
                Pji[k].CalculateK1();
                Pik[k].CalculateK1();
                Pil[k].CalculateK1();
            }
            Pi[Pi.Count - 1].CalculateK1();
        }

        protected override void CalculateK2()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK2();
                Pij[k].CalculateK2();
                Pji[k].CalculateK2();
                Pik[k].CalculateK2();
                Pil[k].CalculateK2();
            }
            Pi[Pi.Count - 1].CalculateK2();
        }

        protected override void CalculateK3()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK3();
                Pij[k].CalculateK3();
                Pji[k].CalculateK3();
                Pik[k].CalculateK3();
                Pil[k].CalculateK3();
            }
            Pi[Pi.Count - 1].CalculateK3();
        }

        protected override void CalculateK4()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateK4();
                Pij[k].CalculateK4();
                Pji[k].CalculateK4();
                Pik[k].CalculateK4();
                Pil[k].CalculateK4();
            }
            Pi[Pi.Count - 1].CalculateK4();
        }

        protected override void CalculateNextValue()
        {
            for (int k = 0; k < Pij.Count; k++)
            {
                Pi[k].CalculateNextValue();
                Pij[k].CalculateNextValue();
                Pji[k].CalculateNextValue();
                Pik[k].CalculateNextValue();
                Pil[k].CalculateNextValue();
            }
            Pi[Pi.Count - 1].CalculateNextValue();
        }
    }
}
