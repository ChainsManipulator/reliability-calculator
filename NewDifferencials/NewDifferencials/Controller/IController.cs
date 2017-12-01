using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewDifferencials.Controller
{
    public abstract class IController
    {
        public abstract ResultContainer Calculate(IDataContainer dataContainer);

        protected void CalculateNextStep()
        {
            CalculateK1();
            CalculateK2();
            CalculateK3();
            CalculateK4();
            CalculateNextValue();
        }

        protected abstract void CalculateK1();
        protected abstract void CalculateK2();
        protected abstract void CalculateK3();
        protected abstract void CalculateK4();
        protected abstract void CalculateNextValue();

    }
}
