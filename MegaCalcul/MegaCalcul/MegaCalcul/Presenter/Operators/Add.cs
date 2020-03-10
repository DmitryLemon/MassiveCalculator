using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Operators
{
    class Add : IOperator
    {
        public void perform(double input, Presenter presenter)
        {

            presenter.showStatus(12,44,2,"addition");
        }
    }
}
