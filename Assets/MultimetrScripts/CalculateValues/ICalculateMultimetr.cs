using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimetr
{
    internal interface ICalculateMultimetr
    {
        public void ValueFilter(TypeValue type);
        public float ResistanceCalculate();
        public double currentStrangthCalculate();
        public double VoltageDCCalculate();
        public double VoltageACCalculate();
    }
}
