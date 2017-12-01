using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewDifferencials.Model;

namespace NewDifferencials.Controller
{
    public abstract class IDataContainer
    {
        public int ModelComponents;
        public int TimeSteps;
        public double Time;
        public double Mu;
        public double Lambda;
    }
}
