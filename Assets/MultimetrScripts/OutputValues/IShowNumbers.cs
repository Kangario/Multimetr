using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multimetr
{
    internal interface IShowNumbers
    {
        public void ShowValues(MultimetrValues values, TypeValue typeValue);

    }
}
