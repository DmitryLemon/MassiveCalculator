﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    interface IModel
    {
        uint getHpointer();
        string[] getHistory();
        void addHistory(string newstep);
    }
}
