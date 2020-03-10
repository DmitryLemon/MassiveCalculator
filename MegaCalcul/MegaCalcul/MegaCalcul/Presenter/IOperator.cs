using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    interface IOperator
    {
        void perform(double input, Presenter presenter);
    }
}
