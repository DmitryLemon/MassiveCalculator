﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Operators
{
    class Substract : IOperator
    {
        public void perform(double input, Presenter presenter)
        {

            presenter.showStatus(12, 22, 2, "substraction");
        }
    }
}
