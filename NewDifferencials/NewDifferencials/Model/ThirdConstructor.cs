using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewDifferencials.Model
{
    public class ThirdConstructor
    {
        private List<P> pi;
        private List<P> pij;
        private List<P> pji;
        private List<P> pik;
        private List<P> pil;

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

        public List<P> Pik
        {
            get { return pik; }
        }

        public List<P> Pil
        {
            get { return pil; }
        }

        public void CreateModel(int components, double lambda, double mu, double e, double v, double mu1, double mu2, double mu3, double mu4, double h)
        {
            pi = new List<P>();
            pij = new List<P>();
            pji = new List<P>();
            pik = new List<P>();
            pil = new List<P>();

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
                pik.Add(new P(0, h));
                pil.Add(new P(0, h));
            }
            pi.Add(new P(0, h));

            for (int j = 0; j < pij.Count; j++)
            {
                pi[j].AddInput(pij[j], mu);
                pi[j].AddOutput(lambda);
                pi[j].AddInput(pji[j], e);
                pi[j].AddOutput(v);
                pi[j].AddOutput(mu1);
                pi[j].AddOutput(mu2);

                pij[j].AddInput(pi[j], lambda);
                pij[j].AddOutput(mu);

                pji[j].AddInput(pi[j], v);
                pji[j].AddOutput(e);

                pik[j].AddInput(pi[j],mu1);
                pik[j].AddOutput(mu3);

                pil[j].AddInput(pi[j],mu2);
                pil[j].AddOutput(mu4);

                pi[j + 1].AddInput(pik[j], mu3);
                pi[j + 1].AddInput(pil[j], mu4);
            }
        }
    }
}
