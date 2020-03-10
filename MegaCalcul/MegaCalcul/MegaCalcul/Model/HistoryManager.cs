using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class HistoryManager
    {
        public string[] list;
        public uint pointer;

        public HistoryManager()
        {
            list = new string[0];
            pointer = 0;
        }
        
        public void add(string newstep)
        {
            list = new string[pointer];
            pointer++;
            list[pointer-1] = newstep;
        }

        public void Reset()
        {
            list = new string[0];
            pointer = 0;
        }
    }
}
