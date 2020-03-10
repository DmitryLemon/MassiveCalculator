using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IView
    {
        void statusShow(double percentage, string status);
        void showHistory(string[] history, uint pointer);
    }
}
