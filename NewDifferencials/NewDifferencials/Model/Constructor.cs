using System.Collections.Generic;

namespace NewDifferencials.Model
{
    public class Constructor
    {
        private List<P> pi;
        private List<P> pij;

        public List<P> Pi
        {
            get { return pi; }
        }

        public List<P> Pij
        {
            get { return pij; }
        }

        public void CreateModel(int components, double lambda, double mu, double mui, double h)
        {
            pi = new List<P>();
            pij = new List<P>();

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
            }

            pi.Add(new P(0, h));

            for (int j = 0; j < pij.Count; j++)
            {
                pi[j].AddInput(pij[j], mu);
                pi[j].AddOutput(lambda);
                pi[j].AddOutput(mui);

                pij[j].AddInput(pi[j], lambda);
                pij[j].AddOutput(mu);

                pi[j + 1].AddInput(pi[j], mui);
            }
        }
    }
}
