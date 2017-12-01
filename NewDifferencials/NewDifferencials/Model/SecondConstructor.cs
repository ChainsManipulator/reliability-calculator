using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewDifferencials.Model
{
    public class SecondConstructor
    {
        private List<P> pi;
        private List<P> pij;
        private List<P> pji;

        public List<P> Pi
        {
            get { return pi; }
        }

        public List<P> Pij
        {
            get { return pij; }
        }

        public List<P> Pji
        {
            get { return pji; }
        }

        public void CreateModel(int components, double lambda, double mu, double e, double v, double mui, double h)
        {
            pi = new List<P>();
            pij = new List<P>();
            pji = new List<P>();

            for (int i = 0; i < components; i++)
            {
                if (i == 0)
                {
                    pi.Add(new P(1, h));
                }
                else
                {
                    pi.Add(new P(0, h));
                }
                pij.Add(new P(0, h));
                pji.Add(new P(0, h));
            }
            pi.Add(new P(0, h));

            for (int j = 0; j < pij.Count; j++)
            {
                pi[j].AddInput(pij[j], mu);
                pi[j].AddOutput(lambda);
                pi[j].AddInput(pji[j], e);
                pi[j].AddOutput(v);
                pi[j].AddOutput(mui);

                pij[j].AddInput(pi[j], lambda);
                pij[j].AddOutput(mu);

                pji[j].AddInput(pi[j], v);
                pji[j].AddOutput(e);

                pi[j + 1].AddInput(pi[j], mui);
            }
        }
    }
}
