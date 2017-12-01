using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewDifferencials.Model
{
    public class P
    {
        private List<P> Inputs;
        private List<double> InputsLambda;
        private List<double> OutputsLambda;

        private double currentValue;
        private double nextValue;

        private double K1;
        private double K2;
        private double K3;
        private double K4;
        private double H;

        public double CurrentValue
        {
            get { return currentValue; }
        }

        public double k1
        {
            get { return K1; }
        }

        public double k2
        {
            get { return K2; }
        }

        public double k3
        {
            get { return K3; }
        }

        public double k4
        {
            get { return K4; }
        }

        public P(List<P> inputs, List<double> inputsLambda, List<double> outputsLambda, double initialValue, double h)
        {
            Inputs = inputs;
            InputsLambda = inputsLambda;
            OutputsLambda = outputsLambda;
            currentValue = initialValue;
            H = h;
        }

        public P(double initialValue, double h)
        {
            Inputs = new List<P>();
            InputsLambda = new List<double>();
            OutputsLambda = new List<double>();
            currentValue = initialValue;
            H = h;
        }

        public void AddInput(P input, double lambda)
        {
            Inputs.Add(input);
            InputsLambda.Add(lambda);
        }

        public void AddOutput(double lambda)
        {
            OutputsLambda.Add(lambda);
        }

        public double CalculateK1()
        {
            double temp = 0;
            for (int i = 0; i < Inputs.Count; i++)
            {
                temp += Inputs[i].CurrentValue*InputsLambda[i];
            }
            for (int j = 0; j < OutputsLambda.Count; j++)
            {
                temp -= CurrentValue*OutputsLambda[j];
            }
            K1 = temp*H;
            return K1;
        }

        public double CalculateK2()
        {
            double temp = 0;
            for (int i = 0; i < Inputs.Count; i++)
            {
                temp += (Inputs[i].CurrentValue + Inputs[i].k1/2)*InputsLambda[i];
            }
            for (int j = 0; j < OutputsLambda.Count; j++)
            {
                temp -= (CurrentValue + k1/2)*OutputsLambda[j];
            }
            K2 = temp * H;
            return K2;
        }

        public double CalculateK3()
        {
            double temp = 0;
            for (int i = 0; i < Inputs.Count; i++)
            {
                temp += (Inputs[i].CurrentValue + Inputs[i].k2 / 2) * InputsLambda[i];
            }
            for (int j = 0; j < OutputsLambda.Count; j++)
            {
                temp -= (CurrentValue + k2 / 2) * OutputsLambda[j];
            }
            K3 = temp * H;
            return K3;
        }

        public double CalculateK4()
        {
            double temp = 0;
            for (int i = 0; i < Inputs.Count; i++)
            {
                temp += (Inputs[i].CurrentValue + Inputs[i].k3) * InputsLambda[i];
            }
            for (int j = 0; j < OutputsLambda.Count; j++)
            {
                temp -= (CurrentValue + k3) * OutputsLambda[j];
            }
            K4 = temp * H;
            return K4;
        }

        public double CalculateNextValue()
        {
            nextValue = CurrentValue + (K1 + 2 * K2 + 2 * K3 + K4) / 6;
            currentValue = nextValue;
            return currentValue;
        }
    }
}
